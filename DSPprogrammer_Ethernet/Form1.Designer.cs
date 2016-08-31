namespace DSPprogrammer_Ethernet
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFileBrs = new System.Windows.Forms.Button();
            this.txtBoxView = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbBoxIP = new System.Windows.Forms.ComboBox();
            this.txtBoxSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileBrs
            // 
            this.btnFileBrs.Location = new System.Drawing.Point(696, 63);
            this.btnFileBrs.Name = "btnFileBrs";
            this.btnFileBrs.Size = new System.Drawing.Size(100, 30);
            this.btnFileBrs.TabIndex = 0;
            this.btnFileBrs.Text = "导入升级文件";
            this.btnFileBrs.UseVisualStyleBackColor = true;
            this.btnFileBrs.Click += new System.EventHandler(this.btnFileBrs_Click);
            // 
            // txtBoxView
            // 
            this.txtBoxView.AllowDrop = true;
            this.txtBoxView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxView.Location = new System.Drawing.Point(696, 124);
            this.txtBoxView.Multiline = true;
            this.txtBoxView.Name = "txtBoxView";
            this.txtBoxView.ReadOnly = true;
            this.txtBoxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxView.Size = new System.Drawing.Size(300, 200);
            this.txtBoxView.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(855, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "升级";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(855, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbBoxIP
            // 
            this.cmbBoxIP.AllowDrop = true;
            this.cmbBoxIP.DropDownHeight = 120;
            this.cmbBoxIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBoxIP.FormattingEnabled = true;
            this.cmbBoxIP.IntegralHeight = false;
            this.cmbBoxIP.Location = new System.Drawing.Point(696, 16);
            this.cmbBoxIP.Name = "cmbBoxIP";
            this.cmbBoxIP.Size = new System.Drawing.Size(120, 22);
            this.cmbBoxIP.TabIndex = 10;
            this.cmbBoxIP.Text = "相机IP";
            // 
            // txtBoxSendData
            // 
            this.txtBoxSendData.Location = new System.Drawing.Point(696, 341);
            this.txtBoxSendData.Multiline = true;
            this.txtBoxSendData.Name = "txtBoxSendData";
            this.txtBoxSendData.Size = new System.Drawing.Size(300, 100);
            this.txtBoxSendData.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(855, 466);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 539);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxSendData);
            this.Controls.Add(this.cmbBoxIP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxView);
            this.Controls.Add(this.btnFileBrs);
            this.Name = "Form1";
            this.Text = "Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileBrs;
        private System.Windows.Forms.TextBox txtBoxView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbBoxIP;
        private System.Windows.Forms.TextBox txtBoxSendData;
        private System.Windows.Forms.Button btnSend;
    }
}

