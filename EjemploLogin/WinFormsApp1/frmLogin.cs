using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un Usuario");
                return;

            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una Contraseña");
                return;


            }

            MessageBox.Show("Usted ha ingresado al Sistema");
            this.Close();
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Se debe ingresar un Usuario");
                return;
            
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Se debe ingresar una Contraseña");
                return;


            }

            if ((ValidarCredenciales(txtContraseña.Text, txtUsuario.Text))
            {

                MessageBox.Show("Usted ha ingresado al Sistema");
                this.Close();
            }

            else
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                MessageBox.Show("Debe Ingresar un Usuario y Contraseña Valido");            
            
            }


        }
    

    }
}
