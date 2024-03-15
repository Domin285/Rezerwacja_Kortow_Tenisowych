namespace ProjektBazy
{
    partial class FormDodaj
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
            this.text_data = new System.Windows.Forms.TextBox();
            this.text_event = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_select = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_data
            // 
            this.text_data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_data.Location = new System.Drawing.Point(63, 182);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(314, 30);
            this.text_data.TabIndex = 0;
            // 
            // text_event
            // 
            this.text_event.Location = new System.Drawing.Point(61, 107);
            this.text_event.Name = "text_event";
            this.text_event.Size = new System.Drawing.Size(314, 30);
            this.text_event.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // button_zapisz
            // 
            this.button_zapisz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zapisz.Location = new System.Drawing.Point(335, 324);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(75, 31);
            this.button_zapisz.TabIndex = 4;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.BlueViolet;
            this.button_exit.Location = new System.Drawing.Point(414, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(30, 30);
            this.button_exit.TabIndex = 14;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Godzina";
            // 
            // text_select
            // 
            this.text_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_select.FormattingEnabled = true;
            this.text_select.Items.AddRange(new object[] {
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00"});
            this.text_select.Location = new System.Drawing.Point(63, 259);
            this.text_select.Name = "text_select";
            this.text_select.Size = new System.Drawing.Size(314, 31);
            this.text_select.TabIndex = 16;
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(456, 404);
            this.Controls.Add(this.text_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_event);
            this.Controls.Add(this.text_data);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDodaj";
            this.Load += new System.EventHandler(this.FormDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_data;
        private System.Windows.Forms.TextBox text_event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox text_select;
    }
}