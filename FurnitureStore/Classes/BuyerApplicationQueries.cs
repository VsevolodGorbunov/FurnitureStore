using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.Classes
{
    public class BuyerApplicationQueries
    {
        //public static void AddAppl(BuyerApplication std)
        //{
        //    using (SqlConnection conn = new SqlConnection(Connection.strConn))
        //    {
        //        conn.Open();
        //        string sql = "INSERT INTO [iz].Заявка ([Логин],[Пароль],[Роль]) " +
        //      " VALUES (@fio, @phone, @login, @pswd, @role)";

        //        SqlCommand comm = new SqlCommand(sql, conn);
        //        comm.Parameters.AddWithValue("fio", std.fio);
        //        comm.Parameters.AddWithValue("phone", std.phone);
        //        comm.Parameters.AddWithValue("login", std.login);
        //        comm.Parameters.AddWithValue("pswd", std.pswd);
        //        comm.Parameters.AddWithValue("role", std.role);

        //        try
        //        {
        //            comm.ExecuteNonQuery();
        //            MessageBox.Show("Вы успешно зарегистрировались!");
        //            Application.OpenForms["ProfileRegistration"].Close();
        //        }
        //        catch (Exception er)
        //        {
        //            MessageBox.Show(er.Message);
        //        }
        //    }
        //}
    }
}
