using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solucionSimplePractica071021
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos al formulario
            frmTest frm = new frmTest();
            frm.MdiParent = this; //definir formulario padre
            frm.Show(); //mostrar formulario
        }

        private void figuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFigura frm = new frmFigura();
            frm.MdiParent = this; //definir formulario padre.
            frm.Show(); //mostrar formulatio.

        }
    }
}
