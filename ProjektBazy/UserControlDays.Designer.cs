namespace ProjektBazy
{
    partial class UserControlDays
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
            this.label_dni = new System.Windows.Forms.Label();
            this.label_event = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.BackColor = System.Drawing.Color.White;
            this.label_dni.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dni.Location = new System.Drawing.Point(33, 11);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(28, 21);
            this.label_dni.TabIndex = 0;
            this.label_dni.Text = "00";
            // 
            // label_event
            // 
            this.label_event.AutoSize = true;
            this.label_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_event.Location = new System.Drawing.Point(71, 30);
            this.label_event.Name = "label_event";
            this.label_event.Size = new System.Drawing.Size(20, 20);
            this.label_event.TabIndex = 1;
            this.label_event.Text = "+";
            this.label_event.Click += new System.EventHandler(this.label_event_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_event);
            this.Controls.Add(this.label_dni);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(94, 50);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_event;
    }
}
