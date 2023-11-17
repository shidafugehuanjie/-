using ListViewTest;
namespace dmactool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dmBotAcToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLoader = new System.Windows.Forms.ToolStripTextBox();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSV = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxLoader = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAPP = new System.Windows.Forms.ToolStripTextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frameType = new System.Windows.Forms.ComboBox();
            this.frameFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.frameId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendTimes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.stopButoon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sendInterval = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.saveData = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.canBaudRateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canBaudrateComBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataAccCheckBox = new System.Windows.Forms.CheckBox();
            this.IdAccCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.canData8 = new System.Windows.Forms.TextBox();
            this.canData7 = new System.Windows.Forms.TextBox();
            this.canData6 = new System.Windows.Forms.TextBox();
            this.canData5 = new System.Windows.Forms.TextBox();
            this.canData4 = new System.Windows.Forms.TextBox();
            this.canData3 = new System.Windows.Forms.TextBox();
            this.canData2 = new System.Windows.Forms.TextBox();
            this.canData1 = new System.Windows.Forms.TextBox();
            this.acToolsState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonFresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCAN = new System.Windows.Forms.TabPage();
            this.CAN_richBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.busSpeed = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.Label();
            this.receiveCount = new System.Windows.Forms.Label();
            this.sendCount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabPageUART = new System.Windows.Forms.TabPage();
            this.label_RX = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_TX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.busRxSpeed = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.uart_RX = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.busTxSpeed = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.uart_TX = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.HEXSend = new System.Windows.Forms.CheckBox();
            this.HEXDisplay = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TX_box = new System.Windows.Forms.RichTextBox();
            this.textBox_receive = new System.Windows.Forms.RichTextBox();
            this.PlaceHolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pctime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LedList = new System.Windows.Forms.ImageList(this.components);
            this.LED = new System.Windows.Forms.PictureBox();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.CheckBit = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label20 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tabPageUART.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1419, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.升级ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 升级ToolStripMenuItem
            // 
            this.升级ToolStripMenuItem.Name = "升级ToolStripMenuItem";
            this.升级ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.升级ToolStripMenuItem.Text = "升级";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.关于ToolStripMenuItem.Text = "关于";
           
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmBotAcToolsToolStripMenuItem,
            this.toolStripLoader});
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.作者ToolStripMenuItem.Text = "作者";
            // 
            // dmBotAcToolsToolStripMenuItem
            // 
            this.dmBotAcToolsToolStripMenuItem.Name = "dmBotAcToolsToolStripMenuItem";
            this.dmBotAcToolsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.dmBotAcToolsToolStripMenuItem.Text = "dmBot Ac Tools";
            // 
            // toolStripLoader
            // 
            this.toolStripLoader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripLoader.Name = "toolStripLoader";
            this.toolStripLoader.Size = new System.Drawing.Size(100, 27);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSV,
            this.toolStripTextBoxLoader,
            this.toolStripAPP});
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // toolStripTextBoxSV
            // 
            this.toolStripTextBoxSV.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBoxSV.Name = "toolStripTextBoxSV";
            this.toolStripTextBoxSV.ReadOnly = true;
            this.toolStripTextBoxSV.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxSV.Text = "软件版本";
            // 
            // toolStripTextBoxLoader
            // 
            this.toolStripTextBoxLoader.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripTextBoxLoader.Name = "toolStripTextBoxLoader";
            this.toolStripTextBoxLoader.ReadOnly = true;
            this.toolStripTextBoxLoader.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxLoader.Text = "loader版本";
            // 
            // toolStripAPP
            // 
            this.toolStripAPP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStripAPP.Name = "toolStripAPP";
            this.toolStripAPP.ReadOnly = true;
            this.toolStripAPP.Size = new System.Drawing.Size(100, 27);
            this.toolStripAPP.Text = "APP版本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "帧类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "帧格式";
            // 
            // frameType
            // 
            this.frameType.FormattingEnabled = true;
            this.frameType.Items.AddRange(new object[] {
            "数据帧",
            "远程帧"});
            this.frameType.Location = new System.Drawing.Point(92, 42);
            this.frameType.Margin = new System.Windows.Forms.Padding(4);
            this.frameType.Name = "frameType";
            this.frameType.Size = new System.Drawing.Size(93, 23);
            this.frameType.TabIndex = 18;
            // 
            // frameFormat
            // 
            this.frameFormat.FormattingEnabled = true;
            this.frameFormat.Items.AddRange(new object[] {
            "标准帧",
            "扩展帧"});
            this.frameFormat.Location = new System.Drawing.Point(303, 42);
            this.frameFormat.Margin = new System.Windows.Forms.Padding(4);
            this.frameFormat.Name = "frameFormat";
            this.frameFormat.Size = new System.Drawing.Size(93, 23);
            this.frameFormat.TabIndex = 19;        
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "帧ID(HEX)";
            // 
            // frameId
            // 
            this.frameId.Location = new System.Drawing.Point(15, 86);
            this.frameId.Margin = new System.Windows.Forms.Padding(4);
            this.frameId.Name = "frameId";
            this.frameId.Size = new System.Drawing.Size(81, 25);
            this.frameId.TabIndex = 22;
            this.frameId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "发送数据(HEX)";
            // 
            // sendTimes
            // 
            this.sendTimes.Location = new System.Drawing.Point(91, 168);
            this.sendTimes.Margin = new System.Windows.Forms.Padding(4);
            this.sendTimes.Name = "sendTimes";
            this.sendTimes.Size = new System.Drawing.Size(89, 25);
            this.sendTimes.TabIndex = 26;
            this.sendTimes.TextChanged += new System.EventHandler(this.sendTimes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "发送次数";
            // 
            // sendButton
            // 
            this.sendButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sendButton.Location = new System.Drawing.Point(349, 82);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(71, 29);
            this.sendButton.TabIndex = 27;
            this.sendButton.Text = "发送";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // stopButoon
            // 
            this.stopButoon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopButoon.Location = new System.Drawing.Point(349, 168);
            this.stopButoon.Margin = new System.Windows.Forms.Padding(4);
            this.stopButoon.Name = "stopButoon";
            this.stopButoon.Size = new System.Drawing.Size(71, 29);
            this.stopButoon.TabIndex = 28;
            this.stopButoon.Text = "停止";
            this.stopButoon.UseVisualStyleBackColor = true;
            this.stopButoon.Click += new System.EventHandler(this.stopButoon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "波特率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "发送帧数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "接收帧数：";
            // 
            // sendInterval
            // 
            this.sendInterval.Location = new System.Drawing.Point(257, 168);
            this.sendInterval.Margin = new System.Windows.Forms.Padding(4);
            this.sendInterval.Name = "sendInterval";
            this.sendInterval.Size = new System.Drawing.Size(69, 25);
            this.sendInterval.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "定时发送";
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openButton.Location = new System.Drawing.Point(263, 189);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(108, 29);
            this.openButton.TabIndex = 38;
            this.openButton.Text = "打开";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(381, 664);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 15);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "复位计数";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(273, 664);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 15);
            this.linkLabel2.TabIndex = 41;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "清除数据";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cleanData_LinkClicked);
            // 
            // saveData
            // 
            this.saveData.AutoSize = true;
            this.saveData.Location = new System.Drawing.Point(160, 664);
            this.saveData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(67, 15);
            this.saveData.TabIndex = 42;
            this.saveData.TabStop = true;
            this.saveData.Text = "保存数据";
            this.saveData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveData_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "D0 D1  D2 D3  D4 D5  D6 D7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.frameFormat);
            this.groupBox1.Controls.Add(this.frameType);
            this.groupBox1.Location = new System.Drawing.Point(20, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(439, 80);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "帧格式设置";
            // 
            // canBaudRateButton
            // 
            this.canBaudRateButton.Location = new System.Drawing.Point(349, 44);
            this.canBaudRateButton.Margin = new System.Windows.Forms.Padding(4);
            this.canBaudRateButton.Name = "canBaudRateButton";
            this.canBaudRateButton.Size = new System.Drawing.Size(71, 29);
            this.canBaudRateButton.TabIndex = 31;
            this.canBaudRateButton.Text = "设置";
            this.canBaudRateButton.UseVisualStyleBackColor = true;
            this.canBaudRateButton.Click += new System.EventHandler(this.canBaudRateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.canBaudrateComBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.canBaudRateButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 344);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(439, 79);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "波特率设置";
            // 
            // canBaudrateComBox
            // 
            this.canBaudrateComBox.FormattingEnabled = true;
            this.canBaudrateComBox.Items.AddRange(new object[] {
            "1000",
            "800",
            "666",
            "500",
            "400",
            "250",
            "200",
            "125",
            "100",
            "80",
            "50",
            "40",
            "20",
            "10",
            "5"});
            this.canBaudrateComBox.Location = new System.Drawing.Point(92, 44);
            this.canBaudrateComBox.Margin = new System.Windows.Forms.Padding(4);
            this.canBaudrateComBox.Name = "canBaudrateComBox";
            this.canBaudrateComBox.Size = new System.Drawing.Size(93, 23);
            this.canBaudrateComBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kbps";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataAccCheckBox);
            this.groupBox3.Controls.Add(this.IdAccCheckBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.canData8);
            this.groupBox3.Controls.Add(this.canData7);
            this.groupBox3.Controls.Add(this.canData6);
            this.groupBox3.Controls.Add(this.canData5);
            this.groupBox3.Controls.Add(this.canData4);
            this.groupBox3.Controls.Add(this.canData3);
            this.groupBox3.Controls.Add(this.canData2);
            this.groupBox3.Controls.Add(this.canData1);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.stopButoon);
            this.groupBox3.Controls.Add(this.frameId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sendTimes);
            this.groupBox3.Controls.Add(this.sendInterval);
            this.groupBox3.Location = new System.Drawing.Point(20, 430);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(439, 224);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送";
            // 
            // DataAccCheckBox
            // 
            this.DataAccCheckBox.AutoSize = true;
            this.DataAccCheckBox.Location = new System.Drawing.Point(103, 135);
            this.DataAccCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DataAccCheckBox.Name = "DataAccCheckBox";
            this.DataAccCheckBox.Size = new System.Drawing.Size(91, 19);
            this.DataAccCheckBox.TabIndex = 52;
            this.DataAccCheckBox.Text = "DATA递增";
            this.DataAccCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdAccCheckBox
            // 
            this.IdAccCheckBox.AutoSize = true;
            this.IdAccCheckBox.Location = new System.Drawing.Point(15, 135);
            this.IdAccCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdAccCheckBox.Name = "IdAccCheckBox";
            this.IdAccCheckBox.Size = new System.Drawing.Size(75, 19);
            this.IdAccCheckBox.TabIndex = 51;
            this.IdAccCheckBox.Text = "ID递增";
            this.IdAccCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "ms";
            // 
            // canData8
            // 
            this.canData8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData8.Location = new System.Drawing.Point(289, 86);
            this.canData8.Margin = new System.Windows.Forms.Padding(4);
            this.canData8.MaxLength = 2;
            this.canData8.Name = "canData8";
            this.canData8.Size = new System.Drawing.Size(27, 25);
            this.canData8.TabIndex = 8;
            this.canData8.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData7
            // 
            this.canData7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData7.Location = new System.Drawing.Point(263, 86);
            this.canData7.Margin = new System.Windows.Forms.Padding(4);
            this.canData7.MaxLength = 2;
            this.canData7.Name = "canData7";
            this.canData7.Size = new System.Drawing.Size(27, 25);
            this.canData7.TabIndex = 7;
            this.canData7.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData6
            // 
            this.canData6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData6.Location = new System.Drawing.Point(236, 86);
            this.canData6.Margin = new System.Windows.Forms.Padding(4);
            this.canData6.MaxLength = 2;
            this.canData6.Name = "canData6";
            this.canData6.Size = new System.Drawing.Size(27, 25);
            this.canData6.TabIndex = 6;
            this.canData6.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData5
            // 
            this.canData5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData5.Location = new System.Drawing.Point(209, 86);
            this.canData5.Margin = new System.Windows.Forms.Padding(4);
            this.canData5.MaxLength = 2;
            this.canData5.Name = "canData5";
            this.canData5.Size = new System.Drawing.Size(27, 25);
            this.canData5.TabIndex = 5;
            this.canData5.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData4
            // 
            this.canData4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData4.Location = new System.Drawing.Point(183, 86);
            this.canData4.Margin = new System.Windows.Forms.Padding(4);
            this.canData4.MaxLength = 2;
            this.canData4.Name = "canData4";
            this.canData4.Size = new System.Drawing.Size(27, 25);
            this.canData4.TabIndex = 4;
            this.canData4.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData3
            // 
            this.canData3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData3.Location = new System.Drawing.Point(156, 86);
            this.canData3.Margin = new System.Windows.Forms.Padding(4);
            this.canData3.MaxLength = 2;
            this.canData3.Name = "canData3";
            this.canData3.Size = new System.Drawing.Size(27, 25);
            this.canData3.TabIndex = 3;
            this.canData3.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData2
            // 
            this.canData2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData2.Location = new System.Drawing.Point(129, 86);
            this.canData2.Margin = new System.Windows.Forms.Padding(4);
            this.canData2.MaxLength = 2;
            this.canData2.Name = "canData2";
            this.canData2.Size = new System.Drawing.Size(27, 25);
            this.canData2.TabIndex = 2;
            this.canData2.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // canData1
            // 
            this.canData1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canData1.Location = new System.Drawing.Point(103, 86);
            this.canData1.Margin = new System.Windows.Forms.Padding(4);
            this.canData1.MaxLength = 2;
            this.canData1.Name = "canData1";
            this.canData1.Size = new System.Drawing.Size(27, 25);
            this.canData1.TabIndex = 1;
            this.canData1.TextChanged += new System.EventHandler(this.canData_TextChanged);
            // 
            // acToolsState
            // 
            this.acToolsState.AutoSize = true;
            this.acToolsState.Location = new System.Drawing.Point(60, 664);
            this.acToolsState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acToolsState.Name = "acToolsState";
            this.acToolsState.Size = new System.Drawing.Size(71, 15);
            this.acToolsState.TabIndex = 50;
            this.acToolsState.Text = "V1.0.0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 489);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(198, 490);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 16);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 58;
            this.label12.Text = "串口号：";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(115, 62);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(79, 23);
            this.comboBoxPort.TabIndex = 59;
            // 
            // buttonFresh
            // 
            this.buttonFresh.Location = new System.Drawing.Point(104, 189);
            this.buttonFresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFresh.Name = "buttonFresh";
            this.buttonFresh.Size = new System.Drawing.Size(100, 29);
            this.buttonFresh.TabIndex = 60;
            this.buttonFresh.Text = "刷新设备";
            this.buttonFresh.UseVisualStyleBackColor = true;
            this.buttonFresh.Click += new System.EventHandler(this.buttonFresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCAN);
            this.tabControl1.Controls.Add(this.tabPageUART);
            this.tabControl1.Location = new System.Drawing.Point(473, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 671);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPageCAN
            // 
            this.tabPageCAN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageCAN.Controls.Add(this.label20);
            this.tabPageCAN.Controls.Add(this.CAN_richBox);
            this.tabPageCAN.Controls.Add(this.pictureBox8);
            this.tabPageCAN.Controls.Add(this.pictureBox9);
            this.tabPageCAN.Controls.Add(this.pictureBox10);
            this.tabPageCAN.Controls.Add(this.busSpeed);
            this.tabPageCAN.Controls.Add(this.upload);
            this.tabPageCAN.Controls.Add(this.download);
            this.tabPageCAN.Controls.Add(this.receiveCount);
            this.tabPageCAN.Controls.Add(this.sendCount);
            this.tabPageCAN.Controls.Add(this.label25);
            this.tabPageCAN.Controls.Add(this.label26);
            this.tabPageCAN.Controls.Add(this.progressBar1);
            this.tabPageCAN.Location = new System.Drawing.Point(4, 25);
            this.tabPageCAN.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCAN.Name = "tabPageCAN";
            this.tabPageCAN.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCAN.Size = new System.Drawing.Size(921, 642);
            this.tabPageCAN.TabIndex = 0;
            this.tabPageCAN.Text = "CAN";
            // 
            // CAN_richBox
            // 
            this.CAN_richBox.HideSelection = false;
            this.CAN_richBox.Location = new System.Drawing.Point(0, 38);
            this.CAN_richBox.Margin = new System.Windows.Forms.Padding(4);
            this.CAN_richBox.Name = "CAN_richBox";
            this.CAN_richBox.Size = new System.Drawing.Size(921, 566);
            this.CAN_richBox.TabIndex = 69;
            this.CAN_richBox.Text = "";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(268, 612);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 20);
            this.pictureBox8.TabIndex = 67;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(143, 612);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 20);
            this.pictureBox9.TabIndex = 66;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(27, 612);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 20);
            this.pictureBox10.TabIndex = 65;
            this.pictureBox10.TabStop = false;
            // 
            // busSpeed
            // 
            this.busSpeed.AutoSize = true;
            this.busSpeed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.busSpeed.Location = new System.Drawing.Point(380, 615);
            this.busSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.busSpeed.Name = "busSpeed";
            this.busSpeed.Size = new System.Drawing.Size(23, 15);
            this.busSpeed.TabIndex = 64;
            this.busSpeed.Text = "0%";
            // 
            // upload
            // 
            this.upload.AutoSize = true;
            this.upload.Location = new System.Drawing.Point(169, 615);
            this.upload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(47, 15);
            this.upload.TabIndex = 63;
            this.upload.Text = "0 FPS";
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.Location = new System.Drawing.Point(53, 615);
            this.download.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(47, 15);
            this.download.TabIndex = 62;
            this.download.Text = "0 FPS";
            // 
            // receiveCount
            // 
            this.receiveCount.AutoSize = true;
            this.receiveCount.Location = new System.Drawing.Point(771, 615);
            this.receiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receiveCount.Name = "receiveCount";
            this.receiveCount.Size = new System.Drawing.Size(15, 15);
            this.receiveCount.TabIndex = 61;
            this.receiveCount.Text = "0";
            // 
            // sendCount
            // 
            this.sendCount.AutoSize = true;
            this.sendCount.Location = new System.Drawing.Point(579, 615);
            this.sendCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sendCount.Name = "sendCount";
            this.sendCount.Size = new System.Drawing.Size(15, 15);
            this.sendCount.TabIndex = 60;
            this.sendCount.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(691, 615);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 15);
            this.label25.TabIndex = 59;
            this.label25.Text = "接收帧数：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(499, 615);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 15);
            this.label26.TabIndex = 58;
            this.label26.Text = "发送帧数：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(321, 614);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 18);
            this.progressBar1.TabIndex = 68;
            // 
            // tabPageUART
            // 
            this.tabPageUART.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUART.Controls.Add(this.label_RX);
            this.tabPageUART.Controls.Add(this.label16);
            this.tabPageUART.Controls.Add(this.label_TX);
            this.tabPageUART.Controls.Add(this.label14);
            this.tabPageUART.Controls.Add(this.busRxSpeed);
            this.tabPageUART.Controls.Add(this.pictureBox6);
            this.tabPageUART.Controls.Add(this.progressBar3);
            this.tabPageUART.Controls.Add(this.uart_RX);
            this.tabPageUART.Controls.Add(this.pictureBox7);
            this.tabPageUART.Controls.Add(this.busTxSpeed);
            this.tabPageUART.Controls.Add(this.pictureBox5);
            this.tabPageUART.Controls.Add(this.progressBar2);
            this.tabPageUART.Controls.Add(this.uart_TX);
            this.tabPageUART.Controls.Add(this.pictureBox4);
            this.tabPageUART.Controls.Add(this.HEXSend);
            this.tabPageUART.Controls.Add(this.HEXDisplay);
            this.tabPageUART.Controls.Add(this.button1);
            this.tabPageUART.Controls.Add(this.TX_box);
            this.tabPageUART.Controls.Add(this.textBox_receive);
            this.tabPageUART.Location = new System.Drawing.Point(4, 25);
            this.tabPageUART.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUART.Name = "tabPageUART";
            this.tabPageUART.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUART.Size = new System.Drawing.Size(921, 642);
            this.tabPageUART.TabIndex = 1;
            this.tabPageUART.Text = "Uart";
            // 
            // label_RX
            // 
            this.label_RX.AutoSize = true;
            this.label_RX.Location = new System.Drawing.Point(833, 615);
            this.label_RX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RX.Name = "label_RX";
            this.label_RX.Size = new System.Drawing.Size(15, 15);
            this.label_RX.TabIndex = 20;
            this.label_RX.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(789, 615);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "接收:";
            // 
            // label_TX
            // 
            this.label_TX.AutoSize = true;
            this.label_TX.Location = new System.Drawing.Point(709, 615);
            this.label_TX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TX.Name = "label_TX";
            this.label_TX.Size = new System.Drawing.Size(15, 15);
            this.label_TX.TabIndex = 18;
            this.label_TX.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(665, 615);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "发送:";
            // 
            // busRxSpeed
            // 
            this.busRxSpeed.AutoSize = true;
            this.busRxSpeed.Location = new System.Drawing.Point(529, 615);
            this.busRxSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.busRxSpeed.Name = "busRxSpeed";
            this.busRxSpeed.Size = new System.Drawing.Size(23, 15);
            this.busRxSpeed.TabIndex = 16;
            this.busRxSpeed.Text = "0%";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(449, 612);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 20);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(481, 612);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(133, 20);
            this.progressBar3.TabIndex = 14;
            // 
            // uart_RX
            // 
            this.uart_RX.AutoSize = true;
            this.uart_RX.Location = new System.Drawing.Point(361, 615);
            this.uart_RX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uart_RX.Name = "uart_RX";
            this.uart_RX.Size = new System.Drawing.Size(47, 15);
            this.uart_RX.TabIndex = 13;
            this.uart_RX.Text = "0 bps";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(348, 612);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // busTxSpeed
            // 
            this.busTxSpeed.AutoSize = true;
            this.busTxSpeed.Location = new System.Drawing.Point(211, 615);
            this.busTxSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.busTxSpeed.Name = "busTxSpeed";
            this.busTxSpeed.Size = new System.Drawing.Size(23, 15);
            this.busTxSpeed.TabIndex = 11;
            this.busTxSpeed.Text = "0%";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(127, 612);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 20);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(159, 612);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(133, 20);
            this.progressBar2.TabIndex = 9;
            // 
            // uart_TX
            // 
            this.uart_TX.AutoSize = true;
            this.uart_TX.Location = new System.Drawing.Point(39, 615);
            this.uart_TX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uart_TX.Name = "uart_TX";
            this.uart_TX.Size = new System.Drawing.Size(47, 15);
            this.uart_TX.TabIndex = 8;
            this.uart_TX.Text = "0 bps";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(25, 612);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // HEXSend
            // 
            this.HEXSend.AutoSize = true;
            this.HEXSend.Location = new System.Drawing.Point(788, 571);
            this.HEXSend.Margin = new System.Windows.Forms.Padding(4);
            this.HEXSend.Name = "HEXSend";
            this.HEXSend.Size = new System.Drawing.Size(83, 19);
            this.HEXSend.TabIndex = 6;
            this.HEXSend.Text = "HEX发送";
            this.HEXSend.UseVisualStyleBackColor = true;
            // 
            // HEXDisplay
            // 
            this.HEXDisplay.AutoSize = true;
            this.HEXDisplay.Location = new System.Drawing.Point(788, 532);
            this.HEXDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.HEXDisplay.Name = "HEXDisplay";
            this.HEXDisplay.Size = new System.Drawing.Size(83, 19);
            this.HEXDisplay.TabIndex = 5;
            this.HEXDisplay.Text = "HEX显示";
            this.HEXDisplay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TX_box
            // 
            this.TX_box.Location = new System.Drawing.Point(8, 456);
            this.TX_box.Margin = new System.Windows.Forms.Padding(4);
            this.TX_box.Name = "TX_box";
            this.TX_box.Size = new System.Drawing.Size(759, 146);
            this.TX_box.TabIndex = 1;
            this.TX_box.Text = "";
            // 
            // textBox_receive
            // 
            this.textBox_receive.HideSelection = false;
            this.textBox_receive.Location = new System.Drawing.Point(8, 8);
            this.textBox_receive.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.Size = new System.Drawing.Size(901, 440);
            this.textBox_receive.TabIndex = 0;
            this.textBox_receive.Text = "";
            // 
            // PlaceHolder
            // 
            this.PlaceHolder.Width = 0;
            // 
            // Index
            // 
            this.Index.Text = "序号";
            this.Index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Index.Width = 53;
            // 
            // pctime
            // 
            this.pctime.Text = "时间戳";
            this.pctime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pctime.Width = 120;
            // 
            // ID_Type
            // 
            this.ID_Type.Text = "帧类型";
            this.ID_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_Format
            // 
            this.ID_Format.Text = "帧格式";
            this.ID_Format.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // State
            // 
            this.State.Text = "状态";
            this.State.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Data_length
            // 
            this.Data_length.Text = "数据长度";
            this.Data_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DATA
            // 
            this.DATA.Text = " 数据(D0 - D7)";
            this.DATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DATA.Width = 180;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LedList
            // 
            this.LedList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LedList.ImageStream")));
            this.LedList.TransparentColor = System.Drawing.Color.Transparent;
            this.LedList.Images.SetKeyName(0, "led_white16.png");
            this.LedList.Images.SetKeyName(1, "green.ico");
            this.LedList.Images.SetKeyName(2, "red.ico");
            // 
            // LED
            // 
            this.LED.Location = new System.Drawing.Point(20, 664);
            this.LED.Margin = new System.Windows.Forms.Padding(4);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(21, 20);
            this.LED.TabIndex = 62;
            this.LED.TabStop = false;
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "460800",
            "921600",
            "自定义输入"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(115, 100);
            this.comboBoxBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(79, 23);
            this.comboBoxBaudrate.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 63;
            this.label15.Text = "波特率：";
            // 
            // DataBit
            // 
            this.DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Items.AddRange(new object[] {
            "8",
            "9"});
            this.DataBit.Location = new System.Drawing.Point(115, 138);
            this.DataBit.Margin = new System.Windows.Forms.Padding(4);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(79, 23);
            this.DataBit.TabIndex = 66;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 141);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 65;
            this.label17.Text = "数据位：";
            // 
            // StopBit
            // 
            this.StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.StopBit.Location = new System.Drawing.Point(309, 100);
            this.StopBit.Margin = new System.Windows.Forms.Padding(4);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(79, 23);
            this.StopBit.TabIndex = 69;
            // 
            // CheckBit
            // 
            this.CheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckBit.FormattingEnabled = true;
            this.CheckBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.CheckBit.Location = new System.Drawing.Point(309, 62);
            this.CheckBit.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBit.Name = "CheckBit";
            this.CheckBit.Size = new System.Drawing.Size(79, 23);
            this.CheckBit.TabIndex = 70;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(227, 104);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 67;
            this.label18.Text = "停止位：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(227, 66);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 68;
            this.label19.Text = "校验位：";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "序号";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "时间戳";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "帧类型";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "帧格式";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "数据长度";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = " 数据(D0 - D7)";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 180;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(24, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(763, 15);
            this.label20.TabIndex = 70;
            this.label20.Text = "    序号      时间间隔      帧类型  帧格式  状态    帧长            数据              ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1419, 701);
            this.Controls.Add(this.StopBit);
            this.Controls.Add(this.CheckBit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.DataBit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxBaudrate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LED);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonFresh);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.acToolsState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "USB2CAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCAN.ResumeLayout(false);
            this.tabPageCAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tabPageUART.ResumeLayout(false);
            this.tabPageUART.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NoFlashListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox frameType;
        private System.Windows.Forms.ComboBox frameFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox frameId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sendTimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button stopButoon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sendInterval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel saveData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 升级ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader PlaceHolder;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ID_Type;
        private System.Windows.Forms.ColumnHeader ID_Format;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Data_length;
        private System.Windows.Forms.ColumnHeader DATA;
        private System.Windows.Forms.Button canBaudRateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox canData8;
        private System.Windows.Forms.TextBox canData7;
        private System.Windows.Forms.TextBox canData6;
        private System.Windows.Forms.TextBox canData5;
        private System.Windows.Forms.TextBox canData4;
        private System.Windows.Forms.TextBox canData3;
        private System.Windows.Forms.TextBox canData2;
        private System.Windows.Forms.TextBox canData1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label acToolsState;


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.ComboBox canBaudrateComBox;
        private System.Windows.Forms.CheckBox DataAccCheckBox;
        private System.Windows.Forms.CheckBox IdAccCheckBox;
        private System.Windows.Forms.ColumnHeader pctime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonFresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCAN;
        private System.Windows.Forms.TabPage tabPageUART;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TX_box;
        private System.Windows.Forms.RichTextBox textBox_receive;
        private System.Windows.Forms.CheckBox HEXSend;
        private System.Windows.Forms.CheckBox HEXDisplay;
        private System.Windows.Forms.ImageList LedList;
        private System.Windows.Forms.PictureBox LED;
        private System.Windows.Forms.Label busTxSpeed;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label uart_TX;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label uart_RX;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label_RX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_TX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label busRxSpeed;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox CheckBit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label busSpeed;
        private System.Windows.Forms.Label upload;
        private System.Windows.Forms.Label download;
        private System.Windows.Forms.Label receiveCount;
        private System.Windows.Forms.Label sendCount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dmBotAcToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripLoader;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSV;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLoader;
        private System.Windows.Forms.ToolStripTextBox toolStripAPP;
        private System.Windows.Forms.RichTextBox CAN_richBox;
        private System.Windows.Forms.Label label20;
    }
}

