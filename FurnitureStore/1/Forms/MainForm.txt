using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using FurnitureStore.Classes;
using FurnitureStoreDLL;


namespace FurnitureStore.Forms
{
    public partial class MainForm : FParent
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToReg_Click(object sender, EventArgs e)
        {
            ProfileRegistration fadd = new ProfileRegistration();
            fadd.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string salt1 = "9io&"; string salt2 = "^tyG"; // посыпали солью
            if ((txtLogLogin.Text == "") || (txtLogPassword.Text == "") || (cmbLogRole.Items[cmbLogRole.SelectedIndex].ToString() == ""))
            {
                MessageBox.Show("Задайте параметры входа");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Connection.strConn))
                {
                    User std = new User();
                    std.login = txtLogLogin.Text;
                    std.pswd = salt1 + GetHash.Get_Hash(txtLogPassword.Text) + salt2;
                    std.role = cmbLogRole.Items[cmbLogRole.SelectedIndex].ToString();

                    UserQueries.Authorization(std);
                }
            }
        }

        private void btnGuestLogin_Click(object sender, EventArgs e)
        {
            GuestForm fgu = new GuestForm();
            fgu.ShowDialog();
            this.Close();
        }
    }
}
