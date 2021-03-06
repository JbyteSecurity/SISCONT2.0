﻿using System;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class FrmProveedor : Form
    {
        private Proveedor proveedor = new Proveedor();
        private bool edit = false;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            All();
            dgvSuppliers.Columns["ID"].Visible = false;
            dgvSuppliers.Columns["NOMBRE"].Width = 250;
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
            if (edit)
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
            edit = false;
        }

        private void All()
        {
            dgvSuppliers.DataSource = proveedor.All();
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["ID"].Value);

            DialogResult dialogResult = MessageBox.Show("¿Realmente quieres eliminar este proveedor?", "Proveedor .::. Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes) {
                if (proveedor.Destroy(id))
                {
                    ClearTextBox();
                    All();
                }
                else
                    MessageBox.Show("Proveedor NO Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetToTextBox()
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                edit = true;
                txtRuc.Text = dgvSuppliers.CurrentRow.Cells["RUC"].Value.ToString();
                txtRazonSocial.Text = dgvSuppliers.CurrentRow.Cells["NOMBRE"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
