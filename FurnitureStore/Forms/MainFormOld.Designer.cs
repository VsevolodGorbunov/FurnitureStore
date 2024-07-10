
namespace FurnitureStore
{
    partial class MainFormOld
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnToProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(189, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мебельный магазин";
            // 
            // btnToProfile
            // 
            this.btnToProfile.BackColor = System.Drawing.Color.White;
            this.btnToProfile.Location = new System.Drawing.Point(589, 13);
            this.btnToProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToProfile.Name = "btnToProfile";
            this.btnToProfile.Size = new System.Drawing.Size(162, 38);
            this.btnToProfile.TabIndex = 2;
            this.btnToProfile.Text = "Личный кабинет";
            this.btnToProfile.UseVisualStyleBackColor = false;
            this.btnToProfile.Click += new System.EventHandler(this.btnToProfile_Click);
            // 
            // MainFormOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FurnitureStore.Properties.Resources.Слой_1;
            this.ClientSize = new System.Drawing.Size(763, 499);
            this.Controls.Add(this.btnToProfile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "MainFormOld";
            this.Text = "Магазин мебели";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnToProfile, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToProfile;
    }
}

