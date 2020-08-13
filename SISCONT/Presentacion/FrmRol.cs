using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmRol : Form
    {
        Rol rol = new Rol();
        bool edit = false;
        public FrmRol()
        {
            InitializeComponent();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            All();

            dgvRol.Columns["idRol"].Visible = false;
            dgvRol.Columns["Nombre"].Width = 200;
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
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Destroy();
        }

        private void All()
        {
            dgvRol.DataSource = rol.All();
        }
        private void Save() {
            string nombre = txtNombre.Text;
            if (edit)
            {
                int id = Convert.ToInt32(dgvRol.CurrentRow.Cells["idRol"].Value);
                if (rol.Update(id, nombre))
                {
                    MessageBox.Show("Rol actualizado correstamente", "Rol .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    All();
                    Clear();
                } else MessageBox.Show("Rol no actualizado", "Rol .::. Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (rol.Insert(nombre))
                {
                    MessageBox.Show("Rol registrado correstamente", "Rol .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    All();
                    Clear();
                }
                else MessageBox.Show("Rol no registrado", "Rol .::. Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Edit()
        {
            if (dgvRol.SelectedRows.Count > 0)
            {
                edit = true;
                txtNombre.Text = dgvRol.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void Destroy() 
        {
            int id = Convert.ToInt32(dgvRol.CurrentRow.Cells["idRol"].Value);
            DialogResult dialogResult = MessageBox.Show("¿Realmente quieres eliminar este ROL?", "Rol .::. Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.Yes)
            {
                if (rol.Destroy(id))
                {
                    All();
                    Clear();
                }
                else MessageBox.Show("Rol no actualizado", "Rol .::. Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear()
        {
            txtNombre.Text = null;
            txtNombre.Focus();
            edit = false;
        }
    }
}
