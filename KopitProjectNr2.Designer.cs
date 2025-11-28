namespace projekt2_Padukh77277
{
    partial class KopitProjectNr2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalIndyw = new System.Windows.Forms.Button();
            this.btnAnalLabor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 126); // Или используйте 413, 23 — выберите актуальное
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1218, 159);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analizator tabelacyjny i graficzny funkcji matematycznych\r\nw podanym przedziale {" +
    "Xd,Xg} zmian wartości zmiennej \r\nniezależnej X\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAnalIndyw
            // 
            this.btnAnalIndyw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalIndyw.Location = new System.Drawing.Point(378, 470); // Или 473, 367
            this.btnAnalIndyw.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalIndyw.Name = "btnAnalIndyw";
            this.btnAnalIndyw.Size = new System.Drawing.Size(384, 330);
            this.btnAnalIndyw.TabIndex = 4;
            this.btnAnalIndyw.Text = "Analizator Indywidualny";
            this.btnAnalIndyw.UseVisualStyleBackColor = true;
            this.btnAnalIndyw.Click += new System.EventHandler(this.btnAnalIndyw_Click);
            // 
            // btnAnalLabor
            // 
            this.btnAnalLabor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalLabor.Location = new System.Drawing.Point(1125, 470); // Или 1220, 367
            this.btnAnalLabor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalLabor.Name = "btnAnalLabor";
            this.btnAnalLabor.Size = new System.Drawing.Size(384, 330);
            this.btnAnalLabor.TabIndex = 5;
            this.btnAnalLabor.Text = "Analizator Labaratoryjny";
            this.btnAnalLabor.UseVisualStyleBackColor = true;
            this.btnAnalLabor.Click += new System.EventHandler(this.btnAnalLabor_Click);
            // 
            // KopitProjectNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 926); // Или 2026, 875 — унифицируйте
            this.Controls.Add(this.btnAnalLabor);
            this.Controls.Add(this.btnAnalIndyw);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KopitProjectNr2";
            this.Text = "KopitProjectNr2";
            this.Load += new System.EventHandler(this.KopitProjectNr2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalIndyw;
        private System.Windows.Forms.Button btnAnalLabor;
    }
}