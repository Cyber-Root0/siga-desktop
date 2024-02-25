using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siga_desktop.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool isValid = rules();
            if (isValid)
            {

            }

        }
        private bool rules()
        {
            if (tb_login.Text == "")
            {
                MessageBox.Show("Preencha o CPF!");
                return false;
            }

            if (tb_senha.Text == "")
            {
                MessageBox.Show("Preencha a senha!");
                return false;
            }
            return true;
        }
    }
}
