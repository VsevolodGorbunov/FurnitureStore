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
    public partial class AddUpdateSupplier : FurnitureStoreDLL.FParent
    {
        string Id = "";
        int Status = 0;
        public AddUpdateSupplier(string id, int status)
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
                        Supplier std = SupplierQueries.GetSupplierByID(id);

                        txtId.Text = std.id.ToString();
                        txtName.Text = std.name;
                        txtDesc.Text = std.desc;

                        break;
                    }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                Supplier std = new Supplier();

                std.id = txtId.Text;
                std.name = txtName.Text;
                std.desc = txtDesc.Text;

                if (Status == 0)
                { // добавление
                    SupplierQueries.AddSupplier(std);
                }
                else
                { // обновление 
                    SupplierQueries.UpdateSupplier(std);
                }
            }
        }
    }
}
