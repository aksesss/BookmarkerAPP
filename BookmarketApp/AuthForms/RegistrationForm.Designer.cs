namespace BookmarketApp
{
    partial class RegistrationForm
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
            this.login_txtBox = new System.Windows.Forms.TextBox();
            this.lname_txtBtn = new System.Windows.Forms.TextBox();
            this.fnane_txtBtn = new System.Windows.Forms.TextBox();
            this.email_txtBtn = new System.Windows.Forms.TextBox();
            this.password_txtBtn = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.fnane_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registrate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_txtBox
            // 
            this.login_txtBox.Location = new System.Drawing.Point(141, 27);
            this.login_txtBox.Name = "login_txtBox";
            this.login_txtBox.Size = new System.Drawing.Size(168, 22);
            this.login_txtBox.TabIndex = 0;
            // 
            // lname_txtBtn
            // 
            this.lname_txtBtn.Location = new System.Drawing.Point(141, 66);
            this.lname_txtBtn.Name = "lname_txtBtn";
            this.lname_txtBtn.Size = new System.Drawing.Size(168, 22);
            this.lname_txtBtn.TabIndex = 1;
            // 
            // fnane_txtBtn
            // 
            this.fnane_txtBtn.Location = new System.Drawing.Point(141, 108);
            this.fnane_txtBtn.Name = "fnane_txtBtn";
            this.fnane_txtBtn.Size = new System.Drawing.Size(168, 22);
            this.fnane_txtBtn.TabIndex = 2;
            // 
            // email_txtBtn
            // 
            this.email_txtBtn.Location = new System.Drawing.Point(141, 149);
            this.email_txtBtn.Name = "email_txtBtn";
            this.email_txtBtn.Size = new System.Drawing.Size(168, 22);
            this.email_txtBtn.TabIndex = 3;
            // 
            // password_txtBtn
            // 
            this.password_txtBtn.Location = new System.Drawing.Point(141, 187);
            this.password_txtBtn.Name = "password_txtBtn";
            this.password_txtBtn.PasswordChar = '*';
            this.password_txtBtn.Size = new System.Drawing.Size(168, 22);
            this.password_txtBtn.TabIndex = 4;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(28, 31);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(47, 17);
            this.login_lbl.TabIndex = 5;
            this.login_lbl.Text = "Логин";
            // 
            // fnane_lbl
            // 
            this.fnane_lbl.AutoSize = true;
            this.fnane_lbl.Location = new System.Drawing.Point(31, 66);
            this.fnane_lbl.Name = "fnane_lbl";
            this.fnane_lbl.Size = new System.Drawing.Size(70, 17);
            this.fnane_lbl.TabIndex = 6;
            this.fnane_lbl.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "пароль";
            // 
            // registrate_btn
            // 
            this.registrate_btn.Location = new System.Drawing.Point(141, 233);
            this.registrate_btn.Name = "registrate_btn";
            this.registrate_btn.Size = new System.Drawing.Size(168, 23);
            this.registrate_btn.TabIndex = 10;
            this.registrate_btn.Text = "Зарегестрироваться";
            this.registrate_btn.UseVisualStyleBackColor = true;
            this.registrate_btn.Click += new System.EventHandler(this.registrate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrate_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fnane_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_txtBtn);
            this.Controls.Add(this.email_txtBtn);
            this.Controls.Add(this.fnane_txtBtn);
            this.Controls.Add(this.lname_txtBtn);
            this.Controls.Add(this.login_txtBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_txtBox;
        private System.Windows.Forms.TextBox lname_txtBtn;
        private System.Windows.Forms.TextBox fnane_txtBtn;
        private System.Windows.Forms.TextBox email_txtBtn;
        private System.Windows.Forms.TextBox password_txtBtn;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label fnane_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registrate_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}