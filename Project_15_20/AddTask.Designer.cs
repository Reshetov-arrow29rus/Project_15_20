namespace Project_15_20
{
    partial class AddTask
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
            this.AddTaskGroupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NameTaskTextBox1 = new System.Windows.Forms.TextBox();
            this.OkButton1 = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.AddTaskGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTaskGroupBox1
            // 
            this.AddTaskGroupBox1.Controls.Add(this.DescriptionTextBox2);
            this.AddTaskGroupBox1.Controls.Add(this.label3);
            this.AddTaskGroupBox1.Controls.Add(this.label2);
            this.AddTaskGroupBox1.Controls.Add(this.label1);
            this.AddTaskGroupBox1.Controls.Add(this.dateTimePicker1);
            this.AddTaskGroupBox1.Controls.Add(this.NameTaskTextBox1);
            this.AddTaskGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.AddTaskGroupBox1.Name = "AddTaskGroupBox1";
            this.AddTaskGroupBox1.Size = new System.Drawing.Size(410, 415);
            this.AddTaskGroupBox1.TabIndex = 0;
            this.AddTaskGroupBox1.TabStop = false;
            this.AddTaskGroupBox1.Text = "Добавление задачи";
            // 
            // DescriptionTextBox2
            // 
            this.DescriptionTextBox2.Location = new System.Drawing.Point(112, 187);
            this.DescriptionTextBox2.Multiline = true;
            this.DescriptionTextBox2.Name = "DescriptionTextBox2";
            this.DescriptionTextBox2.Size = new System.Drawing.Size(277, 218);
            this.DescriptionTextBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата выполнения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // NameTaskTextBox1
            // 
            this.NameTaskTextBox1.Location = new System.Drawing.Point(185, 58);
            this.NameTaskTextBox1.Name = "NameTaskTextBox1";
            this.NameTaskTextBox1.Size = new System.Drawing.Size(204, 24);
            this.NameTaskTextBox1.TabIndex = 0;
            this.NameTaskTextBox1.TextChanged += new System.EventHandler(this.NameTaskTextBox1_TextChanged);
            // 
            // OkButton1
            // 
            this.OkButton1.Enabled = false;
            this.OkButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton1.Location = new System.Drawing.Point(12, 448);
            this.OkButton1.Name = "OkButton1";
            this.OkButton1.Size = new System.Drawing.Size(119, 33);
            this.OkButton1.TabIndex = 1;
            this.OkButton1.Text = "Ок";
            this.OkButton1.UseVisualStyleBackColor = true;
            this.OkButton1.Click += new System.EventHandler(this.OkButton1_Click);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton2.Location = new System.Drawing.Point(303, 448);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(119, 33);
            this.CancelButton2.TabIndex = 2;
            this.CancelButton2.Text = "Отмена";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.OkButton1);
            this.Controls.Add(this.AddTaskGroupBox1);
            this.MaximizeBox = false;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask (Добавление задачи)";
            this.AddTaskGroupBox1.ResumeLayout(false);
            this.AddTaskGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddTaskGroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox NameTaskTextBox1;
        private System.Windows.Forms.TextBox DescriptionTextBox2;
        private System.Windows.Forms.Button OkButton1;
        private System.Windows.Forms.Button CancelButton2;
    }
}