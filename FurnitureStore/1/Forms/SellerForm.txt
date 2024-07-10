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
    public partial class SellerForm : FurnitureStoreDLL.FParent
    {
        bool isFilter = false; //проверка фильтрации
        bool isSorted = false; //проверка сортировки
        string sortedType; //текущий тип сортировки (ASC, DESC) для поиска

        string strConn = Connection.strConn;
        public SellerForm()
        {
            InitializeComponent();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            DGFurniture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DGSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            cmbSort.SelectedItem = "Отсутствует";
            FillFilter();

            PopulateGrid();
            PopulateGridSupplier();
        }
        private void FillFilter()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                cmbFilter.Items.Clear();
                cmbFilter.Items.Add("Отсутствует");
                cmbFilter.SelectedItem = "Отсутствует";

                string sql = "SELECT DISTINCT [Категория] FROM [iz].Мебель";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandTimeout = 0;
                SqlDataReader rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    cmbFilter.Items.Add(rd[0].ToString());
                }
            }
        }
        private void PopulateGrid() // обновление DGFurniture 
        {
            string sql = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                DGFurniture.Columns.Clear();

                DataGridViewButtonColumn update = new DataGridViewButtonColumn
                {
                    Name = "UpdateButton",
                    Text = "Обновить",
                    HeaderText = "Обновить",
                    UseColumnTextForButtonValue = true
                };
                DGFurniture.Columns.Add(update);

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    Text = "Удалить",
                    HeaderText = "Удалить",
                    UseColumnTextForButtonValue = true
                };
                DGFurniture.Columns.Add(delete);

                conn.Open();

                if (isFilter && isSorted)
                {
                    sql = $"SELECT * FROM [iz].Мебель where [Категория] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                }
                else if (isFilter)
                {
                    sql = $"SELECT * FROM [iz].Мебель where [Категория] = '{cmbFilter.SelectedItem}'";
                }
                else if (isSorted)
                {
                    sql = $"SELECT * FROM [iz].Мебель ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                }
                else
                {
                    sql = "SELECT * FROM [iz].Мебель";
                }
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DGFurniture.DataSource = ds.Tables[0];
            }
        }
        private void rbUp_CheckedChanged(object sender, EventArgs e) // сортировка по возрастанию
        {
            if (cmbSort.SelectedItem.ToString() == "Отсутствует")
            {
                isSorted = false;
                PopulateGrid();
            }
            else
            {
                string sql = "";
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    if (isFilter)
                    {
                        sql = $"SELECT * FROM [iz].Мебель where [Категория] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' ASC";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Мебель ORDER BY '{cmbSort.SelectedItem}' ASC";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGFurniture.DataSource = ds.Tables[0];
                    isSorted = true;
                    sortedType = " ASC";
                }
            }
        }
        private void rbDown_CheckedChanged(object sender, EventArgs e) // сортировка по убыванию
        {
            if (cmbSort.SelectedItem.ToString() == "Отсутствует")
            {
                isSorted = false;
                PopulateGrid();
            }
            else
            {
                string sql = "";
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    if (isFilter)
                    {
                        sql = $"SELECT * FROM [iz].Мебель where [Категория] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' DESC";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Мебель ORDER BY '{cmbSort.SelectedItem}' DESC";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGFurniture.DataSource = ds.Tables[0];
                    isSorted = true;
                    sortedType = " DESC";
                }
            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)  // фильтрация
        {
            if (cmbFilter.SelectedItem.ToString() == "Отсутствует")
            {
                isFilter = false;
                PopulateGrid();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM [iz].Мебель where [Категория] = '{cmbFilter.SelectedItem}'";
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGFurniture.DataSource = ds.Tables[0];
                    isFilter = true;
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e) //поиск
        {
            if (txtSearch.Text == "")
            {
                PopulateGrid();
            }
            else
            {
                string sql = "";
                using (SqlConnection conn = new SqlConnection(Connection.strConn))
                {
                    conn.Open();
                    if (isFilter && isSorted)
                    {
                        sql = $"SELECT * FROM [iz].Мебель WHERE [Название] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' and [Категория] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                    }
                    else if (isFilter)
                    {
                        sql = $"SELECT * FROM [iz].Мебель WHERE [Название] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' and [Категория] = '{cmbFilter.SelectedItem}'";
                    }
                    else if (isSorted)
                    {
                        sql = $"SELECT * FROM [iz].Мебель WHERE [Название] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Мебель WHERE [Название] like '{'%'}' + '{txtSearch.Text}' + '{'%'}'";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGFurniture.DataSource = ds.Tables[0];
                }
            }
        }
        private void DGFurniture_CellContentClick(object sender, DataGridViewCellEventArgs e)     //Обновление и удаление строк в DataGridView
        {
            if (e.ColumnIndex == DGFurniture.Columns["UpdateButton"].Index && e.RowIndex >= 0)
            {
                string id = DGFurniture.CurrentRow.Cells[2].Value.ToString();
                AddUpdateFurniture add = new AddUpdateFurniture(id, 1);
                add.ShowDialog();
                PopulateGrid();
            }
            if (e.ColumnIndex == DGFurniture.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string id = DGFurniture.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (FurnitureQueries.DeleteFurniture(id))
                    {
                        PopulateGrid();
                    }
                }
            }
        }
        private void btnAddFurniture_Click(object sender, EventArgs e)
        {
            string id = DGFurniture.CurrentRow.Cells[2].Value.ToString();
            AddUpdateFurniture fadd = new AddUpdateFurniture(id, 0);
            fadd.ShowDialog();
            FillFilter();
            PopulateGrid();
        }

        ///////////////////////////////////////////////////////////////////////////////////// Поставщики /////////////////////////////////////////////////////////////////////////////////////

        private void PopulateGridSupplier() // обновление DGSupplier 
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                DGSupplier.Columns.Clear();

                DataGridViewButtonColumn update = new DataGridViewButtonColumn
                {
                    Name = "UpdateButton",
                    Text = "Обновить",
                    HeaderText = "Обновить",
                    UseColumnTextForButtonValue = true
                };
                DGSupplier.Columns.Add(update);

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    Text = "Удалить",
                    HeaderText = "Удалить",
                    UseColumnTextForButtonValue = true
                };
                DGSupplier.Columns.Add(delete);

                conn.Open();
                string sql = "SELECT * FROM [iz].Поставщик";
                //string sql = "SELECT [Номер поставщика], [Название поставщика], [Описание] FROM [iz].Поставщик";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DGSupplier.DataSource = ds.Tables[0];

                
            }
        }

        private void DGSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)     //Обновление и удаление строк в DataGridView
        {
            if (e.ColumnIndex == DGSupplier.Columns["UpdateButton"].Index && e.RowIndex >= 0)
            {
                string id = DGSupplier.CurrentRow.Cells[2].Value.ToString();
                AddUpdateSupplier add = new AddUpdateSupplier(id, 1);
                add.ShowDialog();
                PopulateGridSupplier();
            }
            if (e.ColumnIndex == DGSupplier.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string id = DGSupplier.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (SupplierQueries.DeleteSupplier(id))
                    {
                        PopulateGridSupplier();
                    }
                }
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string id = DGSupplier.CurrentRow.Cells[2].Value.ToString();
            AddUpdateSupplier fadd = new AddUpdateSupplier(id, 0);
            fadd.ShowDialog();
            PopulateGridSupplier();
        }
    }
}
