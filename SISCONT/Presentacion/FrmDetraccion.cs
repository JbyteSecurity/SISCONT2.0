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
    public partial class FrmDetraccion : Form
    {
        Detraccion detraccion = new Detraccion();
        private bool edit = false;
        public FrmDetraccion()
        {
            InitializeComponent();
        }

        private void FrmDetraccion_Load(object sender, EventArgs e)
        {
            Index();
        }

        private void Insert()
        {
            int codigo;
            double monto, porcentaje;

            codigo = Convert.ToInt32(txtCodigo.Text);
            monto = Convert.ToDouble(txtMonto.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            if (edit)
            {
                int id = Convert.ToInt32(dgvDetraccion.CurrentRow.Cells["id"].Value);
                if (detraccion.Update(id, codigo, monto, porcentaje))
                {
                    MessageBox.Show("Detraccion Editada", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    Index();
                }
                else
                    MessageBox.Show("Detracción no Editada", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (detraccion.Insert(codigo, monto, porcentaje))
                {
                    MessageBox.Show("Detracción Agregado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    Index();
                }
                else
                    MessageBox.Show("Detracción no Agregado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBox()
        {
            txtCodigo.Text = null;
            txtMonto.Text = null;
            txtPorcentaje.Text = null;
            this.ActiveControl = txtCodigo;
            edit = false;
        }

        private void Index()
        {
            dgvDetraccion.DataSource = detraccion.Index();
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvDetraccion.CurrentRow.Cells["id"].Value);
            if (detraccion.Destroy(id))
            {
                MessageBox.Show("Detracción eliminado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                Index();
            }
            else
                MessageBox.Show("Detracción no eliminado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GoToTextBox()
        {
            if (dgvDetraccion.SelectedRows.Count > 0)
            {
                edit = true;
                txtCodigo.Text = dgvDetraccion.CurrentRow.Cells["codigo"].Value.ToString();
                txtMonto.Text = dgvDetraccion.CurrentRow.Cells["monto"].Value.ToString();
                txtPorcentaje.Text = dgvDetraccion.CurrentRow.Cells["porcentaje"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor", "Detracción .::. Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Destroy();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GoToTextBox();
        }
    }
}
