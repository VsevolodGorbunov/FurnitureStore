using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureStore.Classes;

namespace FurnitureStore.Forms
{
    public partial class CustomerForm : FurnitureStoreDLL.FParent
    {
        bool isFilter = false; //проверка фильтрации
        bool isSorted = false; //проверка сортировки
        string sortedType; //текущий тип сортировки (ASC, DESC) для поиска

        string strConn = Connection.strConn;
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn)) // фильтрация
            {
                conn.Open();
                cmbFilter.Items.Clear();
                cmbFilter.Items.Add("Отсутствует");
                cmbFilter.SelectedItem = "Отсутствует";

                cmbSort.SelectedItem = "Отсутствует";

                string sql = "SELECT DISTINCT [Категория] FROM [iz].Мебель";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandTimeout = 0;
                SqlDataReader rd = comm.ExecuteReader();

                while (rd.Read())
                {
                    cmbFilter.Items.Add(rd[0].ToString());
                }
            }
            
            PopulateGrid();
        }
        private void PopulateGrid() // обновление DGFurniture 
        {
            string sql = "";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                DGFurniture.Columns.Clear();

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
    }
}
