namespace Atta_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.But1 = new System.Windows.Forms.RadioButton();
            this.But2 = new System.Windows.Forms.RadioButton();
            this.But3 = new System.Windows.Forms.RadioButton();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "n=";
            // 
            // But1
            // 
            this.But1.AutoSize = true;
            this.But1.Checked = true;
            this.But1.Location = new System.Drawing.Point(16, 85);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(38, 17);
            this.But1.TabIndex = 6;
            this.But1.TabStop = true;
            this.But1.Text = "sin";
            this.But1.UseVisualStyleBackColor = true;
            // 
            // But2
            // 
            this.But2.AutoSize = true;
            this.But2.Location = new System.Drawing.Point(65, 85);
            this.But2.Name = "But2";
            this.But2.Size = new System.Drawing.Size(42, 17);
            this.But2.TabIndex = 7;
            this.But2.TabStop = true;
            this.But2.Text = "cos";
            this.But2.UseVisualStyleBackColor = true;
            // 
            // But3
            // 
            this.But3.AutoSize = true;
            this.But3.Location = new System.Drawing.Point(120, 85);
            this.But3.Name = "But3";
            this.But3.Size = new System.Drawing.Size(42, 17);
            this.But3.TabIndex = 8;
            this.But3.TabStop = true;
            this.But3.Text = "exp";
            this.But3.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(16, 160);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(45, 23);
            this.open.TabIndex = 9;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(120, 160);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(42, 23);
            this.save.TabIndex = 10;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(254, 13);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 276);
            this.textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 292);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.But3);
            this.Controls.Add(this.But2);
            this.Controls.Add(this.But1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Программа Генца";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton But1;
        private System.Windows.Forms.RadioButton But2;
        private System.Windows.Forms.RadioButton But3;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

