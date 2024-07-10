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
    public partial class AdminForm : FurnitureStoreDLL.FParent
    {
        bool isFilter = false; //проверка фильтрации
        bool isSorted = false; //проверка сортировки
        string sortedType; //текущий тип сортировки (ASC, DESC) для поиска

        string strConn = Connection.strConn;
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            DGEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            cmbSort.SelectedItem = "Отсутствует";

            FillFilter();
            PopulateGrid();
        }
        private void FillFilter() // наполнение комбобокса фильтрации
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                cmbFilter.Items.Clear();
                cmbFilter.Items.Add("Отсутствует");
                cmbFilter.SelectedItem = "Отсутствует";

                string sql = "SELECT DISTINCT [Роль] FROM [iz].Покупатель WHERE [Роль] != 'Покупатель'";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandTimeout = 0;
                SqlDataReader rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    cmbFilter.Items.Add(rd[0].ToString());
                }
            }
        }
        private void PopulateGrid() // обновление DGEmployee 
        {
            string sql = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                DGEmployee.Columns.Clear();

                DataGridViewButtonColumn update = new DataGridViewButtonColumn
                {
                    Name = "UpdateButton",
                    Text = "Обновить",
                    HeaderText = "Обновить",
                    UseColumnTextForButtonValue = true
                };
                DGEmployee.Columns.Add(update);

                DataGridViewButtonColumn delete = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    Text = "Удалить",
                    HeaderText = "Удалить",
                    UseColumnTextForButtonValue = true
                };
                DGEmployee.Columns.Add(delete);

                conn.Open();

                if (isFilter && isSorted)
                {
                    sql = $"SELECT * FROM [iz].Покупатель where [Роль] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                }
                else if (isFilter)
                {
                    sql = $"SELECT * FROM [iz].Покупатель where [Роль] = '{cmbFilter.SelectedItem}'";
                }
                else if (isSorted)
                {
                    sql = $"SELECT * FROM [iz].Покупатель where [Роль] = 'Администратор' or [Роль] = 'Продавец-консультант' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                }
                else
                {
                    sql = "SELECT * FROM [iz].Покупатель where [Роль] = 'Администратор' or [Роль] = 'Продавец-консультант'";
                }
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DGEmployee.DataSource = ds.Tables[0];
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
                        sql = $"SELECT * FROM [iz].Покупатель where [Роль] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' ASC";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Покупатель where [Роль] = 'Администратор' or [Роль] = 'Продавец-консультант' ORDER BY '{cmbSort.SelectedItem}' ASC";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGEmployee.DataSource = ds.Tables[0];
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
                        sql = $"SELECT * FROM [iz].Покупатель where [Роль] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' DESC";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Покупатель where [Роль] = 'Администратор' or [Роль] = 'Продавец-консультант' ORDER BY '{cmbSort.SelectedItem}' DESC";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGEmployee.DataSource = ds.Tables[0];
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
                    string sql = $"SELECT * FROM [iz].Покупатель where [Роль] = '{cmbFilter.SelectedItem}'";
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGEmployee.DataSource = ds.Tables[0];
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
                        sql = $"SELECT * FROM [iz].Покупатель WHERE [ФИО] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' and [Роль] = '{cmbFilter.SelectedItem}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                    }
                    else if (isFilter)
                    {
                        sql = $"SELECT * FROM [iz].Покупатель WHERE [ФИО] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' and [Роль] = '{cmbFilter.SelectedItem}'";
                    }
                    else if (isSorted)
                    {
                        sql = $"SELECT * FROM [iz].Покупатель WHERE [ФИО] like '{'%'}' + '{txtSearch.Text}' + '{'%'}' ORDER BY '{cmbSort.SelectedItem}' {sortedType}";
                    }
                    else
                    {
                        sql = $"SELECT * FROM [iz].Покупатель WHERE [ФИО] like '{'%'}' + '{txtSearch.Text}' + '{'%'}'";
                    }
                    SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DGEmployee.DataSource = ds.Tables[0];
                }
            }
        }
        private void DGEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)     //Обновление и удаление строк в DGEmployee
        {
            if (e.ColumnIndex == DGEmployee.Columns["UpdateButton"].Index && e.RowIndex >= 0)
            {
                string id = DGEmployee.CurrentRow.Cells[2].Value.ToString();
                AddUpdateEmployee add = new AddUpdateEmployee(id, 1);
                add.ShowDialog();
                PopulateGrid();
            }
            if (e.ColumnIndex == DGEmployee.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string id = DGEmployee.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (UserQueries.DeleteUser(id))
                    {
                        PopulateGrid();
                    }
                }
            }
        }
        private void btnAddFurniture_Click(object sender, EventArgs e) // добавление строк в DGEmployee
        {
            string id = DGEmployee.CurrentRow.Cells[2].Value.ToString();
            AddUpdateEmployee fadd = new AddUpdateEmployee(id, 0);
            fadd.ShowDialog();
            FillFilter();
            PopulateGrid();
        }
    }
}
