namespace BookmarketApp
{
    partial class EventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.createEvent_btn = new System.Windows.Forms.Button();
            this.showUsers_btn = new System.Windows.Forms.Button();
            this.findEventById = new System.Windows.Forms.Button();
            this.eventID_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.eventGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ev_type_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ev_date_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ev_place_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ev_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.updateBetType_btn = new MetroFramework.Controls.MetroButton();
            this.betType_GridView = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.betGridView = new System.Windows.Forms.DataGridView();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.users_refresh_btn = new MetroFramework.Controls.MetroButton();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.debug_txtBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betType_GridView)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betGridView)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(575, 276);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(99, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // createEvent_btn
            // 
            this.createEvent_btn.Location = new System.Drawing.Point(695, 94);
            this.createEvent_btn.Name = "createEvent_btn";
            this.createEvent_btn.Size = new System.Drawing.Size(126, 44);
            this.createEvent_btn.TabIndex = 2;
            this.createEvent_btn.Text = "Создать событие";
            this.createEvent_btn.UseVisualStyleBackColor = true;
            this.createEvent_btn.Visible = false;
            this.createEvent_btn.Click += new System.EventHandler(this.createEvent_btn_Click);
            // 
            // showUsers_btn
            // 
            this.showUsers_btn.Location = new System.Drawing.Point(696, 197);
            this.showUsers_btn.Name = "showUsers_btn";
            this.showUsers_btn.Size = new System.Drawing.Size(127, 44);
            this.showUsers_btn.TabIndex = 3;
            this.showUsers_btn.Text = "Показать пользователей";
            this.showUsers_btn.UseVisualStyleBackColor = true;
            this.showUsers_btn.Visible = false;
            this.showUsers_btn.Click += new System.EventHandler(this.showUsers_btn_Click);
            // 
            // findEventById
            // 
            this.findEventById.Location = new System.Drawing.Point(696, 65);
            this.findEventById.Name = "findEventById";
            this.findEventById.Size = new System.Drawing.Size(99, 23);
            this.findEventById.TabIndex = 4;
            this.findEventById.Text = "Найти";
            this.findEventById.UseVisualStyleBackColor = true;
            this.findEventById.Click += new System.EventHandler(this.findEventById_Click);
            // 
            // eventID_txtBox
            // 
            this.eventID_txtBox.Location = new System.Drawing.Point(697, 37);
            this.eventID_txtBox.Name = "eventID_txtBox";
            this.eventID_txtBox.Size = new System.Drawing.Size(100, 22);
            this.eventID_txtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск по id";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(697, 247);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(125, 35);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(695, 145);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(126, 46);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Удалить событие";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // eventGridView1
            // 
            this.eventGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.eventGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView1.Location = new System.Drawing.Point(0, 0);
            this.eventGridView1.Name = "eventGridView1";
            this.eventGridView1.RowHeadersVisible = false;
            this.eventGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.eventGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eventGridView1.RowTemplate.Height = 24;
            this.eventGridView1.Size = new System.Drawing.Size(680, 250);
            this.eventGridView1.TabIndex = 10;
            this.eventGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.eventGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGridView1_CellEndEdit);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(921, 351);
            this.metroTabControl1.TabIndex = 11;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.delete_btn);
            this.metroTabPage1.Controls.Add(this.exit_btn);
            this.metroTabPage1.Controls.Add(this.eventGridView1);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.eventID_txtBox);
            this.metroTabPage1.Controls.Add(this.refresh_btn);
            this.metroTabPage1.Controls.Add(this.findEventById);
            this.metroTabPage1.Controls.Add(this.createEvent_btn);
            this.metroTabPage1.Controls.Add(this.showUsers_btn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(913, 308);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "События";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.groupBox1);
            this.metroTabPage2.Controls.Add(this.updateBetType_btn);
            this.metroTabPage2.Controls.Add(this.betType_GridView);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(913, 308);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Типы ставок";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.ev_type_lbl);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.ev_date_lbl);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.ev_place_lbl);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.ev_name_lbl);
            this.groupBox1.Location = new System.Drawing.Point(534, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 143);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Название";
            // 
            // ev_type_lbl
            // 
            this.ev_type_lbl.AutoSize = true;
            this.ev_type_lbl.Location = new System.Drawing.Point(200, 100);
            this.ev_type_lbl.Name = "ev_type_lbl";
            this.ev_type_lbl.Size = new System.Drawing.Size(87, 20);
            this.ev_type_lbl.TabIndex = 20;
            this.ev_type_lbl.Text = "metroLabel8";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Место";
            // 
            // ev_date_lbl
            // 
            this.ev_date_lbl.AutoSize = true;
            this.ev_date_lbl.Location = new System.Drawing.Point(201, 76);
            this.ev_date_lbl.Name = "ev_date_lbl";
            this.ev_date_lbl.Size = new System.Drawing.Size(86, 20);
            this.ev_date_lbl.TabIndex = 19;
            this.ev_date_lbl.Text = "metroLabel7";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 20);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Дата";
            // 
            // ev_place_lbl
            // 
            this.ev_place_lbl.AutoSize = true;
            this.ev_place_lbl.Location = new System.Drawing.Point(201, 52);
            this.ev_place_lbl.Name = "ev_place_lbl";
            this.ev_place_lbl.Size = new System.Drawing.Size(87, 20);
            this.ev_place_lbl.TabIndex = 18;
            this.ev_place_lbl.Text = "metroLabel6";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 20);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Тип";
            // 
            // ev_name_lbl
            // 
            this.ev_name_lbl.AutoSize = true;
            this.ev_name_lbl.Location = new System.Drawing.Point(201, 28);
            this.ev_name_lbl.Name = "ev_name_lbl";
            this.ev_name_lbl.Size = new System.Drawing.Size(87, 20);
            this.ev_name_lbl.TabIndex = 17;
            this.ev_name_lbl.Text = "metroLabel5";
            // 
            // updateBetType_btn
            // 
            this.updateBetType_btn.Location = new System.Drawing.Point(552, 282);
            this.updateBetType_btn.Name = "updateBetType_btn";
            this.updateBetType_btn.Size = new System.Drawing.Size(111, 23);
            this.updateBetType_btn.TabIndex = 12;
            this.updateBetType_btn.Text = "Обновить";
            this.updateBetType_btn.Click += new System.EventHandler(this.updateBetType_btn_Click);
            // 
            // betType_GridView
            // 
            this.betType_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.betType_GridView.BackgroundColor = System.Drawing.Color.Azure;
            this.betType_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.betType_GridView.Location = new System.Drawing.Point(3, 3);
            this.betType_GridView.Name = "betType_GridView";
            this.betType_GridView.RowHeadersVisible = false;
            this.betType_GridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.betType_GridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.betType_GridView.RowTemplate.Height = 24;
            this.betType_GridView.Size = new System.Drawing.Size(492, 250);
            this.betType_GridView.TabIndex = 10;
            this.betType_GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.betType_GridView_CellClick);
            this.betType_GridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.betType_GridView_CellEnter);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.betGridView);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(913, 308);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Совершенные ставки";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // betGridView
            // 
            this.betGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.betGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.betGridView.Location = new System.Drawing.Point(3, 0);
            this.betGridView.Name = "betGridView";
            this.betGridView.RowHeadersWidth = 51;
            this.betGridView.RowTemplate.Height = 24;
            this.betGridView.Size = new System.Drawing.Size(459, 240);
            this.betGridView.TabIndex = 2;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.users_refresh_btn);
            this.metroTabPage4.Controls.Add(this.userGridView);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(913, 308);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Пользователи";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // users_refresh_btn
            // 
            this.users_refresh_btn.Location = new System.Drawing.Point(524, 251);
            this.users_refresh_btn.Name = "users_refresh_btn";
            this.users_refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.users_refresh_btn.TabIndex = 3;
            this.users_refresh_btn.Text = "Обновить";
            this.users_refresh_btn.Click += new System.EventHandler(this.users_refresh_btn_Click);
            // 
            // userGridView
            // 
            this.userGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(4, 4);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(446, 271);
            this.userGridView.TabIndex = 2;
            // 
            // debug_txtBox
            // 
            this.debug_txtBox.Location = new System.Drawing.Point(660, 21);
            this.debug_txtBox.Multiline = true;
            this.debug_txtBox.Name = "debug_txtBox";
            this.debug_txtBox.Size = new System.Drawing.Size(240, 67);
            this.debug_txtBox.TabIndex = 22;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 458);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.debug_txtBox);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betType_GridView)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betGridView)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button createEvent_btn;
        private System.Windows.Forms.Button showUsers_btn;
        private System.Windows.Forms.Button findEventById;
        private System.Windows.Forms.TextBox eventID_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView eventGridView1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView betType_GridView;
        private MetroFramework.Controls.MetroButton updateBetType_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel ev_type_lbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel ev_date_lbl;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel ev_place_lbl;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel ev_name_lbl;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataGridView betGridView;
        private System.Windows.Forms.DataGridView userGridView;
        private MetroFramework.Controls.MetroTextBox debug_txtBox;
        private MetroFramework.Controls.MetroButton users_refresh_btn;
    }
}