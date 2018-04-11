namespace orgCube
{
    partial class app
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pokaz_wyniki = new System.Windows.Forms.Panel();
            this.zawody = new System.Windows.Forms.ComboBox();
            this.runda = new System.Windows.Forms.ComboBox();
            this.konkurencja = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.organizator_tabControl = new System.Windows.Forms.TabControl();
            this.org_dodajZawody = new System.Windows.Forms.TabPage();
            this.org_modyfikujZawody = new System.Windows.Forms.TabPage();
            this.org_dodajZawodnika = new System.Windows.Forms.TabPage();
            this.delegat_tabControl = new System.Windows.Forms.TabControl();
            this.del_dodajWyniki = new System.Windows.Forms.TabPage();
            this.del_akceptacjaWynikow = new System.Windows.Forms.TabPage();
            this.del_akceptacjaZawodow = new System.Windows.Forms.TabPage();
            this.del_raportWCA = new System.Windows.Forms.TabPage();
            this.rejestrator_tabControl = new System.Windows.Forms.TabControl();
            this.rej_dodajZawodnika = new System.Windows.Forms.TabPage();
            this.rej_dodajWyniki = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.zobaczWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlaRejestratora = new System.Windows.Forms.ToolStripMenuItem();
            this.dlaOrganizatora = new System.Windows.Forms.ToolStripMenuItem();
            this.dlaDelegata = new System.Windows.Forms.ToolStripMenuItem();
            this.zaloguj = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pokaz_wyniki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.organizator_tabControl.SuspendLayout();
            this.delegat_tabControl.SuspendLayout();
            this.rejestrator_tabControl.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pokaz_wyniki);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.organizator_tabControl);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.delegat_tabControl);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rejestrator_tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(688, 389);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menu);
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 68);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(798, 389);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // pokaz_wyniki
            // 
            this.pokaz_wyniki.Controls.Add(this.zawody);
            this.pokaz_wyniki.Controls.Add(this.runda);
            this.pokaz_wyniki.Controls.Add(this.konkurencja);
            this.pokaz_wyniki.Controls.Add(this.dataGridView1);
            this.pokaz_wyniki.Location = new System.Drawing.Point(3, 3);
            this.pokaz_wyniki.Name = "pokaz_wyniki";
            this.pokaz_wyniki.Size = new System.Drawing.Size(685, 390);
            this.pokaz_wyniki.TabIndex = 3;
            // 
            // zawody
            // 
            this.zawody.FormattingEnabled = true;
            this.zawody.Location = new System.Drawing.Point(3, 3);
            this.zawody.Name = "zawody";
            this.zawody.Size = new System.Drawing.Size(679, 21);
            this.zawody.TabIndex = 3;
            this.zawody.Text = "wybierz zawody";
            // 
            // runda
            // 
            this.runda.FormattingEnabled = true;
            this.runda.Location = new System.Drawing.Point(434, 30);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(248, 21);
            this.runda.TabIndex = 2;
            this.runda.Text = "wybierz rundę";
            // 
            // konkurencja
            // 
            this.konkurencja.FormattingEnabled = true;
            this.konkurencja.Location = new System.Drawing.Point(3, 30);
            this.konkurencja.Name = "konkurencja";
            this.konkurencja.Size = new System.Drawing.Size(425, 21);
            this.konkurencja.TabIndex = 1;
            this.konkurencja.Text = "wybierz konkurencję";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(679, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // organizator_tabControl
            // 
            this.organizator_tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.organizator_tabControl.Controls.Add(this.org_dodajZawody);
            this.organizator_tabControl.Controls.Add(this.org_modyfikujZawody);
            this.organizator_tabControl.Controls.Add(this.org_dodajZawodnika);
            this.organizator_tabControl.Location = new System.Drawing.Point(3, 3);
            this.organizator_tabControl.Multiline = true;
            this.organizator_tabControl.Name = "organizator_tabControl";
            this.organizator_tabControl.SelectedIndex = 0;
            this.organizator_tabControl.Size = new System.Drawing.Size(685, 390);
            this.organizator_tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.organizator_tabControl.TabIndex = 4;
            this.organizator_tabControl.Visible = false;
            // 
            // org_dodajZawody
            // 
            this.org_dodajZawody.BackColor = System.Drawing.Color.Transparent;
            this.org_dodajZawody.Location = new System.Drawing.Point(4, 25);
            this.org_dodajZawody.Name = "org_dodajZawody";
            this.org_dodajZawody.Padding = new System.Windows.Forms.Padding(3);
            this.org_dodajZawody.Size = new System.Drawing.Size(677, 361);
            this.org_dodajZawody.TabIndex = 0;
            this.org_dodajZawody.Text = "dodaj zawody";
            // 
            // org_modyfikujZawody
            // 
            this.org_modyfikujZawody.Location = new System.Drawing.Point(4, 25);
            this.org_modyfikujZawody.Name = "org_modyfikujZawody";
            this.org_modyfikujZawody.Padding = new System.Windows.Forms.Padding(3);
            this.org_modyfikujZawody.Size = new System.Drawing.Size(677, 361);
            this.org_modyfikujZawody.TabIndex = 1;
            this.org_modyfikujZawody.Text = "modyfikuj zawody";
            this.org_modyfikujZawody.UseVisualStyleBackColor = true;
            // 
            // org_dodajZawodnika
            // 
            this.org_dodajZawodnika.Location = new System.Drawing.Point(4, 25);
            this.org_dodajZawodnika.Name = "org_dodajZawodnika";
            this.org_dodajZawodnika.Size = new System.Drawing.Size(677, 361);
            this.org_dodajZawodnika.TabIndex = 2;
            this.org_dodajZawodnika.Text = "dodaj zawodnika";
            this.org_dodajZawodnika.UseVisualStyleBackColor = true;
            // 
            // delegat_tabControl
            // 
            this.delegat_tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.delegat_tabControl.Controls.Add(this.del_dodajWyniki);
            this.delegat_tabControl.Controls.Add(this.del_akceptacjaWynikow);
            this.delegat_tabControl.Controls.Add(this.del_akceptacjaZawodow);
            this.delegat_tabControl.Controls.Add(this.del_raportWCA);
            this.delegat_tabControl.Location = new System.Drawing.Point(3, 3);
            this.delegat_tabControl.Multiline = true;
            this.delegat_tabControl.Name = "delegat_tabControl";
            this.delegat_tabControl.SelectedIndex = 0;
            this.delegat_tabControl.Size = new System.Drawing.Size(685, 390);
            this.delegat_tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.delegat_tabControl.TabIndex = 1;
            this.delegat_tabControl.Visible = false;
            // 
            // del_dodajWyniki
            // 
            this.del_dodajWyniki.BackColor = System.Drawing.Color.Transparent;
            this.del_dodajWyniki.Location = new System.Drawing.Point(4, 25);
            this.del_dodajWyniki.Name = "del_dodajWyniki";
            this.del_dodajWyniki.Padding = new System.Windows.Forms.Padding(3);
            this.del_dodajWyniki.Size = new System.Drawing.Size(677, 361);
            this.del_dodajWyniki.TabIndex = 0;
            this.del_dodajWyniki.Text = "dodaj wyniki";
            // 
            // del_akceptacjaWynikow
            // 
            this.del_akceptacjaWynikow.Location = new System.Drawing.Point(4, 25);
            this.del_akceptacjaWynikow.Name = "del_akceptacjaWynikow";
            this.del_akceptacjaWynikow.Padding = new System.Windows.Forms.Padding(3);
            this.del_akceptacjaWynikow.Size = new System.Drawing.Size(677, 361);
            this.del_akceptacjaWynikow.TabIndex = 1;
            this.del_akceptacjaWynikow.Text = "akceptacja wyników";
            this.del_akceptacjaWynikow.UseVisualStyleBackColor = true;
            // 
            // del_akceptacjaZawodow
            // 
            this.del_akceptacjaZawodow.Location = new System.Drawing.Point(4, 25);
            this.del_akceptacjaZawodow.Name = "del_akceptacjaZawodow";
            this.del_akceptacjaZawodow.Size = new System.Drawing.Size(677, 361);
            this.del_akceptacjaZawodow.TabIndex = 2;
            this.del_akceptacjaZawodow.Text = "akceptacja zawodów";
            this.del_akceptacjaZawodow.UseVisualStyleBackColor = true;
            // 
            // del_raportWCA
            // 
            this.del_raportWCA.Location = new System.Drawing.Point(4, 25);
            this.del_raportWCA.Name = "del_raportWCA";
            this.del_raportWCA.Size = new System.Drawing.Size(677, 361);
            this.del_raportWCA.TabIndex = 3;
            this.del_raportWCA.Text = "raport wyników";
            this.del_raportWCA.UseVisualStyleBackColor = true;
            // 
            // rejestrator_tabControl
            // 
            this.rejestrator_tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.rejestrator_tabControl.Controls.Add(this.rej_dodajZawodnika);
            this.rejestrator_tabControl.Controls.Add(this.rej_dodajWyniki);
            this.rejestrator_tabControl.Location = new System.Drawing.Point(3, 3);
            this.rejestrator_tabControl.Multiline = true;
            this.rejestrator_tabControl.Name = "rejestrator_tabControl";
            this.rejestrator_tabControl.SelectedIndex = 0;
            this.rejestrator_tabControl.Size = new System.Drawing.Size(685, 390);
            this.rejestrator_tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.rejestrator_tabControl.TabIndex = 0;
            this.rejestrator_tabControl.Visible = false;
            // 
            // rej_dodajZawodnika
            // 
            this.rej_dodajZawodnika.BackColor = System.Drawing.Color.Transparent;
            this.rej_dodajZawodnika.Location = new System.Drawing.Point(4, 25);
            this.rej_dodajZawodnika.Name = "rej_dodajZawodnika";
            this.rej_dodajZawodnika.Padding = new System.Windows.Forms.Padding(3);
            this.rej_dodajZawodnika.Size = new System.Drawing.Size(677, 361);
            this.rej_dodajZawodnika.TabIndex = 0;
            this.rej_dodajZawodnika.Text = "dodaj zawodnika";
            // 
            // rej_dodajWyniki
            // 
            this.rej_dodajWyniki.Location = new System.Drawing.Point(4, 25);
            this.rej_dodajWyniki.Name = "rej_dodajWyniki";
            this.rej_dodajWyniki.Padding = new System.Windows.Forms.Padding(3);
            this.rej_dodajWyniki.Size = new System.Drawing.Size(677, 361);
            this.rej_dodajWyniki.TabIndex = 1;
            this.rej_dodajWyniki.Text = "dodaj / modyfikuj wyniki";
            this.rej_dodajWyniki.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobaczWynikiToolStripMenuItem,
            this.dlaRejestratora,
            this.dlaOrganizatora,
            this.dlaDelegata});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(110, 389);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // zobaczWynikiToolStripMenuItem
            // 
            this.zobaczWynikiToolStripMenuItem.Name = "zobaczWynikiToolStripMenuItem";
            this.zobaczWynikiToolStripMenuItem.Size = new System.Drawing.Size(92, 19);
            this.zobaczWynikiToolStripMenuItem.Text = "zobacz wyniki";
            this.zobaczWynikiToolStripMenuItem.Click += new System.EventHandler(this.zobaczWynikiToolStripMenuItem_Click);
            // 
            // dlaRejestratora
            // 
            this.dlaRejestratora.Enabled = false;
            this.dlaRejestratora.Name = "dlaRejestratora";
            this.dlaRejestratora.Size = new System.Drawing.Size(97, 19);
            this.dlaRejestratora.Text = "dla rejestratora";
            this.dlaRejestratora.Click += new System.EventHandler(this.dlaRejestratora_Click);
            // 
            // dlaOrganizatora
            // 
            this.dlaOrganizatora.Enabled = false;
            this.dlaOrganizatora.Name = "dlaOrganizatora";
            this.dlaOrganizatora.Size = new System.Drawing.Size(104, 19);
            this.dlaOrganizatora.Text = "dla organizatora";
            this.dlaOrganizatora.Click += new System.EventHandler(this.dlaOrganizatora_Click);
            // 
            // dlaDelegata
            // 
            this.dlaDelegata.Enabled = false;
            this.dlaDelegata.Name = "dlaDelegata";
            this.dlaDelegata.Size = new System.Drawing.Size(83, 19);
            this.dlaDelegata.Text = "dla delegata";
            this.dlaDelegata.Click += new System.EventHandler(this.dlaDelegata_Click);
            // 
            // zaloguj
            // 
            this.zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj.Location = new System.Drawing.Point(683, 21);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(114, 35);
            this.zaloguj.TabIndex = 6;
            this.zaloguj.Text = "Zaloguj się!";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Maroon;
            this.name.Location = new System.Drawing.Point(174, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 44);
            this.name.TabIndex = 5;
            this.name.Text = "orgCube";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(822, 469);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "app";
            this.ShowIcon = false;
            this.Text = "orgCube";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pokaz_wyniki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.organizator_tabControl.ResumeLayout(false);
            this.delegat_tabControl.ResumeLayout(false);
            this.rejestrator_tabControl.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl delegat_tabControl;
        private System.Windows.Forms.TabPage del_dodajWyniki;
        private System.Windows.Forms.TabPage del_akceptacjaWynikow;
        private System.Windows.Forms.TabPage del_akceptacjaZawodow;
        private System.Windows.Forms.TabPage del_raportWCA;
        private System.Windows.Forms.TabControl rejestrator_tabControl;
        private System.Windows.Forms.TabPage rej_dodajZawodnika;
        private System.Windows.Forms.TabPage rej_dodajWyniki;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem zobaczWynikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dlaRejestratora;
        private System.Windows.Forms.ToolStripMenuItem dlaOrganizatora;
        private System.Windows.Forms.ToolStripMenuItem dlaDelegata;
        private System.Windows.Forms.Button zaloguj;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel pokaz_wyniki;
        private System.Windows.Forms.ComboBox zawody;
        private System.Windows.Forms.ComboBox runda;
        private System.Windows.Forms.ComboBox konkurencja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl organizator_tabControl;
        private System.Windows.Forms.TabPage org_dodajZawody;
        private System.Windows.Forms.TabPage org_modyfikujZawody;
        private System.Windows.Forms.TabPage org_dodajZawodnika;
    }
}

