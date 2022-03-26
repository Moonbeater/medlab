
namespace MedLab.Forms
{
    partial class AddOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodeBio = new System.Windows.Forms.TextBox();
            this.GenerateCodeBtn = new System.Windows.Forms.Button();
            this.AfterGenPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientCB = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AfterGenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата формирования заказа:";
            // 
            // OrderDTP
            // 
            this.OrderDTP.Location = new System.Drawing.Point(308, 117);
            this.OrderDTP.Name = "OrderDTP";
            this.OrderDTP.Size = new System.Drawing.Size(207, 31);
            this.OrderDTP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Лаборатория";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MedLab.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(286, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код пробирки:";
            // 
            // TxtCodeBio
            // 
            this.TxtCodeBio.Location = new System.Drawing.Point(16, 35);
            this.TxtCodeBio.Name = "TxtCodeBio";
            this.TxtCodeBio.ReadOnly = true;
            this.TxtCodeBio.Size = new System.Drawing.Size(499, 31);
            this.TxtCodeBio.TabIndex = 8;
            // 
            // GenerateCodeBtn
            // 
            this.GenerateCodeBtn.Location = new System.Drawing.Point(101, 157);
            this.GenerateCodeBtn.Name = "GenerateCodeBtn";
            this.GenerateCodeBtn.Size = new System.Drawing.Size(323, 35);
            this.GenerateCodeBtn.TabIndex = 9;
            this.GenerateCodeBtn.Text = "Сформировать код пробирки";
            this.GenerateCodeBtn.UseVisualStyleBackColor = true;
            this.GenerateCodeBtn.Click += new System.EventHandler(this.GenerateCodeBtn_Click);
            // 
            // AfterGenPanel
            // 
            this.AfterGenPanel.Controls.Add(this.SaveBtn);
            this.AfterGenPanel.Controls.Add(this.PatientCB);
            this.AfterGenPanel.Controls.Add(this.label4);
            this.AfterGenPanel.Controls.Add(this.TxtCodeBio);
            this.AfterGenPanel.Controls.Add(this.label3);
            this.AfterGenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AfterGenPanel.Enabled = false;
            this.AfterGenPanel.Location = new System.Drawing.Point(0, 206);
            this.AfterGenPanel.Name = "AfterGenPanel";
            this.AfterGenPanel.Size = new System.Drawing.Size(527, 222);
            this.AfterGenPanel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пациент:";
            // 
            // PatientCB
            // 
            this.PatientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientCB.FormattingEnabled = true;
            this.PatientCB.IntegralHeight = false;
            this.PatientCB.Location = new System.Drawing.Point(16, 94);
            this.PatientCB.MaxDropDownItems = 6;
            this.PatientCB.Name = "PatientCB";
            this.PatientCB.Size = new System.Drawing.Size(499, 30);
            this.PatientCB.TabIndex = 10;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Location = new System.Drawing.Point(416, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(99, 35);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(101, 149);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(323, 35);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 428);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AfterGenPanel);
            this.Controls.Add(this.GenerateCodeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderDTP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AfterGenPanel.ResumeLayout(false);
            this.AfterGenPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker OrderDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodeBio;
        private System.Windows.Forms.Button GenerateCodeBtn;
        private System.Windows.Forms.Panel AfterGenPanel;
        private System.Windows.Forms.ComboBox PatientCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}