namespace Form_Task_4_32
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
            this.Zapolnenie = new System.Windows.Forms.Button();
            this.Reshenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(644, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // Zapolnenie
            // 
            this.Zapolnenie.Location = new System.Drawing.Point(62, 397);
            this.Zapolnenie.Name = "Zapolnenie";
            this.Zapolnenie.Size = new System.Drawing.Size(113, 23);
            this.Zapolnenie.TabIndex = 1;
            this.Zapolnenie.Text = "Заполнение DGV";
            this.Zapolnenie.UseVisualStyleBackColor = true;
            this.Zapolnenie.Click += new System.EventHandler(this.Zapolnenie_Click);
            // 
            // Reshenie
            // 
            this.Reshenie.Location = new System.Drawing.Point(630, 396);
            this.Reshenie.Name = "Reshenie";
            this.Reshenie.Size = new System.Drawing.Size(75, 23);
            this.Reshenie.TabIndex = 2;
            this.Reshenie.Text = "Решение";
            this.Reshenie.UseVisualStyleBackColor = true;
            this.Reshenie.Click += new System.EventHandler(this.Reshenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reshenie);
            this.Controls.Add(this.Zapolnenie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Zapolnenie;
        private System.Windows.Forms.Button Reshenie;
    }
}

