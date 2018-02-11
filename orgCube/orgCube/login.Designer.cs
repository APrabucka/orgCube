namespace orgCube
{
    partial class login
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_login = new System.Windows.Forms.Label();
            this.lab_haslo = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.ok_button_zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_login
            // 
            this.lab_login.AutoSize = true;
            this.lab_login.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_login.Location = new System.Drawing.Point(72, 61);
            this.lab_login.Name = "lab_login";
            this.lab_login.Size = new System.Drawing.Size(53, 21);
            this.lab_login.TabIndex = 1;
            this.lab_login.Text = "Login";
            // 
            // lab_haslo
            // 
            this.lab_haslo.AutoSize = true;
            this.lab_haslo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_haslo.Location = new System.Drawing.Point(73, 113);
            this.lab_haslo.Name = "lab_haslo";
            this.lab_haslo.Size = new System.Drawing.Size(52, 21);
            this.lab_haslo.TabIndex = 2;
            this.lab_haslo.Text = "Hasło";
            // 
            // text_login
            // 
            this.text_login.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_login.Location = new System.Drawing.Point(201, 55);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(195, 27);
            this.text_login.TabIndex = 3;
            this.text_login.Text = "login";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_password.Location = new System.Drawing.Point(201, 107);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(195, 27);
            this.text_password.TabIndex = 4;
            this.text_password.Text = "password";
            this.text_password.UseSystemPasswordChar = true;
            // 
            // ok_button_zaloguj
            // 
            this.ok_button_zaloguj.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_button_zaloguj.Location = new System.Drawing.Point(325, 182);
            this.ok_button_zaloguj.Name = "ok_button_zaloguj";
            this.ok_button_zaloguj.Size = new System.Drawing.Size(111, 34);
            this.ok_button_zaloguj.TabIndex = 5;
            this.ok_button_zaloguj.Text = "OK";
            this.ok_button_zaloguj.UseVisualStyleBackColor = true;
            this.ok_button_zaloguj.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(483, 255);
            this.Controls.Add(this.ok_button_zaloguj);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.lab_haslo);
            this.Controls.Add(this.lab_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.Text = "Zaloguj się!";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_login;
        private System.Windows.Forms.Label lab_haslo;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button ok_button_zaloguj;
    }
}

