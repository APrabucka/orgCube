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
    public partial class login : Form
    {
        private app main_window;
        
        public login(app window)
        {
            InitializeComponent();
            main_window = window;
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUzytkownika = this.text_login.Text;
            string hasloUzytkownika = this.text_password.Text;

            try
            {
                if (loginUzytkownika == "admin" & hasloUzytkownika == "admin")
                {
                    this.main_window.zalogowano();
                    this.Close();
                }
                else if (loginUzytkownika == "rejestrator" & hasloUzytkownika == "rej")
                {
                    this.main_window.zalogowano_rej();
                    this.Close();
                }
                else if (loginUzytkownika == "organizator" & hasloUzytkownika == "org")
                {
                    this.main_window.zalogowano_org();
                    this.Close();
                }
                else if (loginUzytkownika == "delegat" & hasloUzytkownika == "del")
                {
                    this.main_window.zalogowano_del();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło","BŁĄD");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
