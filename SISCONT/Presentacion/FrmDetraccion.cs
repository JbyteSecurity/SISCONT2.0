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
            index();
        }

        private void save()
        {
            int codigo;
            double monto, porcentaje;

            codigo = Convert.ToInt32(txtCodigo.Text);
            monto = Convert.ToDouble(txtMonto.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            if (edit)
            {
                int id = Convert.ToInt32(dgvDetraccion.CurrentRow.Cells["id"].Value);
                if (detraccion.update(id, codigo, monto, porcentaje))
                {
                    MessageBox.Show("Detraccion Editada", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                    index();
                }
                else
                    MessageBox.Show("Detracción no Editada", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (detraccion.insert(codigo, monto, porcentaje))
                {
                    MessageBox.Show("Detracción Agregado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                    index();
                }
                else
                    MessageBox.Show("Detracción no Agregado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearTextBox()
        {
            txtCodigo.Text = null;
            txtMonto.Text = null;
            txtPorcentaje.Text = null;
            this.ActiveControl = txtCodigo;
            edit = false;
        }

        private void index()
        {
            dgvDetraccion.DataSource = detraccion.index();
        }

        private void destroy()
        {
            int id = Convert.ToInt32(dgvDetraccion.CurrentRow.Cells["id"].Value);
            if (detraccion.destroy(id))
            {
                MessageBox.Show("Detracción eliminado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
                index();
            }
            else
                MessageBox.Show("Detracción no eliminado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void goToTextBox()
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
            clearTextBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            destroy();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            goToTextBox();
        }
    }
}
