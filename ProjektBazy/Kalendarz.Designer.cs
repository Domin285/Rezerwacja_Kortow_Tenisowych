namespace ProjektBazy
{
    partial class Kalendarz
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_container = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_nastepny = new System.Windows.Forms.Button();
            this.button_poprzedni = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(4, 77);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(702, 403);
            this.panel_container.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Niedziela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poniedziałek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Środa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wtorek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Piątek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Czwartek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sobota";
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(100, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(94, 70);
            this.panel9.TabIndex = 3;
            // 
            // button_nastepny
            // 
            this.button_nastepny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nastepny.Location = new System.Drawing.Point(585, 16);
            this.button_nastepny.Name = "button_nastepny";
            this.button_nastepny.Size = new System.Drawing.Size(94, 23);
            this.button_nastepny.TabIndex = 10;
            this.button_nastepny.Text = "Nastepny";
            this.button_nastepny.UseVisualStyleBackColor = true;
            this.button_nastepny.Click += new System.EventHandler(this.button_nastepny_Click);
            // 
            // button_poprzedni
            // 
            this.button_poprzedni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_poprzedni.Location = new System.Drawing.Point(482, 16);
            this.button_poprzedni.Name = "button_poprzedni";
            this.button_poprzedni.Size = new System.Drawing.Size(97, 23);
            this.button_poprzedni.TabIndex = 11;
            this.button_poprzedni.Text = "Poprzedni";
            this.button_poprzedni.UseVisualStyleBackColor = true;
            this.button_poprzedni.Click += new System.EventHandler(this.button_poprzedni_Click);
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_date.Location = new System.Drawing.Point(16, 19);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(254, 23);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "MONTH YEAR";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kalendarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_nastepny);
            this.Controls.Add(this.button_poprzedni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_container);
            this.Name = "Kalendarz";
            this.Size = new System.Drawing.Size(709, 496);
            this.Load += new System.EventHandler(this.Kalendarz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_nastepny;
        private System.Windows.Forms.Button button_poprzedni;
        private System.Windows.Forms.Label label_date;
    }
}
