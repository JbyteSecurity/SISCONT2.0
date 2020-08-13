using System;
using System.Data;
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
            NetworkState();
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

            if (user != "" && contrasenia != "")
            {

                DataTable dataTableLogin = new DataTable();

                contrasenia = usuario.GetSHA1(contrasenia);

                dataTableLogin = usuario.Login(user, contrasenia);

                if (dataTableLogin != null)
                {
                    string userDB = dataTableLogin.Rows[0]["Usuario"].ToString();
                    string passDB = dataTableLogin.Rows[0]["Contrasenia"].ToString();
                    string nombreDB = dataTableLogin.Rows[0]["Nombre"].ToString();

                    if (user.Equals(userDB) && contrasenia.Equals(passDB))
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.username = userDB;
                        frmPrincipal.nombreUsuario = nombreDB;
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

        private void NetworkState()
        {
            string Estado = "";
            System.Uri Url = new System.Uri("http://198.12.230.10");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objetoResp;
            try
            {
                objetoResp = WebRequest.GetResponse();
                Estado = "";
                objetoResp.Close();
            }
            catch (Exception e)
            {
                Estado = "Verifique la conexión al servidor";
            }
            lblServerConnectStatus.Text = Estado;
            WebRequest = null;
        }
    }
}
