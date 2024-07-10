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
    public partial class AddUpdateFurniture : FurnitureStoreDLL.FParent
    {
        string Id = "";
        int Status = 0;
        public AddUpdateFurniture(string id, int status)
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
                        txtArticle.Text = "";
                        break;
                    }
                case 1:
                    {// обновление 
                        Furniture std = FurnitureQueries.GetFurnitureByID(id);

                        txtArticle.Text = std.article.ToString();
                        txtCtgr.Text = std.ctgr;
                        txtName.Text = std.name;
                        txtSize.Text = std.size;
                        txtColor.Text = std.color;
                        txtPrice.Text = std.price.ToString();
                        txtLeft.Text = std.left.ToString();

                        break;
                    }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connection.strConn))
            {
                Furniture std = new Furniture();

                std.article = txtArticle.Text;
                std.ctgr = txtCtgr.Text;
                std.name = txtName.Text;
                std.size = txtSize.Text;
                std.color = txtColor.Text;
                std.price = txtPrice.Text;
                std.left = txtLeft.Text;

                if (Status == 0)
                { // добавление
                    FurnitureQueries.AddFurniture(std);
                }
                else
                { // обновление 
                    FurnitureQueries.UpdateFurniture(std);
                }
            }
        }
    }
}
