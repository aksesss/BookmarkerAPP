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
            this.refresh_btn = new System.Windows.Forms.Button();
            this.createEvent_btn = new System.Windows.Forms.Button();
            this.showUsers_btn = new System.Windows.Forms.Button();
            this.findEventById = new System.Windows.Forms.Button();
            this.eventID_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(606, 294);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(99, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // createEvent_btn
            // 
            this.createEvent_btn.Location = new System.Drawing.Point(726, 112);
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
            this.showUsers_btn.Location = new System.Drawing.Point(727, 215);
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
            this.findEventById.Location = new System.Drawing.Point(727, 83);
            this.findEventById.Name = "findEventById";
            this.findEventById.Size = new System.Drawing.Size(99, 23);
            this.findEventById.TabIndex = 4;
            this.findEventById.Text = "Найти";
            this.findEventById.UseVisualStyleBackColor = true;
            this.findEventById.Click += new System.EventHandler(this.findEventById_Click);
            // 
            // eventID_txtBox
            // 
            this.eventID_txtBox.Location = new System.Drawing.Point(728, 55);
            this.eventID_txtBox.Name = "eventID_txtBox";
            this.eventID_txtBox.Size = new System.Drawing.Size(100, 22);
            this.eventID_txtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск по id";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(728, 265);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(125, 35);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(726, 163);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(126, 46);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Удалить событие";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 250);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventID_txtBox);
            this.Controls.Add(this.findEventById);
            this.Controls.Add(this.showUsers_btn);
            this.Controls.Add(this.createEvent_btn);
            this.Controls.Add(this.refresh_btn);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}