using System;
using System.Windows.Forms;
using System.Globalization; // Изменение: Добавлен using для System.Globalization, чтобы использовать CultureInfo.InvariantCulture для независимого от локали парсинга чисел.

namespace projekt2_Padukh77277
{
    public partial class AnalizatorLabaratoryjny : Form
    {
        public AnalizatorLabaratoryjny()
        {
            InitializeComponent(); // Изменение: Добавлен конструктор формы с вызовом InitializeComponent(), чтобы инициализировать контролы из файла дизайнера. Без этого форма была пустой.
        }

        private void AnalizatorLabaratoryjny_Load(object sender, EventArgs e)
        {
            // Изменение: Добавлена настройка колонок для DataGridView в событии Load, чтобы избежать ошибок IndexOutOfRangeException при заполнении таблицы.
            // Это обеспечивает наличие минимум 3 колонок: для индекса, X и Fx.
            dgvTWFx.Columns.Add("Lp", "Lp"); // Колонка для порядкового номера (i)
            dgvTWFx.Columns.Add("X", "X");   // Колонка для значения X
            dgvTWFx.Columns.Add("Fx", "Fx"); // Колонка для значения функции Fx
            dgvTWFx.Visible = false;         // Скрываем таблицу изначально, как в логике кода.
        }

        private void btnObliczFx_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float A, B, C, X;
            if (!PobranieDanychWejściowych(out A, out B, out C, out X))
            {
                errorProvider1.SetError(btnObliczFx, "ERROR: nie mogę kończyć obsługi tego przycisku, gdyż wystąpił błąd przy pobieraniu danych");
                return;
            }
            float WartośćFx = ObliczenieWartościFx(A, B, C, X);
            txtFx.Text = String.Format("{0:F2}", WartośćFx);
            txtFx.Enabled = false;
            btnObliczFx.Enabled = false;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtX.Enabled = false;
        }

        private void btnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float A, B, C, Xd, Xg, h;
            if (!PobranieDanychWejściowychDlaTablicowania(out A, out B, out C, out Xd, out Xg, out h))
            {
                errorProvider1.SetError(btnWizualizacjaTabelaryczna, "ERROR: w pobieranych danych wystąpił błąd i obsługa przycisku WizualizacjaTabelaryczna nie może być dokończona");
                return;
            }
            if (!SprawdzenieWarunkówWejściowych(Xd, Xg, h))
            {
                errorProvider1.SetError(btnWizualizacjaTabelaryczna, "ERROR: dane wejściowe nie spełniają warunków");
                return;
            }
            float[,] TWFx;
            TablicowanieWartościFunkcjiFx(A, B, C, Xd, Xg, h, out TWFx);
            PrzepisanieWierszyDanychDoKontrolkiDataGridView(TWFx, ref dgvTWFx);
            btnWizualizacjaTabelaryczna.Enabled = false;
            dgvTWFx.Visible = true;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtX.Enabled = txtXd.Enabled = txtXg.Enabled = txtH.Enabled = false;
        }

        #region Metody pomocnicze
        bool pobierzLiczbęRzeczywistą(Control kontrolka, out float liczba)
        {
            // Изменение: В float.TryParse добавлены NumberStyles.Any и CultureInfo.InvariantCulture, чтобы парсинг работал независимо от локали системы (например, позволял использовать точку как десятичный разделитель, даже в системах с запятой).
            if (!float.TryParse(kontrolka.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out liczba))
            {
                errorProvider1.SetError(kontrolka, "ERROR: niedozwolony znak w liczbie");
                return false;
            }
            return true;
        }

        bool PobranieDanychWejściowych(out float A, out float B, out float C, out float X)
        {
            A = B = C = X = 0.0f;
            return pobierzLiczbęRzeczywistą(txtA, out A)
                && pobierzLiczbęRzeczywistą(txtB, out B)
                && pobierzLiczbęRzeczywistą(txtC, out C)
                && pobierzLiczbęRzeczywistą(txtX, out X);
        }

        bool PobranieDanychWejściowychDlaTablicowania(out float A, out float B, out float C, out float Xd, out float Xg, out float h)
        {
            A = B = C = Xd = Xg = h = 0.0f;
            return pobierzLiczbęRzeczywistą(txtA, out A)
                && pobierzLiczbęRzeczywistą(txtB, out B)
                && pobierzLiczbęRzeczywistą(txtC, out C)
                && pobierzLiczbęRzeczywistą(txtXd, out Xd)
                && pobierzLiczbęRzeczywistą(txtXg, out Xg)
                && pobierzLiczbęRzeczywistą(txtH, out h);
        }

        bool SprawdzenieWarunkówWejściowych(float Xd, float Xg, float h)
        {
            if (Xd >= Xg)
            {
                errorProvider1.SetError(txtXd, "ERROR: Xd musi być mniejsze niż Xg");
                return false;
            }
            if (h <= 0.0f)
            {
                errorProvider1.SetError(txtH, "ERROR: h musi być większe od zera");
                return false;
            }
            return true;
        }

        float ObliczenieWartościFx(float A, float B, float C, float X)
        {
            return A * X * X + B * X + C;
        }

        void TablicowanieWartościFunkcjiFx(float A, float B, float C, float Xd, float Xg, float h, out float[,] TWFx)
        {
            int n = (int)((Xg - Xd) / h) + 1;
            TWFx = new float[n, 3];
            float x = Xd;
            for (int i = 0; i < n; i++, x += h)
            {
                TWFx[i, 0] = i;
                TWFx[i, 1] = x;
                TWFx[i, 2] = ObliczenieWartościFx(A, B, C, x);
            }
            // Изменение: Добавлена корректировка последней точки, если из-за накопления ошибок float x не точно равно Xg (маленькое улучшение для точности, опционально, но полезно для float).
            if (x - h < Xg && x > Xg) // Если последняя x превысила Xg
            {
                TWFx[n - 1, 1] = Xg; // Устанавливаем точно Xg
                TWFx[n - 1, 2] = ObliczenieWartościFx(A, B, C, Xg);
            }
        }

        void PrzepisanieWierszyDanychDoKontrolkiDataGridView(float[,] TWFx, ref DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < TWFx.GetLength(0); i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = TWFx[i, 0];
                dgv.Rows[i].Cells[1].Value = String.Format("{0:F2}", TWFx[i, 1]);
                dgv.Rows[i].Cells[2].Value = String.Format("{0:F3}", TWFx[i, 2]);
            }
        }
        #endregion
    }
}