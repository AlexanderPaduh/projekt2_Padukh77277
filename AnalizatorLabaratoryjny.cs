using System;
using System.Windows.Forms;
using System.Globalization; // Изменение: Добавлен using для System.Globalization, чтобы использовать CultureInfo.InvariantCulture для независимого от локали парсинга чисел.
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
namespace projekt2_Padukh77277
{
    public partial class AnalizatorLabaratoryjny : Form
    {
        const ushort OdstępMięzyControlkami = 5;
        const ushort LewaKrawedzCharAreas = 5;
        const ushort GornaKrawedzCharAreas = 15;
        const ushort SzerokoscCharAreas = 80;
        const ushort WysokoscCharAreas = 75;

        public AnalizatorLabaratoryjny()
        {
            InitializeComponent();

            // Если Chart не в дизайнере — создай вручную:
            ChtWycresFx = new Chart();
            ChtWycresFx.Visible = false; // Скрыт до вызова
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

        private void btnWizualizacjaTabelaryczna_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float A, B, C, Xd, Xg, h;
            if (!PobranieDanychWejściowychDlaTablicowania(out A, out B, out C, out Xd, out Xg, out h))
            {
                errorProvider1.SetError(btnWizualizacjaTabelaryczna, "ERROR: w pobieranych danych wystąpił błąd" +
                    "i obsługa przycisku WizualizacjaTabelaryczna nie może być dokończona");
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

        private void btnObliczFx_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float A, B, C, X;
            if (!PobranieDanychWejściowych(out A, out B, out C, out X))
            {
                errorProvider1.SetError(btnObliczFx, "ERROR: nie moge konczyc obslugi tego przycisku, " +
                    "gdyz wustapil blad przy pobieraniu danych");
                return;
            }
            float WartośćFx = ObliczenieWartościFx(A, B, C, X);
            txtFx.Text = String.Format("{0:F2}", WartośćFx);
            txtFx.Enabled = false;
            btnObliczFx.Enabled = false;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtX.Enabled = false;
        }

        private void dgvTWFx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWizualizacjaGraficzna_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float A, B, C, Xd, Xg, h;
            if (!PobranieDanychWejściowychDlaTablicowania(out A, out B, out C, out Xd, out Xg, out h))
            {
                errorProvider1.SetError(btnWizualizacjaGraficzna, "ERROR: w pobieranych danych wystąpił błąd i obsługa "
                    + "przycisku WizualizacjaTabelaryczna nie może być dokończona");
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
            //dgvTWFx.Visible = true;
            txtA.Enabled = txtB.Enabled = txtC.Enabled = txtX.Enabled = txtXd.Enabled = txtXg.Enabled = txtH.Enabled = false;
            WpisanieDanychDoKontlkiChar(TWFx, ref ChtWycresFx);
            //ustawie stanu aktywności kontrolek uczestniczecych w wizualizacji

            dgvTWFx.Visible = false;         // Скрываем таблицу
            ChtWycresFx.Visible = true;      // Показываем график
            ChtWycresFx.BringToFront();      // !!! Выводим график на передний план (поверх всего)
            ChtWycresFx.UseWaitCursor = false;

        }

        //deklracja metody: WpisanieDpKontrolkkiChar
        void WpisanieDanychDoKontlkiChar(float[,] TWFx, ref Chart ChtWycresFx)
        {
            // 1. УБЕДИСЬ, ЧТО Chart добавлен на форму!
            if (!this.Controls.Contains(ChtWycresFx))
            {
                this.Controls.Add(ChtWycresFx);
            }

            // 2. Позиция и размер
            ChtWycresFx.Location = new Point(
                lblAnalizator.Left + 10 * OdstępMięzyControlkami,
                lblAnalizator.Bottom + 5 * OdstępMięzyControlkami
            );

            int widthOfset = dgvTWFx.RowHeadersWidth;
            if (dgvTWFx.Columns.Count >= 3)
            {
                widthOfset += dgvTWFx.Columns[0].Width +
                              dgvTWFx.Columns[1].Width +
                              dgvTWFx.Columns[2].Width;
            }

            ChtWycresFx.Width = (int)(1.5f * widthOfset);
            ChtWycresFx.Height = (int)(this.ClientSize.Height * 0.65f);
            ChtWycresFx.BringToFront(); // На передний план

            // 3. Стиль
            ChtWycresFx.BorderlineWidth = 2;
            ChtWycresFx.BorderlineColor = Color.AliceBlue;
            ChtWycresFx.BorderlineDashStyle = ChartDashStyle.DashDotDot;
            ChtWycresFx.BackColor = Color.LightSkyBlue;

            // 4. Заголовок
            ChtWycresFx.Titles.Clear();
            ChtWycresFx.Titles.Add("Wykres równania kwadratowego");

            // 5. Легенда
            ChtWycresFx.Legends.Clear();
            var myLegend = ChtWycresFx.Legends.Add("MojaLegenda");
            myLegend.Title = "Legenda: ";
            myLegend.Docking = Docking.Bottom;

            // 6. Очистка и настройка ChartArea
            ChtWycresFx.ChartAreas.Clear();
            var obszar = ChtWycresFx.ChartAreas.Add("ObszarWykresu");

            // --- КРИТИЧНО: НАСТРОЙКА ПОЗИЦИИ В ПРОЦЕНТАХ ---
            obszar.Position.Auto = false;
            obszar.Position.X = 8;      // 8% от левого края Chart
            obszar.Position.Y = 10;     // 10% от верха
            obszar.Position.Width = 85; // 85% ширины
            obszar.Position.Height = 75;// 75% высоты

            // --- ВАЖНО: InnerPlotPosition — где реально рисуется график ---
            obszar.InnerPlotPosition.Auto = false;
            obszar.InnerPlotPosition.X = 10;
            obszar.InnerPlotPosition.Y = 10;
            obszar.InnerPlotPosition.Width = 80;
            obszar.InnerPlotPosition.Height = 75;

            // 7. Оси
            obszar.AxisX.Title = "Zmienna X";
            obszar.AxisY.Title = "Wartość F(x)";
            obszar.AxisX.TitleAlignment = StringAlignment.Far;
            obszar.AxisX.LabelStyle.Format = "{0:F1}";
            obszar.AxisY.LabelStyle.Format = "{0:F2}";
            obszar.AxisX.MajorGrid.Enabled = true;
            obszar.AxisX.MajorGrid.LineColor = Color.LightGray;
            obszar.AxisX.Interval = h > 0 ? h : 1; // Динамический шаг

            // 8. Серия
            ChtWycresFx.Series.Clear();
            var seria = ChtWycresFx.Series.Add("Wykres F(x)");
            seria.ChartType = SeriesChartType.Line;
            seria.Color = Color.Blue;
            seria.BorderWidth = 3;
            seria.IsVisibleInLegend = true;

            // 9. Добавление точек
            if (TWFx != null && TWFx.GetLength(0) > 0)
            {
                for (int i = 0; i < TWFx.GetLength(0); i++)
                {
                    seria.Points.AddXY(TWFx[i, 1], TWFx[i, 2]);
                }
            }

            // 10. Принудительное обновление
            ChtWycresFx.Invalidate();
            ChtWycresFx.Update();
        }
        private void btnTestChart_Click(object sender, EventArgs e)
        {
            float[,] test = new float[5, 3];
            for (int i = 0; i < 5; i++)
            {
                test[i, 0] = i;
                test[i, 1] = i;
                test[i, 2] = i * i; // y = x²
            }
            WpisanieDanychDoKontlkiChar(test, ref ChtWycresFx);
            ChtWycresFx.Visible = true;
            ChtWycresFx.BringToFront();
        }


    }
}

            //    //wyczysczenie serii danych opisujacych wukres
            //    ChtWycresFx.Series.Clear();
            //    //dodanie wlasnej serii danych
            //    ChtWycresFx.Series.Add("Seria 0");
            //    //ustawienie wizualizacji legendy serii
            //    ChtWycresFx.Series[0].IsVisibleInLegend = true;
            //    //sformatowanie nowej serii danych
            //    ChtWycresFx.Series[0].Name = "Wykres F(x)";
            //    ChtWycresFx.Series[0].ChartType = SeriesChartType.Line;
            //    ChtWycresFx.Series[0].Color = Color.Blue;
            //    ChtWycresFx.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            //    ChtWycresFx.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            //    //wpisanie d oserii danych [0] danych z tablict TWFx
            //    for (int i = 0; i < TWFx.GetLength(0); i++)
            //    {
            //        ChtWycresFx.Series[0].Points.AddXY(TWFx[i, 1], TWFx[i, 2]);
            //    }

            //}





            #endregion
 