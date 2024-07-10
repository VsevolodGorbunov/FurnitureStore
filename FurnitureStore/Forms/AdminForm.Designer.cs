
namespace FurnitureStore.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnAddFurniture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.DGEmployee = new System.Windows.Forms.DataGridView();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.DGSupplier = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployee)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.tabSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(699, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "Администратор";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabSupplier);
            this.tabControl1.Location = new System.Drawing.Point(20, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 611);
            this.tabControl1.TabIndex = 7;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnAddFurniture);
            this.tabEmployee.Controls.Add(this.groupBox1);
            this.tabEmployee.Controls.Add(this.DGEmployee);
            this.tabEmployee.Controls.Add(this.gbFilter);
            this.tabEmployee.Controls.Add(this.gbSearch);
            this.tabEmployee.Location = new System.Drawing.Point(4, 37);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(996, 570);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Сотрудники";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddFurniture
            // 
            this.btnAddFurniture.Location = new System.Drawing.Point(6, 149);
            this.btnAddFurniture.Name = "btnAddFurniture";
            this.btnAddFurniture.Size = new System.Drawing.Size(146, 39);
            this.btnAddFurniture.TabIndex = 20;
            this.btnAddFurniture.Text = "Добавить";
            this.btnAddFurniture.UseVisualStyleBackColor = true;
            this.btnAddFurniture.Click += new System.EventHandler(this.btnAddFurniture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDown);
            this.groupBox1.Controls.Add(this.rbUp);
            this.groupBox1.Controls.Add(this.cmbSort);
            this.groupBox1.Location = new System.Drawing.Point(465, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 200);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Location = new System.Drawing.Point(6, 139);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(135, 32);
            this.rbDown.TabIndex = 2;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "по убыванию";
            this.rbDown.UseVisualStyleBackColor = true;
            this.rbDown.CheckedChanged += new System.EventHandler(this.rbDown_CheckedChanged);
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(6, 90);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(166, 32);
            this.rbUp.TabIndex = 1;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "по возрастанию";
            this.rbUp.UseVisualStyleBackColor = true;
            this.rbUp.CheckedChanged += new System.EventHandler(this.rbUp_CheckedChanged);
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "Отсутствует",
            "Роль",
            "Зарплата"});
            this.cmbSort.Location = new System.Drawing.Point(6, 35);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(192, 36);
            this.cmbSort.TabIndex = 0;
            // 
            // DGEmployee
            // 
            this.DGEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEmployee.Location = new System.Drawing.Point(6, 221);
            this.DGEmployee.Name = "DGEmployee";
            this.DGEmployee.Size = new System.Drawing.Size(984, 328);
            this.DGEmployee.TabIndex = 19;
            this.DGEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEmployee_CellContentClick);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cmbFilter);
            this.gbFilter.Location = new System.Drawing.Point(239, 15);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(204, 100);
            this.gbFilter.TabIndex = 18;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтрация";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(6, 35);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(192, 36);
            this.cmbFilter.TabIndex = 0;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Location = new System.Drawing.Point(6, 15);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(204, 86);
            this.gbSearch.TabIndex = 17;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabSupplier
            // 
            this.tabSupplier.Controls.Add(this.btnAddSupplier);
            this.tabSupplier.Controls.Add(this.DGSupplier);
            this.tabSupplier.Location = new System.Drawing.Point(4, 37);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplier.Size = new System.Drawing.Size(996, 570);
            this.tabSupplier.TabIndex = 3;
            this.tabSupplier.Text = "Поставщики";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(6, 149);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(146, 39);
            this.btnAddSupplier.TabIndex = 21;
            this.btnAddSupplier.Text = "Добавить";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // DGSupplier
            // 
            this.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSupplier.Location = new System.Drawing.Point(6, 221);
            this.DGSupplier.Name = "DGSupplier";
            this.DGSupplier.ReadOnly = true;
            this.DGSupplier.Size = new System.Drawing.Size(984, 328);
            this.DGSupplier.TabIndex = 20;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 785);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "AdminForm";
            this.Text = "Магазин мебели";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGEmployee)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tabSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Button btnAddFurniture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.DataGridView DGEmployee;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView DGSupplier;
    }
}