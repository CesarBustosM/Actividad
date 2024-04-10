using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadRealizar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tengo aqui de momento una validacion para el correo y la contraseña.
            //Esta es mi actividad actualizada.
            string correo, contraseña;
            //Hay que validar de momento con la parte local
            correo = textBox1.Text;
            contraseña = textBox2.Text;
            if (correo == "Admin@gmail.com" && contraseña == "admin123")
            {
                Ingresado Pprincipal = new Ingresado();
                Pprincipal.Show();
            }
            
        } 
    }
}
