namespace BookmarketApp
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillData_btn = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.Label();
            this.showFormCreateEvent_btn = new System.Windows.Forms.Button();
            this.debug_lbl = new System.Windows.Forms.Label();
            this.test_button = new System.Windows.Forms.Button();
            this.deleteEvent_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fillData_btn
            // 
            this.fillData_btn.Location = new System.Drawing.Point(12, 365);
            this.fillData_btn.Name = "fillData_btn";
            this.fillData_btn.Size = new System.Drawing.Size(75, 23);
            this.fillData_btn.TabIndex = 1;
            this.fillData_btn.Text = "FillDB";
            this.fillData_btn.UseVisualStyleBackColor = true;
            this.fillData_btn.Click += new System.EventHandler(this.fillData_Click);
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.Location = new System.Drawing.Point(808, 383);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(46, 17);
            this.Debug.TabIndex = 2;
            this.Debug.Text = "label1";
            // 
            // showFormCreateEvent_btn
            // 
            this.showFormCreateEvent_btn.Location = new System.Drawing.Point(577, 348);
            this.showFormCreateEvent_btn.Name = "showFormCreateEvent_btn";
            this.showFormCreateEvent_btn.Size = new System.Drawing.Size(174, 40);
            this.showFormCreateEvent_btn.TabIndex = 3;
            this.showFormCreateEvent_btn.Text = "Create Event";
            this.showFormCreateEvent_btn.UseVisualStyleBackColor = true;
            this.showFormCreateEvent_btn.Click += new System.EventHandler(this.showFormCreateEvent_btn_Click);
            // 
            // debug_lbl
            // 
            this.debug_lbl.AutoSize = true;
            this.debug_lbl.Location = new System.Drawing.Point(111, 411);
            this.debug_lbl.Name = "debug_lbl";
            this.debug_lbl.Size = new System.Drawing.Size(46, 17);
            this.debug_lbl.TabIndex = 4;
            this.debug_lbl.Text = "label1";
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(114, 368);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(75, 23);
            this.test_button.TabIndex = 5;
            this.test_button.Text = "button1";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // deleteEvent_btn
            // 
            this.deleteEvent_btn.Location = new System.Drawing.Point(577, 401);
            this.deleteEvent_btn.Name = "deleteEvent_btn";
            this.deleteEvent_btn.Size = new System.Drawing.Size(174, 37);
            this.deleteEvent_btn.TabIndex = 6;
            this.deleteEvent_btn.Text = "Delete event";
            this.deleteEvent_btn.UseVisualStyleBackColor = true;
            this.deleteEvent_btn.Click += new System.EventHandler(this.deleteEvent_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(577, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(492, 315);
            this.dataGridView2.TabIndex = 9;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(963, 362);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 490);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteEvent_btn);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.debug_lbl);
            this.Controls.Add(this.showFormCreateEvent_btn);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.fillData_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fillData_btn;
        private System.Windows.Forms.Label Debug;
        private System.Windows.Forms.Button showFormCreateEvent_btn;
        private System.Windows.Forms.Label debug_lbl;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Button deleteEvent_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button delete_btn;
    }
}

