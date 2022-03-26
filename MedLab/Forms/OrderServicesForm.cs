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
    public partial class OrderServicesForm : Form
    {
        public OrderServicesForm()
        {
            InitializeComponent();
        }

        private void OrderServicesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Услуги заказа №" + OrdersForm.idOrder;
            OrdersClass.GetOrderServices(OrdersForm.idOrder);
            ServicesDGV.DataSource = OrdersClass.dtOrderServices;
            

            if (MainForm.role == "laborant")
            {
                ServicesDGV.Columns[0].Visible = false;
                AddServiceBtn.Visible = true;
                DeleteBtn.Visible = true;
                label2.Visible = false;
                AnalizatorFilterCB.Visible = false;
                ResetAnalizFilterBtn.Visible = false;
                OrdersClass.dtOrderServices.DefaultView.RowFilter = null;
            }
            if (MainForm.role == "researcher")
            {
                OrdersClass.dtOrderServices.DefaultView.RowFilter = "status = '" + "Не выполнено" + "'";
                AddServiceBtn.Visible = false;
                DeleteBtn.Visible = false;
                label2.Visible = true;
                AnalizatorFilterCB.Visible = true;
                ResetAnalizFilterBtn.Visible = true;
                ServicesDGV.Columns[0].Visible = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            AddOrderServiceForm aosf = new AddOrderServiceForm();
            aosf.ShowDialog();
        }

        static public string idOrdService, name, idService, idOrder;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            idOrdService = ServicesDGV.CurrentRow.Cells[1].Value.ToString();
            idService = ServicesDGV.CurrentRow.Cells[2].Value.ToString();
            idOrder = ServicesDGV.CurrentRow.Cells[3].Value.ToString();
            //MessageBox.Show(idOrdService.ToString());
            if (OrdersClass.IsOrderServiceResearched(idOrdService))
            {
                MessageBox.Show("Нельзя удалить выполненную услугу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выбранную услугу?","Внимание",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (OrdersClass.DeleteOrderService(idOrdService, idService, idOrder))
                {
                    OrdersClass.GetOrderServices(OrdersForm.idOrder);
                    OrdersClass.GetOrderList();
                    MessageBox.Show("Запимсь успешно удалена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AnalizatorFilterCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrdersClass.dtOrderServices.DefaultView.RowFilter = "status = '" + "Не выполнено" + "' AND Analizator = '"+AnalizatorFilterCB.Text+"'";
        }

        private void ResetAnalizFilterBtn_Click(object sender, EventArgs e)
        {
            AnalizatorFilterCB.SelectedIndex = -1;
            OrdersClass.dtOrderServices.DefaultView.RowFilter = "status = '" + "Не выполнено" + "'";
        }

        private void ServicesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 0)
            {
                idOrdService = ServicesDGV.CurrentRow.Cells[1].Value.ToString();
                idService = ServicesDGV.CurrentRow.Cells[2].Value.ToString();
                //name = ServicesDGV.CurrentRow.Cells[2].Value.ToString();
                AnalizatorForm af = new AnalizatorForm();
                af.ShowDialog();
            }
        }
    }
}
