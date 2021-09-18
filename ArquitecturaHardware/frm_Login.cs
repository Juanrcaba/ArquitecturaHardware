using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquitecturaHardware
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != string.Empty && txt_password.Text != string.Empty)
            {
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();               
                this.Show();
                txt_user.Clear();
                txt_password.Clear();
                txt_user.Focus();
            }
            else
                MessageBox.Show("debe insertar datos");
               
        }
    }
}
