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
    public partial class AddOrderServiceForm : Form
    {
        public AddOrderServiceForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOrderServiceForm_Load(object sender, EventArgs e)
        {
            OrdersClass.GetCmbServicesList();
            ServiceCB.DataSource = OrdersClass.dtCmbServices;
            ServiceCB.DisplayMember = "Name";
            ServiceCB.ValueMember = "IdService";
            if (OrdersClass.dtCmbServices.Rows.Count == 0)
                ServiceCB.Enabled = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OrdersClass.AddOrderService(OrdersForm.idOrder, ServiceCB.SelectedValue.ToString(),"Не выполнено"))
            {
                MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersClass.GetOrderServices(OrdersForm.idOrder);
                OrdersClass.GetOrderList();
                this.Close();
            }
        }
    }
}
