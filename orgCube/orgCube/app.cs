using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orgCube
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void zobaczWynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pokaz_wyniki.Show();
            //this.pokaz_wyniki.Visible = true;
        }

        private void dlaRejestratora_Click(object sender, EventArgs e)
        {
            rejestrator_tabControl.Show();
            organizator_tabControl.Visible = false;
            delegat_tabControl.Visible = false;
            pokaz_wyniki.Visible = false;
        }

        private void dlaOrganizatora_Click(object sender, EventArgs e)
        {
            organizator_tabControl.Show();
            rejestrator_tabControl.Visible = false;
            delegat_tabControl.Visible = false;
            pokaz_wyniki.Visible = false;
        }

        private void dlaDelegata_Click(object sender, EventArgs e)
        {
            delegat_tabControl.Show();
            rejestrator_tabControl.Visible = false;
            organizator_tabControl.Visible = false;
            pokaz_wyniki.Visible = false;
        }

        public void zalogowano()
        {
            //organizator_tabControl.Visible = true;
            //rejestrator_tabControl.Visible = true;
            //delegat_tabControl.Visible = true;
            dlaOrganizatora.Enabled = true;
            dlaRejestratora.Enabled = true;
            dlaDelegata.Enabled = true;
        }

        public void zalogowano_rej()
        {
            //rejestrator_tabControl.Visible = true;
            dlaRejestratora.Enabled = true;
        }

        public void zalogowano_org()
        {
            //organizator_tabControl.Visible = true;
            dlaOrganizatora.Enabled = true;
        }

        public void zalogowano_del()
        {
            //delegat_tabControl.Visible = true;
            dlaDelegata.Enabled = true;
        }

        private void zaloguj_Click(object sender, EventArgs e)
        {
            login log = new login(this);
            log.ShowDialog();
        }
    }
}
