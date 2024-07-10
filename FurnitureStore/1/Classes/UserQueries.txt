using FurnitureStore.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStore.Classes
{
    public class UserQueries
    {
        public static void AddUser(User std)
        {
            using (SqlConnection conn = new SqlConnection(Classes.Connection.strConn))
            {
                conn.Open();
                string sql = "INSERT INTO [iz].Покупатель ([ФИО],[Телефон],[Логин],[Пароль],[Роль],[Зарплата]) " +
              " VALUES (@fio, @phone, @login, @pswd, @role, @salary)";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("fio", std.fio);
                comm.Parameters.AddWithValue("phone", std.phone);
                comm.Parameters.AddWithValue("login", std.login);
                comm.Parameters.AddWithValue("pswd", std.pswd);
                comm.Parameters.AddWithValue("role", std.role);
                comm.Parameters.AddWithValue("salary", std.salary);

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
        public static void UpdateUser(User std)   //  обновление данных
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "UPDATE [iz].Покупатель " +
                    " SET [ФИО] = @fio, [Телефон] = @phone, [Логин] = @login, [Пароль] = @pswd, [Роль] = @role, [Зарплата] = @salary WHERE [Номер покупателя]= @id";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("id", std.id);
                comm.Parameters.AddWithValue("fio", std.fio);
                comm.Parameters.AddWithValue("phone", std.phone);
                comm.Parameters.AddWithValue("login", std.login);
                comm.Parameters.AddWithValue("pswd", std.pswd);
                comm.Parameters.AddWithValue("role", std.role);
                comm.Parameters.AddWithValue("salary", std.salary);

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
        public static bool DeleteUser(string id)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                string sql = "DELETE FROM [iz].Покупатель WHERE [Номер покупателя] = @id";

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
        public static User GetUserByID(string id)
        {
            User std = new User();
            string sql = "Select * from [iz].Покупатель where [Номер покупателя] = @id";
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("id", id);
                SqlDataReader rd = comm.ExecuteReader();

                rd.Read();
                std.id = rd["Номер покупателя"].ToString();
                std.fio = rd["ФИО"].ToString();
                std.phone = rd["Телефон"].ToString();
                std.login = rd["Логин"].ToString();
                std.pswd = rd["Пароль"].ToString();
                std.role = rd["Роль"].ToString();
                std.salary = rd["Зарплата"].ToString();
            }
            return std;
        }
        public static void Authorization(User std)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "[iz].[ХП_Авторизация]";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Логин", std.login);
                cmd.Parameters.AddWithValue("Пароль", std.pswd);
                cmd.Parameters.AddWithValue("Роль", std.role);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dr.Read(); string rez = "";
                    rez = Convert.ToString(dr["ErrMsg"]);
                    if (rez == "")
                    {
                        switch (std.role)
                        {
                            case "Покупатель":
                                //MessageBox.Show("Экран покупателя");
                                CustomerForm fcust = new CustomerForm();
                                fcust.ShowDialog();
                                break;
                            case "Администратор":
                                // MessageBox.Show("Экран администратора");
                                AdminForm fadmin = new AdminForm();
                                fadmin.ShowDialog();
                                break;
                            case "Продавец-консультант":
                                //  MessageBox.Show("Экран продавца-консультанта");
                                SellerForm fsell = new SellerForm();
                                fsell.ShowDialog();
                                break;
                        }
                    }
                    else
                        MessageBox.Show(rez);
                }
            }
        }
    }
}
