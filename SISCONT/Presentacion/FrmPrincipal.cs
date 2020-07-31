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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuItemProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.MdiParent = this;
            //frmProveedor.Dock = DockStyle.Fill;
            //frmProveedor.Text = "SISCONT - " + this.MdiChildren.Length.ToString();
            frmProveedor.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProgramaLibrosElectronicos frmProgramaLibrosElectronicos = new FrmProgramaLibrosElectronicos();
            frmProgramaLibrosElectronicos.MdiParent = this;
            frmProgramaLibrosElectronicos.Dock = DockStyle.Fill;
            ///frmProgramaLibrosElectronicos.Text = "SISCONT - " + this.MdiChildren;
            frmProgramaLibrosElectronicos.Show();
        }
        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoCambio frmTipoCambio = new FrmTipoCambio();
            frmTipoCambio.MdiParent = this;
            frmTipoCambio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void detracciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetraccion frmDetraccion = new FrmDetraccion();
            frmDetraccion.Show();
        }
    }
}
