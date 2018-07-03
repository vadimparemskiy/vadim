using System;

namespace calc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.sabtraction = new System.Windows.Forms.Button();
            this.multyplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(12, 102);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(35, 27);
            this.sum.TabIndex = 3;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.Click);
            // 
            // sabtraction
            // 
            this.sabtraction.Location = new System.Drawing.Point(73, 102);
            this.sabtraction.Name = "sabtraction";
            this.sabtraction.Size = new System.Drawing.Size(37, 27);
            this.sabtraction.TabIndex = 4;
            this.sabtraction.Text = "-";
            this.sabtraction.UseVisualStyleBackColor = true;
            this.sabtraction.Click += new System.EventHandler(this.Click);
            // 
            // multyplication
            // 
            this.multyplication.Location = new System.Drawing.Point(133, 104);
            this.multyplication.Name = "multyplication";
            this.multyplication.Size = new System.Drawing.Size(39, 25);
            this.multyplication.TabIndex = 5;
            this.multyplication.Text = "*";
            this.multyplication.UseVisualStyleBackColor = true;
            this.multyplication.Click += new System.EventHandler(this.Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(189, 102);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(36, 27);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multyplication);
            this.Controls.Add(this.sabtraction);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sabtraction;
        private System.Windows.Forms.Button multyplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox3;
    }
}

