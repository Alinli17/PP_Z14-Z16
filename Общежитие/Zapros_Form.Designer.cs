namespace Общежитие
{
    partial class Zapros_Form
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
            this.Inquiry = new System.Windows.Forms.GroupBox();
            this.Full_Information = new System.Windows.Forms.RadioButton();
            this.Short_Information = new System.Windows.Forms.RadioButton();
            this.List_of_groups = new System.Windows.Forms.RadioButton();
            this.Number_of_rooms = new System.Windows.Forms.RadioButton();
            this.Students_List = new System.Windows.Forms.RadioButton();
            this.Run_Request = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Inquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Inquiry
            // 
            this.Inquiry.Controls.Add(this.Students_List);
            this.Inquiry.Controls.Add(this.Number_of_rooms);
            this.Inquiry.Controls.Add(this.List_of_groups);
            this.Inquiry.Controls.Add(this.Short_Information);
            this.Inquiry.Controls.Add(this.Full_Information);
            this.Inquiry.Location = new System.Drawing.Point(12, 12);
            this.Inquiry.Name = "Inquiry";
            this.Inquiry.Size = new System.Drawing.Size(451, 160);
            this.Inquiry.TabIndex = 0;
            this.Inquiry.TabStop = false;
            this.Inquiry.Text = "Выберите запрос:";
            // 
            // Full_Information
            // 
            this.Full_Information.AutoSize = true;
            this.Full_Information.Location = new System.Drawing.Point(6, 21);
            this.Full_Information.Name = "Full_Information";
            this.Full_Information.Size = new System.Drawing.Size(249, 21);
            this.Full_Information.TabIndex = 0;
            this.Full_Information.TabStop = true;
            this.Full_Information.Text = "Полная информация о студентах";
            this.Full_Information.UseVisualStyleBackColor = true;
            // 
            // Short_Information
            // 
            this.Short_Information.AutoSize = true;
            this.Short_Information.Location = new System.Drawing.Point(6, 48);
            this.Short_Information.Name = "Short_Information";
            this.Short_Information.Size = new System.Drawing.Size(409, 21);
            this.Short_Information.TabIndex = 1;
            this.Short_Information.TabStop = true;
            this.Short_Information.Text = "Краткая информация о студентах (ФИО, группа и адрес)";
            this.Short_Information.UseVisualStyleBackColor = true;
            // 
            // List_of_groups
            // 
            this.List_of_groups.AutoSize = true;
            this.List_of_groups.Location = new System.Drawing.Point(6, 75);
            this.List_of_groups.Name = "List_of_groups";
            this.List_of_groups.Size = new System.Drawing.Size(411, 21);
            this.List_of_groups.TabIndex = 2;
            this.List_of_groups.TabStop = true;
            this.List_of_groups.Text = "Список групп, студенты которых проживают в общежитии";
            this.List_of_groups.UseVisualStyleBackColor = true;
            // 
            // Number_of_rooms
            // 
            this.Number_of_rooms.AutoSize = true;
            this.Number_of_rooms.Location = new System.Drawing.Point(6, 102);
            this.Number_of_rooms.Name = "Number_of_rooms";
            this.Number_of_rooms.Size = new System.Drawing.Size(281, 21);
            this.Number_of_rooms.TabIndex = 3;
            this.Number_of_rooms.TabStop = true;
            this.Number_of_rooms.Text = "№ комнат, расположенных на 3 этаже";
            this.Number_of_rooms.UseVisualStyleBackColor = true;
            // 
            // Students_List
            // 
            this.Students_List.AutoSize = true;
            this.Students_List.Location = new System.Drawing.Point(6, 129);
            this.Students_List.Name = "Students_List";
            this.Students_List.Size = new System.Drawing.Size(334, 21);
            this.Students_List.TabIndex = 4;
            this.Students_List.TabStop = true;
            this.Students_List.Text = "Список студентов, обучающихся в группах ПО";
            this.Students_List.UseVisualStyleBackColor = true;
            // 
            // Run_Request
            // 
            this.Run_Request.Location = new System.Drawing.Point(510, 44);
            this.Run_Request.Name = "Run_Request";
            this.Run_Request.Size = new System.Drawing.Size(178, 50);
            this.Run_Request.TabIndex = 5;
            this.Run_Request.Text = "Выполнить запрос";
            this.Run_Request.UseVisualStyleBackColor = true;
            this.Run_Request.Click += new System.EventHandler(this.Run_Request_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(510, 100);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(178, 48);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 235);
            this.dataGridView1.TabIndex = 7;
            // 
            // Zapros_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Run_Request);
            this.Controls.Add(this.Inquiry);
            this.Name = "Zapros_Form";
            this.Text = "Запрос";
            this.Inquiry.ResumeLayout(false);
            this.Inquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Inquiry;
        private System.Windows.Forms.RadioButton Students_List;
        private System.Windows.Forms.RadioButton Number_of_rooms;
        private System.Windows.Forms.RadioButton List_of_groups;
        private System.Windows.Forms.RadioButton Short_Information;
        private System.Windows.Forms.RadioButton Full_Information;
        private System.Windows.Forms.Button Run_Request;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}