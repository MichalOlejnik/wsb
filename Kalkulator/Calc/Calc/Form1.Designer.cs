namespace Calc
{
    partial class Form1
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
            this.ZERO = new System.Windows.Forms.Button();
            this.DOT = new System.Windows.Forms.Button();
            this.PLUS = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Button();
            this.ONE = new System.Windows.Forms.Button();
            this.TWO = new System.Windows.Forms.Button();
            this.THREE = new System.Windows.Forms.Button();
            this.MINUS = new System.Windows.Forms.Button();
            this.FOUR = new System.Windows.Forms.Button();
            this.FIVE = new System.Windows.Forms.Button();
            this.SIX = new System.Windows.Forms.Button();
            this.MUL = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SEVEN = new System.Windows.Forms.Button();
            this.EIGHT = new System.Windows.Forms.Button();
            this.NINE = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZERO
            // 
            this.ZERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZERO.Location = new System.Drawing.Point(11, 250);
            this.ZERO.Name = "ZERO";
            this.ZERO.Size = new System.Drawing.Size(96, 45);
            this.ZERO.TabIndex = 0;
            this.ZERO.Text = "0";
            this.ZERO.UseVisualStyleBackColor = true;
            this.ZERO.Click += new System.EventHandler(this.ONE_Click);
            // 
            // DOT
            // 
            this.DOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DOT.Location = new System.Drawing.Point(113, 250);
            this.DOT.Name = "DOT";
            this.DOT.Size = new System.Drawing.Size(45, 45);
            this.DOT.TabIndex = 0;
            this.DOT.Text = ",";
            this.DOT.UseVisualStyleBackColor = true;
            this.DOT.Click += new System.EventHandler(this.DOT_Click);
            // 
            // PLUS
            // 
            this.PLUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PLUS.Location = new System.Drawing.Point(164, 250);
            this.PLUS.Name = "PLUS";
            this.PLUS.Size = new System.Drawing.Size(45, 45);
            this.PLUS.TabIndex = 0;
            this.PLUS.Text = "+";
            this.PLUS.UseVisualStyleBackColor = true;
            this.PLUS.Click += new System.EventHandler(this.PLUS_Click);
            // 
            // wynik
            // 
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(215, 199);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(45, 96);
            this.wynik.TabIndex = 0;
            this.wynik.Text = "=";
            this.wynik.UseVisualStyleBackColor = true;
            this.wynik.Click += new System.EventHandler(this.wynik_Click);
            // 
            // ONE
            // 
            this.ONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ONE.Location = new System.Drawing.Point(11, 199);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(45, 45);
            this.ONE.TabIndex = 0;
            this.ONE.Text = "1";
            this.ONE.UseVisualStyleBackColor = true;
            this.ONE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // TWO
            // 
            this.TWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TWO.Location = new System.Drawing.Point(62, 199);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(45, 45);
            this.TWO.TabIndex = 0;
            this.TWO.Text = "2";
            this.TWO.UseVisualStyleBackColor = true;
            this.TWO.Click += new System.EventHandler(this.ONE_Click);
            // 
            // THREE
            // 
            this.THREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.THREE.Location = new System.Drawing.Point(113, 199);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(45, 45);
            this.THREE.TabIndex = 0;
            this.THREE.Text = "3";
            this.THREE.UseVisualStyleBackColor = true;
            this.THREE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // MINUS
            // 
            this.MINUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MINUS.Location = new System.Drawing.Point(164, 199);
            this.MINUS.Name = "MINUS";
            this.MINUS.Size = new System.Drawing.Size(45, 45);
            this.MINUS.TabIndex = 0;
            this.MINUS.Text = "-";
            this.MINUS.UseVisualStyleBackColor = true;
            this.MINUS.Click += new System.EventHandler(this.MINUS_Click);
            // 
            // FOUR
            // 
            this.FOUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FOUR.Location = new System.Drawing.Point(11, 148);
            this.FOUR.Name = "FOUR";
            this.FOUR.Size = new System.Drawing.Size(45, 45);
            this.FOUR.TabIndex = 0;
            this.FOUR.Text = "4";
            this.FOUR.UseVisualStyleBackColor = true;
            this.FOUR.Click += new System.EventHandler(this.ONE_Click);
            // 
            // FIVE
            // 
            this.FIVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FIVE.Location = new System.Drawing.Point(62, 148);
            this.FIVE.Name = "FIVE";
            this.FIVE.Size = new System.Drawing.Size(45, 45);
            this.FIVE.TabIndex = 0;
            this.FIVE.Text = "5";
            this.FIVE.UseVisualStyleBackColor = true;
            this.FIVE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // SIX
            // 
            this.SIX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SIX.Location = new System.Drawing.Point(113, 148);
            this.SIX.Name = "SIX";
            this.SIX.Size = new System.Drawing.Size(45, 45);
            this.SIX.TabIndex = 0;
            this.SIX.Text = "6";
            this.SIX.UseVisualStyleBackColor = true;
            this.SIX.Click += new System.EventHandler(this.ONE_Click);
            // 
            // MUL
            // 
            this.MUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MUL.Location = new System.Drawing.Point(164, 148);
            this.MUL.Name = "MUL";
            this.MUL.Size = new System.Drawing.Size(45, 45);
            this.MUL.TabIndex = 0;
            this.MUL.Text = "*";
            this.MUL.UseVisualStyleBackColor = true;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(215, 148);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 0;
            this.button15.Text = "1/X";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // SEVEN
            // 
            this.SEVEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SEVEN.Location = new System.Drawing.Point(11, 97);
            this.SEVEN.Name = "SEVEN";
            this.SEVEN.Size = new System.Drawing.Size(45, 45);
            this.SEVEN.TabIndex = 0;
            this.SEVEN.Text = "7";
            this.SEVEN.UseVisualStyleBackColor = true;
            this.SEVEN.Click += new System.EventHandler(this.ONE_Click);
            // 
            // EIGHT
            // 
            this.EIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EIGHT.Location = new System.Drawing.Point(62, 97);
            this.EIGHT.Name = "EIGHT";
            this.EIGHT.Size = new System.Drawing.Size(45, 45);
            this.EIGHT.TabIndex = 0;
            this.EIGHT.Text = "8";
            this.EIGHT.UseVisualStyleBackColor = true;
            this.EIGHT.Click += new System.EventHandler(this.ONE_Click);
            // 
            // NINE
            // 
            this.NINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NINE.Location = new System.Drawing.Point(113, 97);
            this.NINE.Name = "NINE";
            this.NINE.Size = new System.Drawing.Size(45, 45);
            this.NINE.TabIndex = 0;
            this.NINE.Text = "9";
            this.NINE.UseVisualStyleBackColor = true;
            this.NINE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // DIV
            // 
            this.DIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DIV.Location = new System.Drawing.Point(164, 97);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(45, 45);
            this.DIV.TabIndex = 0;
            this.DIV.Text = "/";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.Location = new System.Drawing.Point(215, 97);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(45, 45);
            this.button20.TabIndex = 0;
            this.button20.Text = "%";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DELETE.Location = new System.Drawing.Point(11, 46);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(45, 45);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "<-";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CE.Location = new System.Drawing.Point(62, 46);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(45, 45);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CLEAR.Location = new System.Drawing.Point(113, 46);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(45, 45);
            this.CLEAR.TabIndex = 0;
            this.CLEAR.Text = "C";
            this.CLEAR.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button24.Location = new System.Drawing.Point(164, 46);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 0;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.Location = new System.Drawing.Point(215, 46);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 45);
            this.button25.TabIndex = 0;
            this.button25.Text = "X";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(14, 10);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(245, 30);
            this.result.TabIndex = 1;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 306);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.MUL);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.NINE);
            this.Controls.Add(this.MINUS);
            this.Controls.Add(this.SIX);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.EIGHT);
            this.Controls.Add(this.THREE);
            this.Controls.Add(this.FIVE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.PLUS);
            this.Controls.Add(this.SEVEN);
            this.Controls.Add(this.TWO);
            this.Controls.Add(this.FOUR);
            this.Controls.Add(this.DOT);
            this.Controls.Add(this.ONE);
            this.Controls.Add(this.ZERO);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZERO;
        private System.Windows.Forms.Button DOT;
        private System.Windows.Forms.Button PLUS;
        private System.Windows.Forms.Button wynik;
        private System.Windows.Forms.Button ONE;
        private System.Windows.Forms.Button TWO;
        private System.Windows.Forms.Button THREE;
        private System.Windows.Forms.Button MINUS;
        private System.Windows.Forms.Button FOUR;
        private System.Windows.Forms.Button FIVE;
        private System.Windows.Forms.Button SIX;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button SEVEN;
        private System.Windows.Forms.Button EIGHT;
        private System.Windows.Forms.Button NINE;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox result;
    }
}

