
namespace MedLab.Forms
{
    partial class MainForm
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
            this.EnterAsLaborantBtn = new System.Windows.Forms.Button();
            this.EnterAsResearcherBtn = new System.Windows.Forms.Button();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лаборатория";
            // 
            // EnterAsLaborantBtn
            // 
            this.EnterAsLaborantBtn.Location = new System.Drawing.Point(86, 158);
            this.EnterAsLaborantBtn.Name = "EnterAsLaborantBtn";
            this.EnterAsLaborantBtn.Size = new System.Drawing.Size(286, 89);
            this.EnterAsLaborantBtn.TabIndex = 2;
            this.EnterAsLaborantBtn.Text = "Войти как лаборант";
            this.EnterAsLaborantBtn.UseVisualStyleBackColor = true;
            this.EnterAsLaborantBtn.Click += new System.EventHandler(this.EnterAsLaborantBtn_Click);
            // 
            // EnterAsResearcherBtn
            // 
            this.EnterAsResearcherBtn.Location = new System.Drawing.Point(86, 253);
            this.EnterAsResearcherBtn.Name = "EnterAsResearcherBtn";
            this.EnterAsResearcherBtn.Size = new System.Drawing.Size(286, 89);
            this.EnterAsResearcherBtn.TabIndex = 3;
            this.EnterAsResearcherBtn.Text = "Войти как лаборант - исследователь";
            this.EnterAsResearcherBtn.UseVisualStyleBackColor = true;
            this.EnterAsResearcherBtn.Click += new System.EventHandler(this.EnterAsResearcherBtn_Click);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Location = new System.Drawing.Point(86, 348);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(286, 89);
            this.LeaveBtn.TabIndex = 4;
            this.LeaveBtn.Text = "Выйти";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MedLab.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(287, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 458);
            this.ControlBox = false;
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.EnterAsResearcherBtn);
            this.Controls.Add(this.EnterAsLaborantBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное мнню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterAsLaborantBtn;
        private System.Windows.Forms.Button EnterAsResearcherBtn;
        private System.Windows.Forms.Button LeaveBtn;
    }
}