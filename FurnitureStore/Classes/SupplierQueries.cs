using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStore.Classes
{
    public class SupplierQueries
    {
        public static void AddSupplier(Supplier std)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "INSERT INTO [iz].Поставщик ([Название поставщика],[Описание]) " +
              " VALUES (@name, @desc)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("name", std.name);
                comm.Parameters.AddWithValue("desc", std.desc);

                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        public static void UpdateSupplier(Supplier std)   //  обновление данных
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "UPDATE [iz].Поставщик " +
                    " SET [Название поставщика] = @name, [Описание] = @desc WHERE [Номер поставщика]= @id";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("name", std.name);
                comm.Parameters.AddWithValue("desc", std.desc);
                comm.Parameters.AddWithValue("id", std.id);

                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        public static bool DeleteSupplier(string id)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "DELETE FROM [iz].Поставщик WHERE [Номер поставщика] = @id";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", id);

                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public static Supplier GetSupplierByID(string id)
        {
            Supplier std = new Supplier();
            string sql = "Select * from [iz].Поставщик where [Номер поставщика] = @id";
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("id", id);
                SqlDataReader rd = comm.ExecuteReader();

                rd.Read();
                std.id = rd["Номер поставщика"].ToString();
                std.name = rd["Название поставщика"].ToString();
                std.desc = rd["Описание"].ToString();
            }
            return std;
        }
    }
}
