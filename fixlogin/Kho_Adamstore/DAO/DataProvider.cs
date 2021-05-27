using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kho_Adamstore.DAO
{
    class DataProvider
    {
        private static DataProvider instance;// tao doi tuong tu khoa la static, suy ra bat cu cai gi thong qua intance ddeula duy nhat


        private string connectionstr = @"Data Source=LAPTOP-5N2NGK55;Initial Catalog=KHO_ADAM;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

            private set { DataProvider instance = value; }
        } //dong goi du lieu

        public DataTable ExecuteQuery(string query, object[] parameter = null)//su dung oject de co the truyen n parameter
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }//du co  xay ra gi thi khi hoan thanh khoi lenh cung se dong connnect
            return data;//tra ve du lieu


        }



        public int ExecutenonQuery(string query)//su dung oject de co the truyen n parameter
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();//thuc hien truy van va tra ve gia tri// gia tri -1 la sai
                connection.Close();
            }//du co  xay ra gi thi khi hoan thanh khoi lenh cung se dong connnect
            return data;//tra ve du lieu


        }
    }
}
