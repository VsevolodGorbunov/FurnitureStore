
namespace FurnitureStore.Forms
{
    partial class ProfileRegistration
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
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegFio = new System.Windows.Forms.TextBox();
            this.lbPswdNotMatch = new System.Windows.Forms.Label();
            this.pngPswdNotMatch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pngPswdNotMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(185, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регистрация";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(213, 491);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(218, 40);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(213, 348);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(218, 36);
            this.txtRegPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(208, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль:";
            // 
            // txtRegLogin
            // 
            this.txtRegLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRegLogin.Location = new System.Drawing.Point(213, 278);
            this.txtRegLogin.Name = "txtRegLogin";
            this.txtRegLogin.Size = new System.Drawing.Size(218, 26);
            this.txtRegLogin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(208, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин:";
            // 
            // txtRegPasswordConfirm
            // 
            this.txtRegPasswordConfirm.Location = new System.Drawing.Point(213, 419);
            this.txtRegPasswordConfirm.Name = "txtRegPasswordConfirm";
            this.txtRegPasswordConfirm.PasswordChar = '*';
            this.txtRegPasswordConfirm.Size = new System.Drawing.Size(218, 36);
            this.txtRegPasswordConfirm.TabIndex = 14;
            this.txtRegPasswordConfirm.TextChanged += new System.EventHandler(this.txtRegPasswordConfirm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(208, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Подтвердите пароль:";
            // 
            // txtRegPhone
            // 
            this.txtRegPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRegPhone.Location = new System.Drawing.Point(213, 218);
            this.txtRegPhone.Name = "txtRegPhone";
            this.txtRegPhone.Size = new System.Drawing.Size(218, 26);
            this.txtRegPhone.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(208, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(208, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "ФИО:";
            // 
            // txtRegFio
            // 
            this.txtRegFio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRegFio.Location = new System.Drawing.Point(213, 158);
            this.txtRegFio.Name = "txtRegFio";
            this.txtRegFio.Size = new System.Drawing.Size(218, 26);
            this.txtRegFio.TabIndex = 18;
            // 
            // lbPswdNotMatch
            // 
            this.lbPswdNotMatch.AutoSize = true;
            this.lbPswdNotMatch.BackColor = System.Drawing.Color.Transparent;
            this.lbPswdNotMatch.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPswdNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lbPswdNotMatch.Location = new System.Drawing.Point(233, 458);
            this.lbPswdNotMatch.Name = "lbPswdNotMatch";
            this.lbPswdNotMatch.Size = new System.Drawing.Size(162, 23);
            this.lbPswdNotMatch.TabIndex = 19;
            this.lbPswdNotMatch.Text = "Пароли не совпадают";
            this.lbPswdNotMatch.Visible = false;
            // 
            // pngPswdNotMatch
            // 
            this.pngPswdNotMatch.BackColor = System.Drawing.Color.Transparent;
            this.pngPswdNotMatch.Image = global::FurnitureStore.Properties.Resources.toppng_com_red_x_in_circle_x_ico_2000x2000;
            this.pngPswdNotMatch.Location = new System.Drawing.Point(213, 461);
            this.pngPswdNotMatch.Name = "pngPswdNotMatch";
            this.pngPswdNotMatch.Size = new System.Drawing.Size(21, 19);
            this.pngPswdNotMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pngPswdNotMatch.TabIndex = 20;
            this.pngPswdNotMatch.TabStop = false;
            this.pngPswdNotMatch.Visible = false;
            // 
            // ProfileRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 584);
            this.Controls.Add(this.pngPswdNotMatch);
            this.Controls.Add(this.lbPswdNotMatch);
            this.Controls.Add(this.txtRegFio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRegPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegPasswordConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProfileRegistration";
            this.Text = "Регистрация";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtRegLogin, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRegPassword, 0);
            this.Controls.SetChildIndex(this.btnReg, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtRegPasswordConfirm, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtRegPhone, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtRegFio, 0);
            this.Controls.SetChildIndex(this.lbPswdNotMatch, 0);
            this.Controls.SetChildIndex(this.pngPswdNotMatch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pngPswdNotMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegPasswordConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegFio;
        private System.Windows.Forms.Label lbPswdNotMatch;
        private System.Windows.Forms.PictureBox pngPswdNotMatch;
    }
}