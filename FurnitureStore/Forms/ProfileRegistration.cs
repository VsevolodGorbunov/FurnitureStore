using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FurnitureStore.Classes;
using System.Security.Cryptography;

namespace FurnitureStore.Forms
{
    public partial class ProfileRegistration : FurnitureStoreDLL.FParent
    {
        public ProfileRegistration()
        {
            InitializeComponent();
        }



        private void btnReg_Click(object sender, EventArgs e) // регистрация
        {
            string salt1 = "9io&"; string salt2 = "^tyG"; // посыпали солью
            if ((txtRegPassword.Text == txtRegPasswordConfirm.Text) && (txtRegFio.Text != "") && (txtRegPhone.Text != "") && (txtRegLogin.Text != "") && (txtRegPassword.Text != "") && (txtRegPasswordConfirm.Text != ""))
            {
                using (SqlConnection conn = new SqlConnection(Connection.strConn))
                {
                    User std = new User();
                    std.fio = txtRegFio.Text;
                    std.phone = txtRegPhone.Text;
                    std.login = txtRegLogin.Text;
                    std.pswd = salt1 + GetHash.Get_Hash(txtRegPassword.Text) + salt2;
                    std.role = "Покупатель";
                    std.salary = null;

                    UserQueries.AddUser(std);
                }
            }
        }

        private void txtRegPasswordConfirm_TextChanged(object sender, EventArgs e) // проверка совпадения пароля
        {
            if (txtRegPassword.Text != txtRegPasswordConfirm.Text)
            {
                lbPswdNotMatch.Visible = true;
                pngPswdNotMatch.Visible = true;
            }
            else
            {
                lbPswdNotMatch.Visible = false;
                pngPswdNotMatch.Visible = false;
            }
        }
    }
}
