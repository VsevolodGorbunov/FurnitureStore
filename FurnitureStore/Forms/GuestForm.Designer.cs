
namespace FurnitureStore.Forms
{
    partial class GuestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFurniture = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.DGFurniture = new System.Windows.Forms.DataGridView();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFurniture.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFurniture)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFurniture);
            this.tabControl1.Location = new System.Drawing.Point(20, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 611);
            this.tabControl1.TabIndex = 8;
            // 
            // tabFurniture
            // 
            this.tabFurniture.Controls.Add(this.groupBox1);
            this.tabFurniture.Controls.Add(this.DGFurniture);
            this.tabFurniture.Controls.Add(this.gbFilter);
            this.tabFurniture.Controls.Add(this.gbSearch);
            this.tabFurniture.Location = new System.Drawing.Point(4, 37);
            this.tabFurniture.Name = "tabFurniture";
            this.tabFurniture.Padding = new System.Windows.Forms.Padding(3);
            this.tabFurniture.Size = new System.Drawing.Size(996, 570);
            this.tabFurniture.TabIndex = 2;
            this.tabFurniture.Text = "Мебель";
            this.tabFurniture.UseVisualStyleBackColor = true;
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
            "Название",
            "Стоимость"});
            this.cmbSort.Location = new System.Drawing.Point(6, 35);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(192, 36);
            this.cmbSort.TabIndex = 0;
            // 
            // DGFurniture
            // 
            this.DGFurniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFurniture.Location = new System.Drawing.Point(6, 221);
            this.DGFurniture.Name = "DGFurniture";
            this.DGFurniture.Size = new System.Drawing.Size(984, 328);
            this.DGFurniture.TabIndex = 19;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(474, -131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продавец-консультант";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(882, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Гость";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "GuestForm";
            this.Text = "Магазин мебели";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabFurniture.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGFurniture)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFurniture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.DataGridView DGFurniture;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}