namespace orgCube
{
    partial class hello
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
            this.panel_hello = new System.Windows.Forms.Panel();
            this.witaj = new System.Windows.Forms.Label();
            this.name_2 = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_hello.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_hello
            // 
            this.panel_hello.Controls.Add(this.witaj);
            this.panel_hello.Controls.Add(this.name_2);
            this.panel_hello.Controls.Add(this.log_in);
            this.panel_hello.Location = new System.Drawing.Point(12, 12);
            this.panel_hello.Name = "panel_hello";
            this.panel_hello.Size = new System.Drawing.Size(685, 389);
            this.panel_hello.TabIndex = 4;
            // 
            // witaj
            // 
            this.witaj.AutoSize = true;
            this.witaj.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.witaj.Location = new System.Drawing.Point(95, 47);
            this.witaj.Name = "witaj";
            this.witaj.Size = new System.Drawing.Size(522, 105);
            this.witaj.TabIndex = 6;
            this.witaj.Text = "Czołem Speeedcuberzy!\r\n\r\nPrzed Wami aplikacja, która zrewolucjonizowała świat Spe" +
    "edcubingu!\r\n\r\nPoznajcie i zaprzyjaźnijcie się z ...";
            this.witaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_2
            // 
            this.name_2.AutoSize = true;
            this.name_2.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_2.ForeColor = System.Drawing.Color.Maroon;
            this.name_2.Location = new System.Drawing.Point(268, 175);
            this.name_2.Name = "name_2";
            this.name_2.Size = new System.Drawing.Size(164, 44);
            this.name_2.TabIndex = 5;
            this.name_2.Text = "orgCube";
            // 
            // log_in
            // 
            this.log_in.AutoSize = true;
            this.log_in.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.log_in.Location = new System.Drawing.Point(147, 271);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(388, 63);
            this.log_in.TabIndex = 5;
            this.log_in.Text = "Jesteś rejestratorem, organizatorem, delegatem?\r\n\r\nZaloguj się, aby mieć dostęp d" +
    "o dodatkowych opcji!";
            this.log_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(501, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Świetnie! Zaczynajmy!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_hello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hello";
            this.ShowIcon = false;
            this.Text = "orgCube";
            this.panel_hello.ResumeLayout(false);
            this.panel_hello.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_hello;
        private System.Windows.Forms.Label witaj;
        private System.Windows.Forms.Label name_2;
        private System.Windows.Forms.Label log_in;
        private System.Windows.Forms.Button button1;
    }
}