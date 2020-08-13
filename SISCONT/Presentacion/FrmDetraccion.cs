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

            dgvDetraccion.RowHeadersVisible = false;
            dgvDetraccion.Columns["id"].Visible = false;
            dgvDetraccion.Columns["Código"].Width = 50;
            dgvDetraccion.Columns["Definición"].Width = 150;
            dgvDetraccion.Columns["PorcentajeOriginal"].Visible = false;
            dgvDetraccion.Columns["Porcentaje"].Width = 60;
            dgvDetraccion.Columns["Monto"].Width = 50;
        }

        private void Insert()
        {
            int codigo, anexo;
            double monto, porcentaje;
            string definicion;

            codigo = Convert.ToInt32(txtCodigo.Text);
            monto = Convert.ToDouble(txtMonto.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);
            definicion = txtDefinicion.Text;
            anexo = Convert.ToInt32(txtAnexo.Text);

            if (edit)
            {
                int id = Convert.ToInt32(dgvDetraccion.CurrentRow.Cells["id"].Value);
                if (detraccion.Update(id, codigo, monto, porcentaje, definicion, anexo))
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
                if (detraccion.Insert(codigo, monto, porcentaje, definicion, anexo))
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
            txtAnexo.Text = null;
            txtDefinicion.Text = null;
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
            DialogResult dialogResultDetraccion = MessageBox.Show("¿Realmente quieres eliminar esta detracción?", "Detracción .::. Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResultDetraccion == DialogResult.Yes)
            {
                if (detraccion.Destroy(id))
                {
                    ClearTextBox();
                    Index();
                }
                else
                    MessageBox.Show("Detracción no eliminado", "Detracción .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoToTextBox()
        {
            if (dgvDetraccion.SelectedRows.Count > 0)
            {
                edit = true;
                txtCodigo.Text = dgvDetraccion.CurrentRow.Cells["Código"].Value.ToString();
                txtMonto.Text = dgvDetraccion.CurrentRow.Cells["Monto"].Value.ToString();
                txtPorcentaje.Text = dgvDetraccion.CurrentRow.Cells["PorcentajeOriginal"].Value.ToString();
                txtDefinicion.Text = dgvDetraccion.CurrentRow.Cells["Definición"].Value.ToString();
                txtAnexo.Text = dgvDetraccion.CurrentRow.Cells["Anexo"].Value.ToString();
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

        private void txtAnexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
