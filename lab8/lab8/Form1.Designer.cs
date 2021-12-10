
namespace lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zad1 = new System.Windows.Forms.Button();
            this.zad2 = new System.Windows.Forms.Button();
            this.zad3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.zad4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(47, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 278);
            this.textBox1.TabIndex = 0;
            // 
            // zad1
            // 
            this.zad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zad1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zad1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zad1.Location = new System.Drawing.Point(506, 12);
            this.zad1.Name = "zad1";
            this.zad1.Size = new System.Drawing.Size(245, 59);
            this.zad1.TabIndex = 1;
            this.zad1.Text = "Вывод информации. Желтый цвет - школьники старше 12 лет";
            this.zad1.UseVisualStyleBackColor = false;
            this.zad1.Click += new System.EventHandler(this.zad1_Click);
            // 
            // zad2
            // 
            this.zad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zad2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zad2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zad2.Location = new System.Drawing.Point(506, 87);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(245, 69);
            this.zad2.TabIndex = 2;
            this.zad2.Text = "Вывод информации об учащихся, где фамилии в алфавитном порядке ";
            this.zad2.UseVisualStyleBackColor = false;
            this.zad2.Click += new System.EventHandler(this.zad2_Click);
            // 
            // zad3
            // 
            this.zad3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zad3.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zad3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zad3.Location = new System.Drawing.Point(506, 172);
            this.zad3.Name = "zad3";
            this.zad3.Size = new System.Drawing.Size(245, 34);
            this.zad3.TabIndex = 3;
            this.zad3.Text = "Количество двоечников";
            this.zad3.UseVisualStyleBackColor = false;
            this.zad3.Click += new System.EventHandler(this.zad3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(525, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Школа:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(593, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 5;
            // 
            // zad4
            // 
            this.zad4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.zad4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zad4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zad4.Location = new System.Drawing.Point(506, 248);
            this.zad4.Name = "zad4";
            this.zad4.Size = new System.Drawing.Size(245, 59);
            this.zad4.TabIndex = 6;
            this.zad4.Text = "Вывод информации о студентах с повышенной стипендией ";
            this.zad4.UseVisualStyleBackColor = false;
            this.zad4.Click += new System.EventHandler(this.zad4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.zad4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zad3);
            this.Controls.Add(this.zad2);
            this.Controls.Add(this.zad1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button zad1;
        public System.Windows.Forms.Button zad2;
        public System.Windows.Forms.Button zad3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button zad4;
    }
}

