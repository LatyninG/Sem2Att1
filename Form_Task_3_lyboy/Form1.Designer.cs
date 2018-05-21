namespace Form_Task_3_lyboy
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
            this.Rand = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(751, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // Rand
            // 
            this.Rand.Location = new System.Drawing.Point(34, 418);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(75, 23);
            this.Rand.TabIndex = 1;
            this.Rand.Text = "Заполнение файла";
            this.Rand.UseVisualStyleBackColor = true;
            this.Rand.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV
            // 
            this.DGV.Location = new System.Drawing.Point(158, 417);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(75, 23);
            this.DGV.TabIndex = 2;
            this.DGV.Text = "DGV заполнение";
            this.DGV.UseVisualStyleBackColor = true;
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            // 
            // Reshenie
            // 
            this.Reshenie.Location = new System.Drawing.Point(678, 418);
            this.Reshenie.Name = "Reshenie";
            this.Reshenie.Size = new System.Drawing.Size(107, 23);
            this.Reshenie.TabIndex = 3;
            this.Reshenie.Text = "Решение";
            this.Reshenie.UseVisualStyleBackColor = true;
            this.Reshenie.Click += new System.EventHandler(this.Reshenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.Controls.Add(this.Reshenie);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Rand;
        private System.Windows.Forms.Button DGV;
        private System.Windows.Forms.Button Reshenie;
    }
}

