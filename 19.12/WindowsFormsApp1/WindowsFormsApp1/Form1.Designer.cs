namespace WindowsFormsApp1
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dane = new System.Windows.Forms.TextBox();
            this.txtObwod = new System.Windows.Forms.TextBox();
            this.txtPole = new System.Windows.Forms.TextBox();
            this.Komunikat = new System.Windows.Forms.Label();
            this.btnWyczsc = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bok";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Obwód";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pole";
            // 
            // Dane
            // 
            this.Dane.Location = new System.Drawing.Point(101, 48);
            this.Dane.Name = "Dane";
            this.Dane.Size = new System.Drawing.Size(70, 20);
            this.Dane.TabIndex = 1;
            this.Dane.TextChanged += new System.EventHandler(this.Dane_TextChanged);
            // 
            // txtObwod
            // 
            this.txtObwod.Location = new System.Drawing.Point(101, 82);
            this.txtObwod.Name = "txtObwod";
            this.txtObwod.Size = new System.Drawing.Size(70, 20);
            this.txtObwod.TabIndex = 1;
            // 
            // txtPole
            // 
            this.txtPole.Location = new System.Drawing.Point(101, 117);
            this.txtPole.Name = "txtPole";
            this.txtPole.Size = new System.Drawing.Size(70, 20);
            this.txtPole.TabIndex = 1;
            // 
            // Komunikat
            // 
            this.Komunikat.AutoSize = true;
            this.Komunikat.ForeColor = System.Drawing.Color.Crimson;
            this.Komunikat.Location = new System.Drawing.Point(192, 51);
            this.Komunikat.Name = "Komunikat";
            this.Komunikat.Size = new System.Drawing.Size(0, 13);
            this.Komunikat.TabIndex = 0;
            this.Komunikat.Click += new System.EventHandler(this.Komunikat_Click);
            // 
            // btnWyczsc
            // 
            this.btnWyczsc.Location = new System.Drawing.Point(46, 153);
            this.btnWyczsc.Name = "btnWyczsc";
            this.btnWyczsc.Size = new System.Drawing.Size(75, 23);
            this.btnWyczsc.TabIndex = 2;
            this.btnWyczsc.Text = "Wyczyść";
            this.btnWyczsc.UseVisualStyleBackColor = true;
            this.btnWyczsc.Click += new System.EventHandler(this.btnWyczsc_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(128, 155);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Zamknij";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 275);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnWyczsc);
            this.Controls.Add(this.txtPole);
            this.Controls.Add(this.txtObwod);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Komunikat);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dane;
        private System.Windows.Forms.TextBox txtObwod;
        private System.Windows.Forms.TextBox txtPole;
        private System.Windows.Forms.Label Komunikat;
        private System.Windows.Forms.Button btnWyczsc;
        private System.Windows.Forms.Button BtnClose;
    }
}

