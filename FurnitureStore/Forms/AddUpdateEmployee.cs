using FurnitureStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStore.Forms
{
    public partial class AddUpdateEmployee : FurnitureStoreDLL.FParent
    {
        string Id = "";
        int Status = 0;
        public AddUpdateEmployee(string id, int status)
        {
            // status = 0 - открытие формы в режиме добавления
            // status = 1 - открытие формы в режиме обновления   
            // number - номер объекта, с которым работает форма

            Id = id;
            Status = status;

            InitializeComponent();

            switch (status)
            {
                case 0:
                    {// добавление
                        txtId.Text = "";
                        break;
                    }
                case 1:
                    {// обновление 
                        User std = UserQueries.GetUserByID(id);

                        txtId.Text = std.id.ToString();
                        txtFio.Text = std.fio;
                        txtPhone.Text = std.phone;
                        txtLogin.Text = std.login;
                        txtPswd.Text = std.pswd;
                        cmbRole.SelectedItem = std.role;
                        txtSalary.Text = std.salary.ToString();

                        break;
                    }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string salt1 = "9io&"; string salt2 = "^tyG"; // посыпали солью
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                User std = new User();

                std.id = txtId.Text;
                std.fio = txtFio.Text;
                std.phone = txtPhone.Text;
                std.login = txtLogin.Text;
                std.pswd = salt1 + GetHash.Get_Hash(txtPswd.Text) + salt2;
                std.role = cmbRole.Items[cmbRole.SelectedIndex].ToString();
                std.salary = txtSalary.Text;

                if (Status == 0)
                { // добавление
                    UserQueries.AddUser(std);
                }
                else
                { // обновление 
                    UserQueries.UpdateUser(std);
                }
            }
        }
    }
}
