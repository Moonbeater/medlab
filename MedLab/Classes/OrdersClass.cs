using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MedLabAnalizatorDLL;

namespace MedLab.Classes
{
    class OrdersClass
    {
        static public DataTable dtOrders = new DataTable();

        /// <summary>
        /// Получение списка заказов
        /// </summary>
        static public void GetOrderList()
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT IdOrder, CodeBio, Date, FIO, Price
                FROM Orders, Patients
                WHERE orders.idPatient = patients.IdPatient";
                dtOrders.Clear();
                DBConnection.msDataAdapter.Fill(dtOrders);
            }
            catch
            {
                MessageBox.Show("Ошибка при пполучении списка заказов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление нового заказа
        /// </summary>
        /// <param name="codeBio"></param>
        /// <param name="date"></param>
        /// <param name="idPatient"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        static public bool AddOrder(string codeBio, string date, string idPatient, string price)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"INSERT INTO Orders (CodeBio, Date, IdPatient, Price)
                VALUES ('" + codeBio + "','" + date + "','" + idPatient + "','" + price + "')";
                if (DBConnection.mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении заказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        static public DataTable dtOrderServices = new DataTable();

        /// <summary>
        /// Получение списка услуг в заказе
        /// </summary>
        /// <param name="idOrder"></param>
        static public void GetOrderServices(string idOrder)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT IdOrderService, orderservices.IdService, orderservices.IdOrder, Name, services.Price, Analizator, Result, Status
                FROM orders, orderservices, services
                WHERE orders.IdOrder = orderservices.IdOrder AND services.IdService = orderservices.IdService AND orderservices.IdOrder = '" + idOrder + "'";
                dtOrderServices.Clear();
                DBConnection.msDataAdapter.Fill(dtOrderServices);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении списка услуг в заказе", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Добавление услуги в заказ
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="idService"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        static public bool AddOrderService(string idOrder, string idService, string status)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT IdOrderService
                FROM orderservices
                WHERE IdOrder = '" + idOrder + "' AND IdService = '" + idService + "'";
                object result = DBConnection.mycommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("В данном заказе уже есть такая услуга", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                DBConnection.mycommand.CommandText = @"SELECT Price
                FROM Services
                WHERE IdService = '" + idService + "'";
                result = DBConnection.mycommand.ExecuteScalar();


                DBConnection.mycommand.CommandText = @"UPDATE orders
                SET price = price + '" + result.ToString().Replace(',','.') + "'" +
                "WHERE IdOrder = '" + idOrder + "'";
                DBConnection.mycommand.ExecuteNonQuery();

                DBConnection.mycommand.CommandText = @"INSERT INTO orderservices (IdOrder, IdService, Status)
                VALUES ('" + idOrder + "','" + idService + "','" + status + "')";
                if (DBConnection.mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении услуги в заказ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Проведение анализа в услуге
        /// </summary>
        /// <param name="idOrderService"></param>
        /// <param name="result"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        static public bool ResearchService(string idOrderService, string result, string status)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"UPDATE orderservices
                SET Result = '" + result + "', Status = '" + status + "'" +
                "WHERE IdOrderService = '" + idOrderService + "'";
                if (DBConnection.mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Ошибка при проведении анализа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Проверка, проанализирована ли услуга
        /// </summary>
        /// <param name="idOrderService"></param>
        /// <returns></returns>
        static public bool IsOrderServiceResearched(string idOrderService)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT status
                FROM orderservices
                WHERE IdOrderService = '" + idOrderService + "'";
                object result = DBConnection.mycommand.ExecuteScalar();
                //MessageBox.Show(result.ToString());
                if (result.ToString() == "Выполнено")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при проведении анализа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }

        /// <summary>
        /// Удаление услуги из заказа
        /// </summary>
        /// <param name="idOrderService"></param>
        /// <returns></returns>
        static public bool DeleteOrderService(string idOrderService, string idService, string idOrder)
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT Price
                FROM Services
                WHERE IdService = '" + idService + "'";
                object result = DBConnection.mycommand.ExecuteScalar();


                DBConnection.mycommand.CommandText = @"UPDATE orders
                SET price = price - '" + result.ToString().Replace(',', '.') + "'" +
                "WHERE IdOrder = '" + idOrder + "'";
                DBConnection.mycommand.ExecuteNonQuery();

                DBConnection.mycommand.CommandText = @"DELETE FROM orderservices
                WHERE IdOrderService = '" + idOrderService + "'";
                if (DBConnection.mycommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении услуги", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        static public DataTable dtCmbServices = new DataTable();

        /// <summary>
        /// Получение списка услуг для комбобокса
        /// </summary>
        static public void GetCmbServicesList()
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT IdService, Name
                FROM services
                ORDER BY (Name) ASC";
                dtCmbServices.Clear();
                DBConnection.msDataAdapter.Fill(dtCmbServices);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении списка услуг", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public DataTable dtCmbPatients = new DataTable();

        /// <summary>
        /// Получение списка пациентов для комбобокса
        /// </summary>
        static public void GetCmbPatientsList()
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT IdPatient, concat(FIO,' | ',Spassport,' ',Npassport) AS 'Fname'
                FROM patients";
                dtCmbPatients.Clear();
                DBConnection.msDataAdapter.Fill(dtCmbPatients);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении списка пациентов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Получение максимального значения номера заказа для формирования кода пробирки
        /// </summary>
        /// <returns></returns>
        static public int GetMaxOrderNumber()
        {
            try
            {
                DBConnection.mycommand.CommandText = @"SELECT count(*)
                FROM orders";
                object result = DBConnection.mycommand.ExecuteScalar();
                if (result.ToString() == "0")
                {
                    return 1;
                }

                DBConnection.mycommand.CommandText = @"SELECT MAX(IdOrder)
                FROM orders";
                result = DBConnection.mycommand.ExecuteScalar();
                return Convert.ToInt32(result)+1;
            }
            catch
            {
                MessageBox.Show("Ошибка при получении списка заказов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }
    }
}
