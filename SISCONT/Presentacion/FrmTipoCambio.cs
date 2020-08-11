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
    public partial class FrmTipoCambio : Form
    {
        TipoCambio tipoCambio = new TipoCambio();
        bool edit = false;
        public FrmTipoCambio()
        {
            InitializeComponent();
        }

        private void FrmTipoCambio_Load(object sender, EventArgs e)
        {
            All();
            txtFecha.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
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
            GetToTextBox();
        }

        #region METHODS
        private void All()
        {
            dgvTipoCambio.DataSource = tipoCambio.All();
        }

        private void ClearText()
        {
            txtFecha.Text = null;
            txtCompra.Text = null;
            txtVenta.Text = null;
            edit = false;
        }

        private void Insert()
        {
            string fecha = txtFecha.Text;
            double compra = Convert.ToDouble(txtCompra.Text);
            double venta = Convert.ToDouble(txtVenta.Text);

            if (edit)
            {
                int id = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["ID"].Value);
                if (tipoCambio.Update(id, fecha, compra, venta))
                {
                    MessageBox.Show("Tipo de Cambio Actulizado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    All();
                    ClearText();
                }
                else
                    MessageBox.Show("Tipo de Cambio NO Actulizado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dataTableFecha = new DataTable();
                dataTableFecha = tipoCambio.Show(fecha);

                if (dataTableFecha.Rows.Count <= 0)
                {
                    if (tipoCambio.Insert(fecha, compra, venta))
                    {
                        MessageBox.Show("Tipo de Cambio Guardado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        All();
                        ClearText();
                    }
                    else
                        MessageBox.Show("Tipo de Cambio NO Guardado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Tipo de Cambio con Fecha " + fecha + " ya existe\n Busquelo en la lista para modificarlo", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Destroy()
        {
            int id = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["ID"].Value);
            if (tipoCambio.Destroy(id))
            {
                MessageBox.Show("Tipo de Cambio Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                All();
            }
            else
                MessageBox.Show("Tipo de Cambio NO Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GetToTextBox()
        {
            if (dgvTipoCambio.SelectedRows.Count > 0)
            {
                edit = true;
                txtFecha.Text = dgvTipoCambio.CurrentRow.Cells["Fecha"].Value.ToString();
                txtCompra.Text = dgvTipoCambio.CurrentRow.Cells["Compra"].Value.ToString();
                txtVenta.Text = dgvTipoCambio.CurrentRow.Cells["Venta"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
