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
            all();
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
            getToTextBox();
        }

        #region METHODS
        private void all()
        {
            dgvTipoCambio.DataSource = tipoCambio.all();
        }

        private void clearText()
        {
            txtFecha.Text = null;
            txtCompra.Text = null;
            txtVenta.Text = null;
            edit = false;
        }

        private void save()
        {
            string fecha = txtFecha.Text;
            double compra = Convert.ToDouble(txtCompra.Text);
            double venta = Convert.ToDouble(txtVenta.Text);

            if (edit)
            {
                int id = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["ID"].Value);
                if (tipoCambio.edit(id, fecha, compra, venta))
                {
                    MessageBox.Show("Tipo de Cambio Actulizado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    all();
                    clearText();
                }
                else
                    MessageBox.Show("Tipo de Cambio NO Actulizado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dataTableFecha = new DataTable();
                dataTableFecha = tipoCambio.show(fecha);

                if (dataTableFecha.Rows.Count <= 0)
                {
                    if (tipoCambio.save(fecha, compra, venta))
                    {
                        MessageBox.Show("Tipo de Cambio Guardado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        all();
                        clearText();
                    }
                    else
                        MessageBox.Show("Tipo de Cambio NO Guardado", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Tipo de Cambio con Fecha " + fecha + " ya existe\n Busquelo en la lista para modificarlo", "Tipo de Cambio .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void destroy()
        {
            int id = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["ID"].Value);
            if (tipoCambio.delete(id))
            {
                MessageBox.Show("Tipo de Cambio Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                all();
            }
            else
                MessageBox.Show("Tipo de Cambio NO Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void getToTextBox()
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
            clearText();
        }
    }
}
