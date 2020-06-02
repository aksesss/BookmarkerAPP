namespace BookmarketApp
{
    partial class UpdateEventForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_txtBox = new System.Windows.Forms.TextBox();
            this.date_txtBox = new System.Windows.Forms.TextBox();
            this.type_txtBox = new System.Windows.Forms.ComboBox();
            this.debug = new System.Windows.Forms.Label();
            this.updateEvent_btn = new System.Windows.Forms.Button();
            this.Тип = new System.Windows.Forms.Label();
            this.place_txtBox = new System.Windows.Forms.TextBox();
            this.id_txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата";
            // 
            // time_txtBox
            // 
            this.time_txtBox.Location = new System.Drawing.Point(113, 219);
            this.time_txtBox.Name = "time_txtBox";
            this.time_txtBox.Size = new System.Drawing.Size(253, 22);
            this.time_txtBox.TabIndex = 15;
            // 
            // date_txtBox
            // 
            this.date_txtBox.Location = new System.Drawing.Point(113, 176);
            this.date_txtBox.Name = "date_txtBox";
            this.date_txtBox.Size = new System.Drawing.Size(253, 22);
            this.date_txtBox.TabIndex = 14;
            // 
            // type_txtBox
            // 
            this.type_txtBox.FormattingEnabled = true;
            this.type_txtBox.Items.AddRange(new object[] {
            "Football match",
            "Horse run"});
            this.type_txtBox.Location = new System.Drawing.Point(113, 76);
            this.type_txtBox.Name = "type_txtBox";
            this.type_txtBox.Size = new System.Drawing.Size(253, 24);
            this.type_txtBox.TabIndex = 13;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(25, 130);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(49, 17);
            this.debug.TabIndex = 12;
            this.debug.Text = "Место";
            // 
            // updateEvent_btn
            // 
            this.updateEvent_btn.Location = new System.Drawing.Point(185, 273);
            this.updateEvent_btn.Name = "updateEvent_btn";
            this.updateEvent_btn.Size = new System.Drawing.Size(75, 23);
            this.updateEvent_btn.TabIndex = 11;
            this.updateEvent_btn.Text = "Update";
            this.updateEvent_btn.UseVisualStyleBackColor = true;
            this.updateEvent_btn.Click += new System.EventHandler(this.updateEvent_btn_Click);
            // 
            // Тип
            // 
            this.Тип.AutoSize = true;
            this.Тип.Location = new System.Drawing.Point(28, 79);
            this.Тип.Name = "Тип";
            this.Тип.Size = new System.Drawing.Size(33, 17);
            this.Тип.TabIndex = 10;
            this.Тип.Text = "Тип";
            // 
            // place_txtBox
            // 
            this.place_txtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.place_txtBox.Location = new System.Drawing.Point(113, 125);
            this.place_txtBox.Name = "place_txtBox";
            this.place_txtBox.Size = new System.Drawing.Size(253, 22);
            this.place_txtBox.TabIndex = 9;
            // 
            // id_txtBox
            // 
            this.id_txtBox.Location = new System.Drawing.Point(113, 35);
            this.id_txtBox.Name = "id_txtBox";
            this.id_txtBox.ReadOnly = true;
            this.id_txtBox.Size = new System.Drawing.Size(100, 22);
            this.id_txtBox.TabIndex = 18;
            // 
            // UpdateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 329);
            this.Controls.Add(this.id_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_txtBox);
            this.Controls.Add(this.date_txtBox);
            this.Controls.Add(this.type_txtBox);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.updateEvent_btn);
            this.Controls.Add(this.Тип);
            this.Controls.Add(this.place_txtBox);
            this.Name = "UpdateEventForm";
            this.Text = "UpdateEventForm";
            this.Load += new System.EventHandler(this.UpdateEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_txtBox;
        private System.Windows.Forms.TextBox date_txtBox;
        private System.Windows.Forms.ComboBox type_txtBox;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Button updateEvent_btn;
        private System.Windows.Forms.Label Тип;
        private System.Windows.Forms.TextBox place_txtBox;
        private System.Windows.Forms.TextBox id_txtBox;
    }
}