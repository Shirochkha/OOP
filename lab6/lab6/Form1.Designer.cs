
namespace lab6
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
            this.Output = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.zad1 = new System.Windows.Forms.Button();
            this.zad2 = new System.Windows.Forms.Button();
            this.zad3 = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.firstYear = new System.Windows.Forms.TextBox();
            this.firstMonth = new System.Windows.Forms.TextBox();
            this.firstDay = new System.Windows.Forms.TextBox();
            this.lastYear = new System.Windows.Forms.TextBox();
            this.lastMonth = new System.Windows.Forms.TextBox();
            this.lastDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(34, 28);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(125, 41);
            this.Output.TabIndex = 1;
            this.Output.Text = "Вывод данных";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // text
            // 
            this.text.Enabled = false;
            this.text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(60, 90);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(378, 187);
            this.text.TabIndex = 2;
            // 
            // edit
            // 
            this.edit.Enabled = false;
            this.edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(184, 28);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(125, 41);
            this.edit.TabIndex = 3;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // zad1
            // 
            this.zad1.Enabled = false;
            this.zad1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zad1.Location = new System.Drawing.Point(512, 8);
            this.zad1.Name = "zad1";
            this.zad1.Size = new System.Drawing.Size(207, 61);
            this.zad1.TabIndex = 4;
            this.zad1.Text = "Количество упражнений за день";
            this.zad1.UseVisualStyleBackColor = true;
            this.zad1.Click += new System.EventHandler(this.zad1_Click);
            // 
            // zad2
            // 
            this.zad2.Enabled = false;
            this.zad2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zad2.Location = new System.Drawing.Point(512, 101);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(206, 59);
            this.zad2.TabIndex = 6;
            this.zad2.Text = "Общее количество выполненных упражнений";
            this.zad2.UseVisualStyleBackColor = true;
            this.zad2.Click += new System.EventHandler(this.zad2_Click);
            // 
            // zad3
            // 
            this.zad3.Enabled = false;
            this.zad3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zad3.Location = new System.Drawing.Point(512, 166);
            this.zad3.Name = "zad3";
            this.zad3.Size = new System.Drawing.Size(207, 59);
            this.zad3.TabIndex = 7;
            this.zad3.Text = "Самое \"популярное\" упражнение";
            this.zad3.UseVisualStyleBackColor = true;
            this.zad3.Click += new System.EventHandler(this.zad3_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(531, 76);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(44, 19);
            this.dayLabel.TabIndex = 8;
            this.dayLabel.Text = "Дата:";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(581, 75);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(35, 20);
            this.day.TabIndex = 9;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(622, 75);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(35, 20);
            this.month.TabIndex = 10;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(663, 75);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(35, 20);
            this.year.TabIndex = 11;
            // 
            // firstYear
            // 
            this.firstYear.Location = new System.Drawing.Point(673, 231);
            this.firstYear.Name = "firstYear";
            this.firstYear.Size = new System.Drawing.Size(35, 20);
            this.firstYear.TabIndex = 14;
            // 
            // firstMonth
            // 
            this.firstMonth.Location = new System.Drawing.Point(632, 231);
            this.firstMonth.Name = "firstMonth";
            this.firstMonth.Size = new System.Drawing.Size(35, 20);
            this.firstMonth.TabIndex = 13;
            // 
            // firstDay
            // 
            this.firstDay.Location = new System.Drawing.Point(591, 231);
            this.firstDay.Name = "firstDay";
            this.firstDay.Size = new System.Drawing.Size(35, 20);
            this.firstDay.TabIndex = 12;
            // 
            // lastYear
            // 
            this.lastYear.Location = new System.Drawing.Point(673, 257);
            this.lastYear.Name = "lastYear";
            this.lastYear.Size = new System.Drawing.Size(35, 20);
            this.lastYear.TabIndex = 17;
            // 
            // lastMonth
            // 
            this.lastMonth.Location = new System.Drawing.Point(632, 257);
            this.lastMonth.Name = "lastMonth";
            this.lastMonth.Size = new System.Drawing.Size(35, 20);
            this.lastMonth.TabIndex = 16;
            // 
            // lastDay
            // 
            this.lastDay.Location = new System.Drawing.Point(591, 257);
            this.lastDay.Name = "lastDay";
            this.lastDay.Size = new System.Drawing.Size(35, 20);
            this.lastDay.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(522, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Период:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastYear);
            this.Controls.Add(this.lastMonth);
            this.Controls.Add(this.lastDay);
            this.Controls.Add(this.firstYear);
            this.Controls.Add(this.firstMonth);
            this.Controls.Add(this.firstDay);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.zad3);
            this.Controls.Add(this.zad2);
            this.Controls.Add(this.zad1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Output;
        public System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button edit;
        public System.Windows.Forms.Button zad1;
        public System.Windows.Forms.Button zad2;
        public System.Windows.Forms.Button zad3;
        public System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox firstYear;
        private System.Windows.Forms.TextBox firstMonth;
        private System.Windows.Forms.TextBox firstDay;
        private System.Windows.Forms.TextBox lastYear;
        private System.Windows.Forms.TextBox lastMonth;
        private System.Windows.Forms.TextBox lastDay;
        public System.Windows.Forms.Label label1;
    }
}

