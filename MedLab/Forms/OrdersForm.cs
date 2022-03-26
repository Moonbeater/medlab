using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedLab.Classes;

namespace MedLab.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            OrdersClass.GetOrderList();
            OrdersDGV.DataSource = OrdersClass.dtOrders;
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrderForm aof = new AddOrderForm();
            aof.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
            this.Close();
        }

        static public string idOrder;

        private void OrderServicesBtn_Click(object sender, EventArgs e)
        {
            idOrder = OrdersDGV.CurrentRow.Cells[0].Value.ToString();
            OrderServicesForm osf = new OrderServicesForm();
            osf.ShowDialog();
        }
    }
}
