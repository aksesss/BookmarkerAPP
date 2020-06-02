namespace BookmarketApp
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
            this.login_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.registrationFormShow_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.test_hash = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_txtBox
            // 
            this.login_txtBox.Location = new System.Drawing.Point(91, 30);
            this.login_txtBox.Name = "login_txtBox";
            this.login_txtBox.Size = new System.Drawing.Size(162, 22);
            this.login_txtBox.TabIndex = 0;
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(91, 72);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.PasswordChar = '*';
            this.password_txtBox.Size = new System.Drawing.Size(162, 22);
            this.password_txtBox.TabIndex = 1;
            this.password_txtBox.TextChanged += new System.EventHandler(this.password_txtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(181, 265);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(46, 17);
            this.debug.TabIndex = 5;
            this.debug.Text = "label3";
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // registrationFormShow_btn
            // 
            this.registrationFormShow_btn.Location = new System.Drawing.Point(91, 168);
            this.registrationFormShow_btn.Name = "registrationFormShow_btn";
            this.registrationFormShow_btn.Size = new System.Drawing.Size(162, 35);
            this.registrationFormShow_btn.TabIndex = 6;
            this.registrationFormShow_btn.Text = "Регистрация";
            this.registrationFormShow_btn.UseVisualStyleBackColor = true;
            this.registrationFormShow_btn.Click += new System.EventHandler(this.registrationFormShow_Click);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(481, 56);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 23);
            this.test_btn.TabIndex = 7;
            this.test_btn.Text = "test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(91, 116);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(162, 35);
            this.enter_btn.TabIndex = 4;
            this.enter_btn.Text = "Вход";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // test_hash
            // 
            this.test_hash.Location = new System.Drawing.Point(472, 100);
            this.test_hash.Name = "test_hash";
            this.test_hash.Size = new System.Drawing.Size(100, 22);
            this.test_hash.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login_txtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password_txtBox);
            this.groupBox1.Controls.Add(this.registrationFormShow_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enter_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.test_hash);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.debug);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Button registrationFormShow_btn;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.TextBox test_hash;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}