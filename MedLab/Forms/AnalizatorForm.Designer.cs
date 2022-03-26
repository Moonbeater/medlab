
namespace MedLab.Forms
{
    partial class AnalizatorForm
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
            this.components = new System.ComponentModel.Container();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SendToResearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalizatorCB = new System.Windows.Forms.ComboBox();
            this.ResearchTimer = new System.Windows.Forms.Timer(this.components);
            this.AnalizBar = new System.Windows.Forms.ProgressBar();
            this.LoadingPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.AcceptResultBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(113, 386);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(181, 35);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SendToResearchBtn
            // 
            this.SendToResearchBtn.Location = new System.Drawing.Point(12, 184);
            this.SendToResearchBtn.Name = "SendToResearchBtn";
            this.SendToResearchBtn.Size = new System.Drawing.Size(386, 35);
            this.SendToResearchBtn.TabIndex = 18;
            this.SendToResearchBtn.Text = "Отправить на исследование";
            this.SendToResearchBtn.UseVisualStyleBackColor = true;
            this.SendToResearchBtn.Click += new System.EventHandler(this.SendToResearchBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F);
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Лаборатория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите анализатор:";
            // 
            // AnalizatorCB
            // 
            this.AnalizatorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnalizatorCB.FormattingEnabled = true;
            this.AnalizatorCB.IntegralHeight = false;
            this.AnalizatorCB.Items.AddRange(new object[] {
            "Biorad",
            "Ledetect"});
            this.AnalizatorCB.Location = new System.Drawing.Point(12, 134);
            this.AnalizatorCB.MaxDropDownItems = 5;
            this.AnalizatorCB.Name = "AnalizatorCB";
            this.AnalizatorCB.Size = new System.Drawing.Size(386, 30);
            this.AnalizatorCB.TabIndex = 14;
            // 
            // ResearchTimer
            // 
            this.ResearchTimer.Interval = 1000;
            this.ResearchTimer.Tick += new System.EventHandler(this.ResearchTimer_Tick);
            // 
            // AnalizBar
            // 
            this.AnalizBar.Location = new System.Drawing.Point(42, 225);
            this.AnalizBar.Name = "AnalizBar";
            this.AnalizBar.Size = new System.Drawing.Size(356, 23);
            this.AnalizBar.TabIndex = 21;
            this.AnalizBar.Visible = false;
            // 
            // LoadingPB
            // 
            this.LoadingPB.Image = global::MedLab.Properties.Resources.loader;
            this.LoadingPB.Location = new System.Drawing.Point(12, 225);
            this.LoadingPB.Name = "LoadingPB";
            this.LoadingPB.Size = new System.Drawing.Size(23, 23);
            this.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPB.TabIndex = 20;
            this.LoadingPB.TabStop = false;
            this.LoadingPB.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MedLab.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(306, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Результат:";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(12, 276);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(386, 31);
            this.TxtResult.TabIndex = 23;
            // 
            // AcceptResultBtn
            // 
            this.AcceptResultBtn.Enabled = false;
            this.AcceptResultBtn.Location = new System.Drawing.Point(12, 313);
            this.AcceptResultBtn.Name = "AcceptResultBtn";
            this.AcceptResultBtn.Size = new System.Drawing.Size(386, 35);
            this.AcceptResultBtn.TabIndex = 24;
            this.AcceptResultBtn.Text = "Одобрить результат";
            this.AcceptResultBtn.UseVisualStyleBackColor = true;
            this.AcceptResultBtn.Click += new System.EventHandler(this.AcceptResultBtn_Click);
            // 
            // AnalizatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 433);
            this.ControlBox = false;
            this.Controls.Add(this.AcceptResultBtn);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnalizBar);
            this.Controls.Add(this.LoadingPB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SendToResearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnalizatorCB);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AnalizatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агализатор";
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SendToResearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AnalizatorCB;
        private System.Windows.Forms.Timer ResearchTimer;
        private System.Windows.Forms.PictureBox LoadingPB;
        private System.Windows.Forms.ProgressBar AnalizBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button AcceptResultBtn;
    }
}