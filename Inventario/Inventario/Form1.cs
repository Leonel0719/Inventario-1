using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Acción del boton ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Variables
           string User = txtUser.Text;
           string Password = txtPassword.Text;

            //Estructura Si y SiNo para las credenciales.

            if(User == "Admin" && Password == "Admin2024")
            {
                this.DialogResult = DialogResult.OK;

                MessageBox.Show("Acceso concedido, Bienvenida/o");

                Form2 ir = new Form2();
                ir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, Usuario o contraseña incorrecta, intente de nuevo");

                txtUser.Text = "";
                txtPassword.Text = "";
            }

            
        }
    }
}
