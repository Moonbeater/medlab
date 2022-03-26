using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedLabAnalizatorDLL
{
    public class Analizator
    {
        static public string ResultAnalizator(string idService, string analizator)
        {
            DBConnection.Connect();

            DBConnection.mycommand.CommandText = @"SELECT analizator
            FROM services
            WHERE IdService = '" + idService + "'";
            object result = DBConnection.mycommand.ExecuteScalar();

            if (result.ToString() != analizator)
            {
                return "Не верно выбран анализатор";
            }

            Random rnd = new Random();

            int res = rnd.Next(0, 100);

            if (res > -1 && res < 21)
            {
                return "Сбой исследования";
            }

            if (res > 20 && res < 41)
            {
                return "Плохое качество биоматериала";
            }

            return res.ToString();
        }
    }
}
