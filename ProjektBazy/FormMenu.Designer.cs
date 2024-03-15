namespace ProjektBazy
{
    partial class FormMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_nawigacja = new System.Windows.Forms.Panel();
            this.button_wyloguj = new System.Windows.Forms.Button();
            this.button_kalendarz = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.kalendarz2 = new ProjektBazy.Kalendarz(name);
            this.menu2 = new ProjektBazy.Menu(name);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel_nawigacja);
            this.panel1.Controls.Add(this.button_wyloguj);
            this.panel1.Controls.Add(this.button_kalendarz);
            this.panel1.Controls.Add(this.button_menu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel_nawigacja
            // 
            this.panel_nawigacja.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_nawigacja.Location = new System.Drawing.Point(0, 170);
            this.panel_nawigacja.Name = "panel_nawigacja";
            this.panel_nawigacja.Size = new System.Drawing.Size(3, 150);
            this.panel_nawigacja.TabIndex = 3;
            // 
            // button_wyloguj
            // 
            this.button_wyloguj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_wyloguj.FlatAppearance.BorderSize = 0;
            this.button_wyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wyloguj.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_wyloguj.ForeColor = System.Drawing.Color.BlueViolet;
            this.button_wyloguj.Location = new System.Drawing.Point(0, 507);
            this.button_wyloguj.Name = "button_wyloguj";
            this.button_wyloguj.Size = new System.Drawing.Size(186, 70);
            this.button_wyloguj.TabIndex = 5;
            this.button_wyloguj.Text = "Wyloguj";
            this.button_wyloguj.UseVisualStyleBackColor = true;
            this.button_wyloguj.Click += new System.EventHandler(this.button_wyloguj_Click);
            this.button_wyloguj.Leave += new System.EventHandler(this.button_wyloguj_Leave);
            // 
            // button_kalendarz
            // 
            this.button_kalendarz.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kalendarz.FlatAppearance.BorderSize = 0;
            this.button_kalendarz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kalendarz.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kalendarz.ForeColor = System.Drawing.Color.BlueViolet;
            this.button_kalendarz.Location = new System.Drawing.Point(0, 254);
            this.button_kalendarz.Name = "button_kalendarz";
            this.button_kalendarz.Size = new System.Drawing.Size(186, 110);
            this.button_kalendarz.TabIndex = 2;
            this.button_kalendarz.Text = "Kalendarz";
            this.button_kalendarz.UseVisualStyleBackColor = true;
            this.button_kalendarz.Click += new System.EventHandler(this.button_kalendarz_Click);
            this.button_kalendarz.Leave += new System.EventHandler(this.button_kalendarz_Leave);
            // 
            // button_menu
            // 
            this.button_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.ForeColor = System.Drawing.Color.BlueViolet;
            this.button_menu.Location = new System.Drawing.Point(0, 144);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(186, 110);
            this.button_menu.TabIndex = 1;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            this.button_menu.Leave += new System.EventHandler(this.button_menu_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.username_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjektBazy.Properties.Resources.user5;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.ForeColor = System.Drawing.Color.BlueViolet;
            this.username_label.Location = new System.Drawing.Point(47, 88);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(94, 23);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "User name";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // button_exit
            // 
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(909, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(30, 30);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // kalendarz2
            // 
            this.kalendarz2.BackColor = System.Drawing.Color.White;
            this.kalendarz2.Location = new System.Drawing.Point(193, 67);
            this.kalendarz2.Margin = new System.Windows.Forms.Padding(4);
            this.kalendarz2.Name = "kalendarz2";
            this.kalendarz2.Size = new System.Drawing.Size(745, 496);
            this.kalendarz2.TabIndex = 15;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.White;
            this.menu2.Location = new System.Drawing.Point(193, 67);
            this.menu2.Margin = new System.Windows.Forms.Padding(4);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(746, 497);
            this.menu2.TabIndex = 14;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.kalendarz2);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button button_wyloguj;
        private System.Windows.Forms.Button button_kalendarz;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Panel panel_nawigacja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private Menu menu2;
        private Kalendarz kalendarz2;
    }
}