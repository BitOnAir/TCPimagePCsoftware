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
            this.btnConnect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbBoxIP = new System.Windows.Forms.ComboBox();
            this.txtBoxSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.任务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空任务列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.强制单步任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消强制单步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.同步任务配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相机管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置相机状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连续触发模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软触发模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.硬触发模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停采图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置相机参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取相机参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升级相机程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询相机错误ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.txtBoxView.Size = new System.Drawing.Size(400, 200);
            this.txtBoxView.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(855, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
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
            this.cmbBoxIP.Location = new System.Drawing.Point(696, 30);
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
            this.txtBoxSendData.Size = new System.Drawing.Size(400, 100);
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务管理ToolStripMenuItem,
            this.相机管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 任务管理ToolStripMenuItem
            // 
            this.任务管理ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.任务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加任务ToolStripMenuItem,
            this.更新任务ToolStripMenuItem,
            this.测试任务ToolStripMenuItem,
            this.删除任务ToolStripMenuItem,
            this.清空任务列表ToolStripMenuItem,
            this.强制单步任务ToolStripMenuItem,
            this.取消强制单步ToolStripMenuItem,
            this.运行任务ToolStripMenuItem,
            this.停止任务ToolStripMenuItem,
            this.保存任务ToolStripMenuItem,
            this.同步任务配置ToolStripMenuItem});
            this.任务管理ToolStripMenuItem.Name = "任务管理ToolStripMenuItem";
            this.任务管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.任务管理ToolStripMenuItem.Text = "任务管理";
            // 
            // 添加任务ToolStripMenuItem
            // 
            this.添加任务ToolStripMenuItem.Name = "添加任务ToolStripMenuItem";
            this.添加任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加任务ToolStripMenuItem.Text = "添加任务";
            this.添加任务ToolStripMenuItem.Click += new System.EventHandler(this.添加任务ToolStripMenuItem_Click);
            // 
            // 更新任务ToolStripMenuItem
            // 
            this.更新任务ToolStripMenuItem.Name = "更新任务ToolStripMenuItem";
            this.更新任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新任务ToolStripMenuItem.Text = "更新任务";
            this.更新任务ToolStripMenuItem.Click += new System.EventHandler(this.更新任务ToolStripMenuItem_Click);
            // 
            // 测试任务ToolStripMenuItem
            // 
            this.测试任务ToolStripMenuItem.Name = "测试任务ToolStripMenuItem";
            this.测试任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.测试任务ToolStripMenuItem.Text = "测试任务";
            this.测试任务ToolStripMenuItem.Click += new System.EventHandler(this.测试任务ToolStripMenuItem_Click);
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除任务ToolStripMenuItem.Text = "删除任务";
            this.删除任务ToolStripMenuItem.Click += new System.EventHandler(this.删除任务ToolStripMenuItem_Click);
            // 
            // 清空任务列表ToolStripMenuItem
            // 
            this.清空任务列表ToolStripMenuItem.Name = "清空任务列表ToolStripMenuItem";
            this.清空任务列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清空任务列表ToolStripMenuItem.Text = "清空任务列表";
            this.清空任务列表ToolStripMenuItem.Click += new System.EventHandler(this.清空任务列表ToolStripMenuItem_Click);
            // 
            // 强制单步任务ToolStripMenuItem
            // 
            this.强制单步任务ToolStripMenuItem.Name = "强制单步任务ToolStripMenuItem";
            this.强制单步任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.强制单步任务ToolStripMenuItem.Text = "强制单步任务";
            this.强制单步任务ToolStripMenuItem.Click += new System.EventHandler(this.强制单步任务ToolStripMenuItem_Click);
            // 
            // 取消强制单步ToolStripMenuItem
            // 
            this.取消强制单步ToolStripMenuItem.Name = "取消强制单步ToolStripMenuItem";
            this.取消强制单步ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.取消强制单步ToolStripMenuItem.Text = "取消强制单步";
            this.取消强制单步ToolStripMenuItem.Click += new System.EventHandler(this.取消强制单步ToolStripMenuItem_Click);
            // 
            // 运行任务ToolStripMenuItem
            // 
            this.运行任务ToolStripMenuItem.Name = "运行任务ToolStripMenuItem";
            this.运行任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.运行任务ToolStripMenuItem.Text = "运行任务";
            this.运行任务ToolStripMenuItem.Click += new System.EventHandler(this.运行任务ToolStripMenuItem_Click);
            // 
            // 停止任务ToolStripMenuItem
            // 
            this.停止任务ToolStripMenuItem.Name = "停止任务ToolStripMenuItem";
            this.停止任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.停止任务ToolStripMenuItem.Text = "停止任务";
            this.停止任务ToolStripMenuItem.Click += new System.EventHandler(this.停止任务ToolStripMenuItem_Click);
            // 
            // 保存任务ToolStripMenuItem
            // 
            this.保存任务ToolStripMenuItem.Name = "保存任务ToolStripMenuItem";
            this.保存任务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存任务ToolStripMenuItem.Text = "保存任务";
            this.保存任务ToolStripMenuItem.Click += new System.EventHandler(this.保存任务ToolStripMenuItem_Click);
            // 
            // 同步任务配置ToolStripMenuItem
            // 
            this.同步任务配置ToolStripMenuItem.Name = "同步任务配置ToolStripMenuItem";
            this.同步任务配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.同步任务配置ToolStripMenuItem.Text = "同步任务配置";
            this.同步任务配置ToolStripMenuItem.Click += new System.EventHandler(this.同步任务配置ToolStripMenuItem_Click);
            // 
            // 相机管理ToolStripMenuItem
            // 
            this.相机管理ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.相机管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置相机状态ToolStripMenuItem,
            this.配置相机参数ToolStripMenuItem,
            this.读取相机参数ToolStripMenuItem,
            this.升级相机程序ToolStripMenuItem,
            this.查询相机错误ToolStripMenuItem});
            this.相机管理ToolStripMenuItem.Name = "相机管理ToolStripMenuItem";
            this.相机管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.相机管理ToolStripMenuItem.Text = "相机管理";
            // 
            // 配置相机状态ToolStripMenuItem
            // 
            this.配置相机状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连续触发模式ToolStripMenuItem,
            this.软触发模式ToolStripMenuItem,
            this.硬触发模式ToolStripMenuItem,
            this.暂停采图ToolStripMenuItem});
            this.配置相机状态ToolStripMenuItem.Name = "配置相机状态ToolStripMenuItem";
            this.配置相机状态ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置相机状态ToolStripMenuItem.Text = "配置相机状态";
            // 
            // 连续触发模式ToolStripMenuItem
            // 
            this.连续触发模式ToolStripMenuItem.Name = "连续触发模式ToolStripMenuItem";
            this.连续触发模式ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.连续触发模式ToolStripMenuItem.Text = "连续触发模式";
            this.连续触发模式ToolStripMenuItem.Click += new System.EventHandler(this.连续触发模式ToolStripMenuItem_Click);
            // 
            // 软触发模式ToolStripMenuItem
            // 
            this.软触发模式ToolStripMenuItem.Name = "软触发模式ToolStripMenuItem";
            this.软触发模式ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.软触发模式ToolStripMenuItem.Text = "软触发模式";
            this.软触发模式ToolStripMenuItem.Click += new System.EventHandler(this.软触发模式ToolStripMenuItem_Click);
            // 
            // 硬触发模式ToolStripMenuItem
            // 
            this.硬触发模式ToolStripMenuItem.Name = "硬触发模式ToolStripMenuItem";
            this.硬触发模式ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.硬触发模式ToolStripMenuItem.Text = "硬触发模式";
            this.硬触发模式ToolStripMenuItem.Click += new System.EventHandler(this.硬触发模式ToolStripMenuItem_Click);
            // 
            // 暂停采图ToolStripMenuItem
            // 
            this.暂停采图ToolStripMenuItem.Name = "暂停采图ToolStripMenuItem";
            this.暂停采图ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.暂停采图ToolStripMenuItem.Text = "暂停采图";
            this.暂停采图ToolStripMenuItem.Click += new System.EventHandler(this.暂停采图ToolStripMenuItem_Click);
            // 
            // 配置相机参数ToolStripMenuItem
            // 
            this.配置相机参数ToolStripMenuItem.Name = "配置相机参数ToolStripMenuItem";
            this.配置相机参数ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置相机参数ToolStripMenuItem.Text = "配置相机参数";
            this.配置相机参数ToolStripMenuItem.Click += new System.EventHandler(this.配置相机参数ToolStripMenuItem_Click);
            // 
            // 读取相机参数ToolStripMenuItem
            // 
            this.读取相机参数ToolStripMenuItem.Name = "读取相机参数ToolStripMenuItem";
            this.读取相机参数ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.读取相机参数ToolStripMenuItem.Text = "读取相机参数";
            this.读取相机参数ToolStripMenuItem.Click += new System.EventHandler(this.读取相机参数ToolStripMenuItem_Click);
            // 
            // 升级相机程序ToolStripMenuItem
            // 
            this.升级相机程序ToolStripMenuItem.Name = "升级相机程序ToolStripMenuItem";
            this.升级相机程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.升级相机程序ToolStripMenuItem.Text = "升级相机程序";
            this.升级相机程序ToolStripMenuItem.Click += new System.EventHandler(this.升级相机程序ToolStripMenuItem_Click);
            // 
            // 查询相机错误ToolStripMenuItem
            // 
            this.查询相机错误ToolStripMenuItem.Name = "查询相机错误ToolStripMenuItem";
            this.查询相机错误ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询相机错误ToolStripMenuItem.Text = "查询相机错误";
            this.查询相机错误ToolStripMenuItem.Click += new System.EventHandler(this.查询相机错误ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 615);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBoxSendData);
            this.Controls.Add(this.cmbBoxIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBoxView);
            this.Controls.Add(this.btnFileBrs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programmer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileBrs;
        private System.Windows.Forms.TextBox txtBoxView;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbBoxIP;
        private System.Windows.Forms.TextBox txtBoxSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 任务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相机管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空任务列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 强制单步任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消强制单步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 同步任务配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置相机状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连续触发模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软触发模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 硬触发模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停采图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置相机参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取相机参数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 升级相机程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询相机错误ToolStripMenuItem;
    }
}

