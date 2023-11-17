using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFI.GUI
{
    public partial class Login : Form
    {
        SessionManager.Session oSesion = SessionManager.Session.Instancia;
        Boolean _Autorizado = false;

        public bool Autorizado { get => _Autorizado; }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (oSesion.IniciarSesion(txtUsuario.Text, txtClave.Text))
            {
                _Autorizado = true;             
                this.Hide();
                
                Close();
            }
            else
            {
                _Autorizado = false;
                lblMensaje.Text = "USUARIO O CLAVE INCORRECTOS";
                txtClave.Focus();
                txtClave.SelectAll();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "RCASTRO";
            txtClave.Text = "rC@str0";
        }


    }
}
