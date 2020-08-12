using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario = new Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 367;
            this.Height = 338;
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void EnterClick(object sender, KeyPressEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string user = txtUsuario.Text.ToLower();
            string contrasenia = txtContrasenia.Text;

            if (!user.Equals("") && !contrasenia.Equals(""))
            {

                DataTable dataTableLogin = new DataTable();

                dataTableLogin = usuario.Login(user, contrasenia);

                if (dataTableLogin != null)
                {
                    string userDB = dataTableLogin.Rows[0]["Usuario"].ToString();
                    string passDB = dataTableLogin.Rows[0]["Contrasenia"].ToString();

                    if (user.Equals(userDB) && contrasenia.Equals(passDB))
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Usuario o Contraseña Incorrecto", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Usuario y Contraseña son Obligarotios", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtUsuarioKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (txtUsuario.Text != "")
                {
                    if (txtContrasenia.Text != "")
                        Login();
                    else
                        txtContrasenia.Focus();
                }
            }
        }

        private void txtContraseniaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (txtUsuario.Text != "" && txtContrasenia.Text != "")
                    Login();
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
