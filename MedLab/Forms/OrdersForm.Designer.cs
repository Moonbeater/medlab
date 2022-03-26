
namespace MedLab.Forms
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOrderBtn = new System.Windows.Forms.Button();
            this.OrderServicesBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label1.Location = new System.Drawing.Point(306, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Лаборатория";
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AllowUserToDeleteRows = false;
            this.OrdersDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.OrdersDGV.Location = new System.Drawing.Point(12, 92);
            this.OrdersDGV.MultiSelect = false;
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.ReadOnly = true;
            this.OrdersDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrdersDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(983, 304);
            this.OrdersDGV.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdOrder";
            this.Column1.HeaderText = "№ заказа";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodeBio";
            this.Column2.HeaderText = "Код пробирки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Дата заказа";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FIO";
            this.Column4.HeaderText = "ФИО пациента";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Price";
            this.Column5.HeaderText = "Цена";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.Location = new System.Drawing.Point(12, 402);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(183, 35);
            this.AddOrderBtn.TabIndex = 5;
            this.AddOrderBtn.Text = "Добавить заказ";
            this.AddOrderBtn.UseVisualStyleBackColor = true;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // OrderServicesBtn
            // 
            this.OrderServicesBtn.Location = new System.Drawing.Point(201, 402);
            this.OrderServicesBtn.Name = "OrderServicesBtn";
            this.OrderServicesBtn.Size = new System.Drawing.Size(183, 35);
            this.OrderServicesBtn.TabIndex = 6;
            this.OrderServicesBtn.Text = "Список услуг";
            this.OrderServicesBtn.UseVisualStyleBackColor = true;
            this.OrderServicesBtn.Click += new System.EventHandler(this.OrderServicesBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Location = new System.Drawing.Point(896, 15);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(99, 35);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MedLab.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(577, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 519);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OrderServicesBtn);
            this.Controls.Add(this.AddOrderBtn);
            this.Controls.Add(this.OrdersDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.Button OrderServicesBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}