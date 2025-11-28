namespace projekt2_Padukh77277
{
    partial class AnalizatorLabaratoryjny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTWFx = new System.Windows.Forms.DataGridView();
            this.kolNumerPrzedziału = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolWartośćX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolWartośćFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPrzedziałX = new System.Windows.Forms.GroupBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.btnObliczFx = new System.Windows.Forms.Button();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).BeginInit();
            this.grbPrzedziałX.SuspendLayout();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTWFx
            // 
            this.dgvTWFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolNumerPrzedziału,
            this.kolWartośćX,
            this.kolWartośćFx});
            this.dgvTWFx.Location = new System.Drawing.Point(610, 297);
            this.dgvTWFx.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTWFx.Name = "dgvTWFx";
            this.dgvTWFx.RowHeadersWidth = 51;
            this.dgvTWFx.RowTemplate.Height = 24;
            this.dgvTWFx.Size = new System.Drawing.Size(487, 566);
            this.dgvTWFx.TabIndex = 20;
            // 
            // kolNumerPrzedziału
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolNumerPrzedziału.DefaultCellStyle = dataGridViewCellStyle1;
            this.kolNumerPrzedziału.HeaderText = "Numer Przedziału X";
            this.kolNumerPrzedziału.MinimumWidth = 6;
            this.kolNumerPrzedziału.Name = "kolNumerPrzedziału";
            this.kolNumerPrzedziału.Width = 50;
            // 
            // kolWartośćX
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolWartośćX.DefaultCellStyle = dataGridViewCellStyle2;
            this.kolWartośćX.HeaderText = "Wartość zmiennej X";
            this.kolWartośćX.MinimumWidth = 6;
            this.kolWartośćX.Name = "kolWartośćX";
            this.kolWartośćX.Width = 125;
            // 
            // kolWartośćFx
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolWartośćFx.DefaultCellStyle = dataGridViewCellStyle3;
            this.kolWartośćFx.HeaderText = "Wartość F(x)";
            this.kolWartośćFx.MinimumWidth = 6;
            this.kolWartośćFx.Name = "kolWartośćFx";
            this.kolWartośćFx.Width = 150;
            // 
            // grbPrzedziałX
            // 
            this.grbPrzedziałX.Controls.Add(this.txtH);
            this.grbPrzedziałX.Controls.Add(this.label9);
            this.grbPrzedziałX.Controls.Add(this.txtXg);
            this.grbPrzedziałX.Controls.Add(this.label8);
            this.grbPrzedziałX.Controls.Add(this.txtXd);
            this.grbPrzedziałX.Controls.Add(this.label7);
            this.grbPrzedziałX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrzedziałX.Location = new System.Drawing.Point(80, 527);
            this.grbPrzedziałX.Margin = new System.Windows.Forms.Padding(4);
            this.grbPrzedziałX.Name = "grbPrzedziałX";
            this.grbPrzedziałX.Padding = new System.Windows.Forms.Padding(4);
            this.grbPrzedziałX.Size = new System.Drawing.Size(275, 336);
            this.grbPrzedziałX.TabIndex = 19;
            this.grbPrzedziałX.TabStop = false;
            this.grbPrzedziałX.Text = "Przedział zmian wartości X";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(87, 184);
            this.txtH.Margin = new System.Windows.Forms.Padding(4);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(136, 40);
            this.txtH.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 33);
            this.label9.TabIndex = 4;
            this.label9.Text = "h:";
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(87, 123);
            this.txtXg.Margin = new System.Windows.Forms.Padding(4);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(136, 40);
            this.txtXg.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "Xg:";
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(87, 70);
            this.txtXd.Margin = new System.Windows.Forms.Padding(4);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(136, 40);
            this.txtXd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Xd:";
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(1558, 375);
            this.btnWizualizacjaTabelaryczna.Margin = new System.Windows.Forms.Padding(4);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(217, 120);
            this.btnWizualizacjaTabelaryczna.TabIndex = 18;
            this.btnWizualizacjaTabelaryczna.Text = "wizualizacja tabliczna zmian wartoścs F(X)";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1553, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Wynik: wartość F(x)\r\n";
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(1602, 163);
            this.txtFx.Margin = new System.Windows.Forms.Padding(4);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(136, 29);
            this.txtFx.TabIndex = 16;
            this.txtFx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnObliczFx
            // 
            this.btnObliczFx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObliczFx.Location = new System.Drawing.Point(1558, 234);
            this.btnObliczFx.Margin = new System.Windows.Forms.Padding(4);
            this.btnObliczFx.Name = "btnObliczFx";
            this.btnObliczFx.Size = new System.Drawing.Size(217, 132);
            this.btnObliczFx.TabIndex = 15;
            this.btnObliczFx.Text = "Oblicz wartość funkcji F(x)\r\n";
            this.btnObliczFx.UseVisualStyleBackColor = true;
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.txtX);
            this.gr1.Controls.Add(this.txtC);
            this.gr1.Controls.Add(this.txtB);
            this.gr1.Controls.Add(this.txtA);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr1.Location = new System.Drawing.Point(80, 99);
            this.gr1.Margin = new System.Windows.Forms.Padding(4);
            this.gr1.Name = "gr1";
            this.gr1.Padding = new System.Windows.Forms.Padding(4);
            this.gr1.Size = new System.Drawing.Size(275, 382);
            this.gr1.TabIndex = 14;
            this.gr1.TabStop = false;
            this.gr1.Text = "Dane wyjściowe a, b, c, X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(77, 312);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(136, 40);
            this.txtX.TabIndex = 7;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(77, 218);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(136, 40);
            this.txtC.TabIndex = 6;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(77, 156);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(136, 40);
            this.txtB.TabIndex = 5;
            this.txtB.Text = "6";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(77, 99);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(136, 40);
            this.txtA.TabIndex = 4;
            this.txtA.Text = "3";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Analizator równiania kwadratowego (czyli F(x))\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AnalizatorLabaratoryjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2140, 1372);
            this.Controls.Add(this.dgvTWFx);
            this.Controls.Add(this.grbPrzedziałX);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.btnObliczFx);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.label1);
            this.Name = "AnalizatorLabaratoryjny";
            this.Text = "AnalizatorLabaratoryjny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).EndInit();
            this.grbPrzedziałX.ResumeLayout(false);
            this.grbPrzedziałX.PerformLayout();
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTWFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolNumerPrzedziału;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolWartośćX;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolWartośćFx;
        private System.Windows.Forms.GroupBox grbPrzedziałX;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.Button btnObliczFx;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}