using Negocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmUsuario : Form
    {
        Usuario usuario = new Usuario();
        Rol rol = new Rol();
        bool edit = false;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            All();
            FillComboRol();

            dgvUsuarios.Columns["ID"].Visible = false;
            //dgvUsuarios.Columns["RolID"].Visible = false;
            cboRol.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Destroy();
        }

        private void All()
        {
            dgvUsuarios.DataSource = usuario.All();
        }

        private void Save()
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string user = txtUsuario.Text;
            string telefono = txtTelefono.Text;
            string contrasenia = txtContrasenia.Text;
            string contraseniaConfirma = txtContraseniaConfirma.Text;
            int rolID = cboRol.SelectedIndex;

            if (edit)
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
                if ((contrasenia.Equals("") && contraseniaConfirma.Equals("")) | (!contrasenia.Equals("") && contrasenia.Equals(contraseniaConfirma)))
                {
                    if (usuario.Update(id, user, contrasenia, nombre, correo, telefono, rolID))
                    {
                        MessageBox.Show("Usuario Actulizado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        All();
                        ClearText();
                    }
                    else
                        MessageBox.Show("Usuario NO Actulizado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                    MessageBox.Show("Las contraseñas no coinciden", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dataTable = new DataTable();
                dataTable = usuario.Show(user);

                if (dataTable.Rows.Count <= 0)
                {
                    if (!contrasenia.Equals("") && contrasenia.Equals(contraseniaConfirma))
                    {
                        if (usuario.Insert(user, contrasenia, nombre, correo, telefono, rolID))
                        {
                            MessageBox.Show("Usuario Guardado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            All();
                            ClearText();
                        }
                        else
                            MessageBox.Show("Usuario NO Guardado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Las contraseñas no coinciden", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Usuario (" + user + ") ya existe.", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Edit()
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                edit = true;
                int rolIdRow = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["RolID"].Value.ToString());
                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                cboRol.SelectedIndex = rolIdRow;
                //cboRol.SelectedItem = dgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
            if (usuario.Destroy(id))
            {
                MessageBox.Show("Usuario Eliminado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                All();
            }
            else
                MessageBox.Show("Usuario NO Eliminado", "Usuario .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FillComboRol()
        {
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "idRol";
            cboRol.DataSource = rol.All();
        }

        private void ClearText()
        {
            txtNombre.Text = null;
            txtCorreo.Text = null;
            txtUsuario.Text = null;
            txtTelefono.Text = null;
            txtContrasenia.Text = null;
            txtContraseniaConfirma.Text = null;
            cboRol.SelectedIndex = -1;

            txtNombre.Focus();
            edit = false;
        }
    }
}
