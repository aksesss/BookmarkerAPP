namespace BookmarketApp
{
    partial class CreateEventForm
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
            this.place_txtBox = new System.Windows.Forms.TextBox();
            this.Тип = new System.Windows.Forms.Label();
            this.createEvent_btn = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.type_txtBox = new System.Windows.Forms.ComboBox();
            this.date_txtBox = new System.Windows.Forms.TextBox();
            this.time_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // place_txtBox
            // 
            this.place_txtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.place_txtBox.Location = new System.Drawing.Point(123, 92);
            this.place_txtBox.Name = "place_txtBox";
            this.place_txtBox.Size = new System.Drawing.Size(253, 22);
            this.place_txtBox.TabIndex = 0;
            // 
            // Тип
            // 
            this.Тип.AutoSize = true;
            this.Тип.Location = new System.Drawing.Point(38, 46);
            this.Тип.Name = "Тип";
            this.Тип.Size = new System.Drawing.Size(33, 17);
            this.Тип.TabIndex = 1;
            this.Тип.Text = "Тип";
            // 
            // createEvent_btn
            // 
            this.createEvent_btn.Location = new System.Drawing.Point(195, 240);
            this.createEvent_btn.Name = "createEvent_btn";
            this.createEvent_btn.Size = new System.Drawing.Size(75, 23);
            this.createEvent_btn.TabIndex = 2;
            this.createEvent_btn.Text = "Создать";
            this.createEvent_btn.UseVisualStyleBackColor = true;
            this.createEvent_btn.Click += new System.EventHandler(this.createEvent_btn_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(35, 97);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(49, 17);
            this.debug.TabIndex = 3;
            this.debug.Text = "Место";
            // 
            // type_txtBox
            // 
            this.type_txtBox.FormattingEnabled = true;
            this.type_txtBox.Items.AddRange(new object[] {
            "Football match",
            "Horse run"});
            this.type_txtBox.Location = new System.Drawing.Point(123, 43);
            this.type_txtBox.Name = "type_txtBox";
            this.type_txtBox.Size = new System.Drawing.Size(253, 24);
            this.type_txtBox.TabIndex = 4;
            // 
            // date_txtBox
            // 
            this.date_txtBox.Location = new System.Drawing.Point(123, 143);
            this.date_txtBox.Name = "date_txtBox";
            this.date_txtBox.Size = new System.Drawing.Size(253, 22);
            this.date_txtBox.TabIndex = 5;
            // 
            // time_txtBox
            // 
            this.time_txtBox.Location = new System.Drawing.Point(123, 186);
            this.time_txtBox.Name = "time_txtBox";
            this.time_txtBox.Size = new System.Drawing.Size(253, 22);
            this.time_txtBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_txtBox);
            this.Controls.Add(this.date_txtBox);
            this.Controls.Add(this.type_txtBox);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.createEvent_btn);
            this.Controls.Add(this.Тип);
            this.Controls.Add(this.place_txtBox);
            this.Name = "CreateEventForm";
            this.Text = "CreateEventForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEventForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox place_txtBox;
        private System.Windows.Forms.Label Тип;
        private System.Windows.Forms.Button createEvent_btn;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.ComboBox type_txtBox;
        private System.Windows.Forms.TextBox date_txtBox;
        private System.Windows.Forms.TextBox time_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}