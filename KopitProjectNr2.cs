using System;
using System.Windows.Forms;

namespace projekt2_Padukh77277
{
    public partial class KopitProjectNr2 : Form
    {
        public KopitProjectNr2()
        {
            InitializeComponent();
        }

        private void btnAnalLabor_Click(object sender, EventArgs e)
        {
            foreach (Form FormAnalizatorLabor in Application.OpenForms)
            {
                if (FormAnalizatorLabor.Name == "AnalizatorLabaratoryjny") // Исправьте на правильное имя
                {
                    this.Hide();
                    FormAnalizatorLabor.Show();
                    return;
                }
            }
            AnalizatorLabaratoryjny ReferencjaDoAL = new AnalizatorLabaratoryjny();
            this.Hide();
            ReferencjaDoAL.Show();
        }

        private void KopitProjectNr2_Load(object sender, EventArgs e)
        {
            // Добавьте код загрузки, если нужно
        }

        private void btnAnalIndyw_Click(object sender, EventArgs e)
        {
            // Добавьте логику для индивидуального анализатора, если нужно
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Добавьте логику, если нужно
        }
    }
}