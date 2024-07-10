using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStore.Classes
{
    public class FurnitureQueries
    {
        public static void AddFurniture(Furniture std)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "INSERT INTO [iz].Мебель ([Категория],[Название],[Размер],[Цвет],[Стоимость],[Остаток на складе]) " +
              " VALUES (@ctgr, @name, @size, @color, @price, @left)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("ctgr", std.ctgr);
                comm.Parameters.AddWithValue("name", std.name);
                comm.Parameters.AddWithValue("size", std.size);
                comm.Parameters.AddWithValue("color", std.color);
                comm.Parameters.AddWithValue("price", std.price);
                comm.Parameters.AddWithValue("left", std.left);

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

        public static void UpdateFurniture(Furniture std)   //  обновление данных
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "UPDATE [iz].Мебель " +
                    " SET [Категория] = @ctgr, [Название] = @name, [Размер] = @size, [Цвет] = @color, [Стоимость] = @price, [Остаток на складе] = @left WHERE [Артикул]= @article";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("article", std.article);
                comm.Parameters.AddWithValue("ctgr", std.ctgr);
                comm.Parameters.AddWithValue("name", std.name);
                comm.Parameters.AddWithValue("size", std.size);
                comm.Parameters.AddWithValue("color", std.color);
                comm.Parameters.AddWithValue("price", std.price);
                comm.Parameters.AddWithValue("left", std.left);

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

        public static bool DeleteFurniture(string id)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "DELETE FROM [iz].Мебель WHERE [Артикул] = @id";

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
        public static Furniture GetFurnitureByID(string id)
        {
            Furniture std = new Furniture();
            string sql = "Select * from [iz].Мебель where [Артикул] = @id";
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("id", id);
                SqlDataReader rd = comm.ExecuteReader();

                rd.Read();
                std.article = rd["Артикул"].ToString();
                std.ctgr = rd["Категория"].ToString();
                std.name = rd["Название"].ToString();
                std.size = rd["Размер"].ToString();
                std.color = rd["Цвет"].ToString();
                std.price = rd["Стоимость"].ToString();
                std.left = rd["Остаток на складе"].ToString();
            }
            return std;
        }
    }
}
