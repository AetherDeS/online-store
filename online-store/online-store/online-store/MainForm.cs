using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ManageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm Form = new OrdersForm();
            Form.Show();
        }

        private void ManageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm Form = new CustomersForm();
            Form.Show();
        }

        private void ManageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm Form = new ProductsForm();
            Form.Show();
        }

        private void toolStripExport_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            dm.ExportAllData();
        }
        private void toolStripImport_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();
            dm.ImportAllData();
        }
    }
}
