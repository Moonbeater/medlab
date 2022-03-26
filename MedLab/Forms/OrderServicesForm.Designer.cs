
namespace MedLab.Forms
{
    partial class OrderServicesForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.ServicesDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AnalizatorFilterCB = new System.Windows.Forms.ComboBox();
            this.ResetAnalizFilterBtn = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Location = new System.Drawing.Point(995, 14);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(99, 35);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ServicesDGV
            // 
            this.ServicesDGV.AllowUserToAddRows = false;
            this.ServicesDGV.AllowUserToDeleteRows = false;
            this.ServicesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServicesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ServicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.ServicesDGV.Location = new System.Drawing.Point(12, 91);
            this.ServicesDGV.MultiSelect = false;
            this.ServicesDGV.Name = "ServicesDGV";
            this.ServicesDGV.ReadOnly = true;
            this.ServicesDGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ServicesDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ServicesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServicesDGV.Size = new System.Drawing.Size(1082, 304);
            this.ServicesDGV.TabIndex = 10;
            this.ServicesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServicesDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label1.Location = new System.Drawing.Point(385, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Лаборатория";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MedLab.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(656, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AddServiceBtn
            // 
            this.AddServiceBtn.Location = new System.Drawing.Point(12, 401);
            this.AddServiceBtn.Name = "AddServiceBtn";
            this.AddServiceBtn.Size = new System.Drawing.Size(183, 35);
            this.AddServiceBtn.TabIndex = 12;
            this.AddServiceBtn.Text = "Добавить услугу";
            this.AddServiceBtn.UseVisualStyleBackColor = true;
            this.AddServiceBtn.Click += new System.EventHandler(this.AddServiceBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(201, 401);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(183, 35);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Удалить услугу";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Отбор по анализатору:";
            // 
            // AnalizatorFilterCB
            // 
            this.AnalizatorFilterCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnalizatorFilterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnalizatorFilterCB.FormattingEnabled = true;
            this.AnalizatorFilterCB.IntegralHeight = false;
            this.AnalizatorFilterCB.Items.AddRange(new object[] {
            "Biorad",
            "Ledetect"});
            this.AnalizatorFilterCB.Location = new System.Drawing.Point(768, 404);
            this.AnalizatorFilterCB.MaxDropDownItems = 5;
            this.AnalizatorFilterCB.Name = "AnalizatorFilterCB";
            this.AnalizatorFilterCB.Size = new System.Drawing.Size(290, 30);
            this.AnalizatorFilterCB.TabIndex = 15;
            this.AnalizatorFilterCB.SelectionChangeCommitted += new System.EventHandler(this.AnalizatorFilterCB_SelectionChangeCommitted);
            // 
            // ResetAnalizFilterBtn
            // 
            this.ResetAnalizFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetAnalizFilterBtn.Location = new System.Drawing.Point(1064, 404);
            this.ResetAnalizFilterBtn.Name = "ResetAnalizFilterBtn";
            this.ResetAnalizFilterBtn.Size = new System.Drawing.Size(30, 30);
            this.ResetAnalizFilterBtn.TabIndex = 16;
            this.ResetAnalizFilterBtn.Text = "X";
            this.ResetAnalizFilterBtn.UseVisualStyleBackColor = true;
            this.ResetAnalizFilterBtn.Click += new System.EventHandler(this.ResetAnalizFilterBtn_Click);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "IdOrderService";
            this.Column8.HeaderText = "IdOrderService";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdService";
            this.Column1.HeaderText = "IdService";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Наименование услуги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Analizator";
            this.Column4.HeaderText = "Analizator";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Result";
            this.Column5.HeaderText = "Результат";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Status";
            this.Column6.HeaderText = "Статус";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Отправить на исследование";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // OrderServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 497);
            this.ControlBox = false;
            this.Controls.Add(this.ResetAnalizFilterBtn);
            this.Controls.Add(this.AnalizatorFilterCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddServiceBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ServicesDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OrderServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги заказа";
            this.Load += new System.EventHandler(this.OrderServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView ServicesDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddServiceBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AnalizatorFilterCB;
        private System.Windows.Forms.Button ResetAnalizFilterBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}