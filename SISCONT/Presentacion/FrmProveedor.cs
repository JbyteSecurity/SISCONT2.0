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
    public partial class FrmProveedor : Form
    {
        private Proveedor proveedor = new Proveedor();
        private bool method = false;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            All();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Destroy();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            GetToTextBox();
        }

        private void Save()
        {
            string ruc, razonSocial;
            ruc = txtRuc.Text;
            razonSocial = txtRazonSocial.Text;
            if (method)
            {
                int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["ID"].Value);
                if (proveedor.Update(id, ruc, razonSocial))
                {
                    MessageBox.Show("Proveedor Editado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    All();
                }
                else
                    MessageBox.Show("Proveedor NO Editado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (proveedor.Insert(ruc, razonSocial))
                {
                    MessageBox.Show("Proveedor Agregado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    All();
                }
                else
                    MessageBox.Show("Proveedor NO Agregado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBox()
        {
            txtRuc.Text = null;
            txtRazonSocial.Text = null;
            this.ActiveControl = txtRuc;
        }

        private void All()
        {
            dgvSuppliers.DataSource = proveedor.All();
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["ID"].Value);
            if (proveedor.Destroy(id))
            {
                MessageBox.Show("Proveedor Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                All();
            }
            else
                MessageBox.Show("Proveedor NO Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GetToTextBox()
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                method = true;
                txtRuc.Text = dgvSuppliers.CurrentRow.Cells["RUC"].Value.ToString();
                txtRazonSocial.Text = dgvSuppliers.CurrentRow.Cells["NOMBRE"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
