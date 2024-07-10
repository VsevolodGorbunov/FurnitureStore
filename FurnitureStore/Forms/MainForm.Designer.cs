
namespace FurnitureStore.Forms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogLogin = new System.Windows.Forms.TextBox();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnToReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLogRole = new System.Windows.Forms.ComboBox();
            this.btnGuestLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(135, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мебельный магазин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(208, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // txtLogLogin
            // 
            this.txtLogLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogLogin.Location = new System.Drawing.Point(213, 154);
            this.txtLogLogin.Name = "txtLogLogin";
            this.txtLogLogin.Size = new System.Drawing.Size(218, 26);
            this.txtLogLogin.TabIndex = 4;
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLogPassword.Location = new System.Drawing.Point(213, 224);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '*';
            this.txtLogPassword.Size = new System.Drawing.Size(218, 26);
            this.txtLogPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(208, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(213, 358);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 40);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Авторизироваться";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnToReg
            // 
            this.btnToReg.BackColor = System.Drawing.Color.White;
            this.btnToReg.Location = new System.Drawing.Point(213, 510);
            this.btnToReg.Name = "btnToReg";
            this.btnToReg.Size = new System.Drawing.Size(218, 40);
            this.btnToReg.TabIndex = 8;
            this.btnToReg.Text = "Зарегистрироваться";
            this.btnToReg.UseVisualStyleBackColor = false;
            this.btnToReg.Click += new System.EventHandler(this.btnToReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(250, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Нет аккаунта?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(208, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Роль:";
            // 
            // cmbLogRole
            // 
            this.cmbLogRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogRole.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbLogRole.FormattingEnabled = true;
            this.cmbLogRole.Items.AddRange(new object[] {
            "Покупатель",
            "Администратор",
            "Продавец-консультант"});
            this.cmbLogRole.Location = new System.Drawing.Point(213, 295);
            this.cmbLogRole.Name = "cmbLogRole";
            this.cmbLogRole.Size = new System.Drawing.Size(218, 27);
            this.cmbLogRole.TabIndex = 11;
            // 
            // btnGuestLogin
            // 
            this.btnGuestLogin.BackColor = System.Drawing.Color.White;
            this.btnGuestLogin.Location = new System.Drawing.Point(213, 420);
            this.btnGuestLogin.Name = "btnGuestLogin";
            this.btnGuestLogin.Size = new System.Drawing.Size(218, 40);
            this.btnGuestLogin.TabIndex = 12;
            this.btnGuestLogin.Text = "Войти как гость";
            this.btnGuestLogin.UseVisualStyleBackColor = false;
            this.btnGuestLogin.Click += new System.EventHandler(this.btnGuestLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 584);
            this.Controls.Add(this.btnGuestLogin);
            this.Controls.Add(this.cmbLogRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnToReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Магазин мебели";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtLogLogin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLogPassword, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btnToReg, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbLogRole, 0);
            this.Controls.SetChildIndex(this.btnGuestLogin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogLogin;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnToReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLogRole;
        private System.Windows.Forms.Button btnGuestLogin;
    }
}