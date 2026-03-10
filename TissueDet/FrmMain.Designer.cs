namespace TissueDet
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new Sunny.UI.UIPanel();
            this.btnAddbrand = new Sunny.UI.UISymbolButton();
            this.btnSol = new Sunny.UI.UISymbolButton();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnMax = new Sunny.UI.UISymbolButton();
            this.btnMin = new Sunny.UI.UISymbolButton();
            this.SolComboBox = new Sunny.UI.UIComboBox();
            this.btnSetting = new Sunny.UI.UISymbolButton();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.lblDate = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.btnStart = new Sunny.UI.UISymbolButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiLine5 = new Sunny.UI.UILine();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLine6 = new Sunny.UI.UILine();
            this.devCountBarChart = new Sunny.UI.UIBarChart();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.rpDevBreadDown = new Sunny.UI.UIRoundProcess();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.MPanel = new ImageControl.ViewPanel();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.logView1 = new VisionCore.Component.LogView();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.Timer1 = new Sunny.UI.UIMillisecondTimer(this.components);
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtSpeed = new Sunny.UI.UINumPadTextBox();
            this.btnSpeedSet = new Sunny.UI.UISymbolButton();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.panelTop.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.btnAddbrand);
            this.panelTop.Controls.Add(this.btnSol);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.SolComboBox);
            this.panelTop.Controls.Add(this.btnSetting);
            this.panelTop.Controls.Add(this.uiLabel10);
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.uiLabel8);
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelTop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelTop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.panelTop.RectColor = System.Drawing.Color.DarkSlateGray;
            this.panelTop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.panelTop.Size = new System.Drawing.Size(1533, 56);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnAddbrand
            // 
            this.btnAddbrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddbrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnAddbrand.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnAddbrand.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnAddbrand.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnAddbrand.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddbrand.Location = new System.Drawing.Point(209, 14);
            this.btnAddbrand.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddbrand.Name = "btnAddbrand";
            this.btnAddbrand.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnAddbrand.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnAddbrand.Size = new System.Drawing.Size(30, 30);
            this.btnAddbrand.Symbol = 557669;
            this.btnAddbrand.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddbrand.SymbolPressColor = System.Drawing.Color.Green;
            this.btnAddbrand.SymbolSize = 30;
            this.btnAddbrand.TabIndex = 8;
            this.btnAddbrand.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddbrand.Click += new System.EventHandler(this.btnAddbrand_Click);
            // 
            // btnSol
            // 
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSol.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSol.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSol.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSol.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSol.Location = new System.Drawing.Point(250, 14);
            this.btnSol.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSol.Name = "btnSol";
            this.btnSol.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnSol.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnSol.Size = new System.Drawing.Size(30, 30);
            this.btnSol.Symbol = 561277;
            this.btnSol.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSol.SymbolPressColor = System.Drawing.Color.Green;
            this.btnSol.SymbolSize = 30;
            this.btnSol.TabIndex = 7;
            this.btnSol.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnClose.FillHoverColor = System.Drawing.Color.Red;
            this.btnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(1494, 5);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnClose.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.Symbol = 558829;
            this.btnClose.SymbolSize = 20;
            this.btnClose.TabIndex = 1;
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnMax.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.btnMax.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.btnMax.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMax.Location = new System.Drawing.Point(1458, 5);
            this.btnMax.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnMax.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.Symbol = 261640;
            this.btnMax.SymbolSize = 20;
            this.btnMax.TabIndex = 1;
            this.btnMax.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnMin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.btnMin.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(101)))));
            this.btnMin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMin.Location = new System.Drawing.Point(1422, 5);
            this.btnMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnMin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.Symbol = 361544;
            this.btnMin.SymbolSize = 20;
            this.btnMin.TabIndex = 1;
            this.btnMin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // SolComboBox
            // 
            this.SolComboBox.DataSource = null;
            this.SolComboBox.DropDownAutoWidth = true;
            this.SolComboBox.FillColor = System.Drawing.Color.White;
            this.SolComboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SolComboBox.ItemHoverColor = System.Drawing.Color.LightGray;
            this.SolComboBox.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SolComboBox.Items.AddRange(new object[] {
            "05-01机",
            "05-02机"});
            this.SolComboBox.ItemSelectBackColor = System.Drawing.Color.DarkSlateGray;
            this.SolComboBox.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SolComboBox.Location = new System.Drawing.Point(68, 13);
            this.SolComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SolComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.SolComboBox.Name = "SolComboBox";
            this.SolComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.SolComboBox.RectColor = System.Drawing.Color.DarkSlateGray;
            this.SolComboBox.Size = new System.Drawing.Size(135, 29);
            this.SolComboBox.SymbolSize = 24;
            this.SolComboBox.TabIndex = 6;
            this.SolComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SolComboBox.Watermark = "";
            this.SolComboBox.SelectedIndexChanged += new System.EventHandler(this.SolComboBox_SelectedIndexChanged);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSetting.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSetting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSetting.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSetting.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(1333, 11);
            this.btnSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnSetting.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnSetting.Size = new System.Drawing.Size(35, 35);
            this.btnSetting.Symbol = 61459;
            this.btnSetting.SymbolColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.SymbolHoverColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSetting.SymbolSize = 35;
            this.btnSetting.TabIndex = 1;
            this.btnSetting.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiLabel10.Location = new System.Drawing.Point(462, 5);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(448, 39);
            this.uiLabel10.TabIndex = 0;
            this.uiLabel10.Text = "抽纸在线检测";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.uiLabel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.uiLabel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1133, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(154, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "2024-10-15    10:16:20";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.White;
            this.uiLabel8.Location = new System.Drawing.Point(6, 17);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(63, 22);
            this.uiLabel8.TabIndex = 0;
            this.uiLabel8.Text = "品牌 ：";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStart.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(26, 776);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnStart.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnStart.Size = new System.Drawing.Size(114, 49);
            this.btnStart.Symbol = 61515;
            this.btnStart.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.SymbolHoverColor = System.Drawing.Color.Green;
            this.btnStart.SymbolPressColor = System.Drawing.Color.Green;
            this.btnStart.SymbolSize = 30;
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "  启动";
            this.btnStart.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel2.Location = new System.Drawing.Point(27, 73);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(56, 17);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "缺陷统计";
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.LineCapSize = 4;
            this.uiLine1.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine1.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine1.LineColorGradient = true;
            this.uiLine1.LineSize = 3;
            this.uiLine1.Location = new System.Drawing.Point(12, 90);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(320, 24);
            this.uiLine1.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine1.TabIndex = 2;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel3.Location = new System.Drawing.Point(27, 352);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(56, 17);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "生产统计";
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.LineCapSize = 4;
            this.uiLine2.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine2.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine2.LineColorGradient = true;
            this.uiLine2.LineSize = 3;
            this.uiLine2.Location = new System.Drawing.Point(12, 369);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(320, 24);
            this.uiLine2.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine2.TabIndex = 2;
            // 
            // uiLine3
            // 
            this.uiLine3.BackColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine3.LineCapSize = 4;
            this.uiLine3.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine3.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine3.LineColorGradient = true;
            this.uiLine3.LineSize = 3;
            this.uiLine3.Location = new System.Drawing.Point(12, 607);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(320, 24);
            this.uiLine3.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine3.TabIndex = 2;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel5.Location = new System.Drawing.Point(1261, 70);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(56, 17);
            this.uiLabel5.TabIndex = 1;
            this.uiLabel5.Text = "运行参数";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel6.Location = new System.Drawing.Point(1261, 430);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(0, 17);
            this.uiLabel6.TabIndex = 1;
            // 
            // uiLine4
            // 
            this.uiLine4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLine4.BackColor = System.Drawing.Color.Transparent;
            this.uiLine4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine4.LineCapSize = 4;
            this.uiLine4.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine4.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine4.LineColorGradient = true;
            this.uiLine4.LineSize = 3;
            this.uiLine4.Location = new System.Drawing.Point(1264, 90);
            this.uiLine4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(271, 24);
            this.uiLine4.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine4.TabIndex = 2;
            // 
            // uiLine5
            // 
            this.uiLine5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLine5.BackColor = System.Drawing.Color.Transparent;
            this.uiLine5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine5.LineCapSize = 4;
            this.uiLine5.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine5.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine5.LineColorGradient = true;
            this.uiLine5.LineSize = 3;
            this.uiLine5.Location = new System.Drawing.Point(1264, 450);
            this.uiLine5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(262, 24);
            this.uiLine5.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine5.TabIndex = 2;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel7.Location = new System.Drawing.Point(365, 647);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(84, 17);
            this.uiLabel7.TabIndex = 1;
            this.uiLabel7.Text = "设备使用情况 ";
            // 
            // uiLine6
            // 
            this.uiLine6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLine6.BackColor = System.Drawing.Color.Transparent;
            this.uiLine6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine6.LineCapSize = 4;
            this.uiLine6.LineColor = System.Drawing.Color.SteelBlue;
            this.uiLine6.LineColor2 = System.Drawing.Color.Gray;
            this.uiLine6.LineColorGradient = true;
            this.uiLine6.LineSize = 3;
            this.uiLine6.Location = new System.Drawing.Point(356, 663);
            this.uiLine6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine6.Name = "uiLine6";
            this.uiLine6.Size = new System.Drawing.Size(905, 24);
            this.uiLine6.StartCap = Sunny.UI.UILineCap.Square;
            this.uiLine6.TabIndex = 2;
            // 
            // devCountBarChart
            // 
            this.devCountBarChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.devCountBarChart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devCountBarChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.devCountBarChart.LegendFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devCountBarChart.Location = new System.Drawing.Point(12, 120);
            this.devCountBarChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.devCountBarChart.Name = "devCountBarChart";
            this.devCountBarChart.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.devCountBarChart.RectColor = System.Drawing.Color.Gray;
            this.devCountBarChart.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.devCountBarChart.Size = new System.Drawing.Size(320, 213);
            this.devCountBarChart.SubFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.devCountBarChart.TabIndex = 4;
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel11.Location = new System.Drawing.Point(230, 534);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(51, 19);
            this.uiLabel11.TabIndex = 1;
            this.uiLabel11.Text = "合格率";
            // 
            // rpDevBreadDown
            // 
            this.rpDevBreadDown.DecimalPlaces = 0;
            this.rpDevBreadDown.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rpDevBreadDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rpDevBreadDown.ForeColor2 = System.Drawing.Color.Black;
            this.rpDevBreadDown.Inner = 35;
            this.rpDevBreadDown.Location = new System.Drawing.Point(197, 403);
            this.rpDevBreadDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.rpDevBreadDown.Name = "rpDevBreadDown";
            this.rpDevBreadDown.ProcessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rpDevBreadDown.ProcessColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rpDevBreadDown.ShowProcess = true;
            this.rpDevBreadDown.Size = new System.Drawing.Size(120, 120);
            this.rpDevBreadDown.Style = Sunny.UI.UIStyle.Custom;
            this.rpDevBreadDown.TabIndex = 5;
            this.rpDevBreadDown.Text = "25%";
            this.rpDevBreadDown.Value = 25;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.Controls.Add(this.MPanel);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(356, 68);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(898, 558);
            this.uiPanel1.TabIndex = 18;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MPanel
            // 
            this.MPanel.AutoSize = true;
            this.MPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPanel.Location = new System.Drawing.Point(0, 0);
            this.MPanel.Margin = new System.Windows.Forms.Padding(87, 87, 87, 87);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(898, 558);
            this.MPanel.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(176, 775);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnStop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnStop.Size = new System.Drawing.Size(114, 49);
            this.btnStop.Symbol = 61517;
            this.btnStop.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.SymbolHoverColor = System.Drawing.Color.Maroon;
            this.btnStop.SymbolPressColor = System.Drawing.Color.Maroon;
            this.btnStop.SymbolSize = 30;
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "  停止";
            this.btnStop.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // logView1
            // 
            this.logView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logView1.Location = new System.Drawing.Point(0, 0);
            this.logView1.Margin = new System.Windows.Forms.Padding(2);
            this.logView1.Name = "logView1";
            this.logView1.Size = new System.Drawing.Size(905, 155);
            this.logView1.TabIndex = 20;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel2.Controls.Add(this.logView1);
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(356, 695);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(905, 155);
            this.uiPanel2.TabIndex = 20;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 200;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.uiLabel4.Location = new System.Drawing.Point(1269, 124);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(51, 19);
            this.uiLabel4.TabIndex = 21;
            this.uiLabel4.Text = "速度：";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpeed.FillColor = System.Drawing.Color.White;
            this.txtSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSpeed.Location = new System.Drawing.Point(1324, 119);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpeed.MinimumSize = new System.Drawing.Size(63, 0);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txtSpeed.Size = new System.Drawing.Size(105, 26);
            this.txtSpeed.SymbolSize = 24;
            this.txtSpeed.TabIndex = 22;
            this.txtSpeed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSpeed.Watermark = "";
            // 
            // btnSpeedSet
            // 
            this.btnSpeedSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeedSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSpeedSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeedSet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSpeedSet.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSpeedSet.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSpeedSet.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSpeedSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSpeedSet.Location = new System.Drawing.Point(1453, 121);
            this.btnSpeedSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSpeedSet.Name = "btnSpeedSet";
            this.btnSpeedSet.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btnSpeedSet.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btnSpeedSet.Size = new System.Drawing.Size(58, 24);
            this.btnSpeedSet.Symbol = 61452;
            this.btnSpeedSet.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSpeedSet.SymbolPressColor = System.Drawing.Color.Green;
            this.btnSpeedSet.SymbolSize = 20;
            this.btnSpeedSet.TabIndex = 23;
            this.btnSpeedSet.Text = "设置";
            this.btnSpeedSet.TipsFont = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSpeedSet.Click += new System.EventHandler(this.btnSpeedSet_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel9.Location = new System.Drawing.Point(5, 450);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(69, 26);
            this.uiLabel9.TabIndex = 24;
            this.uiLabel9.Text = "产量：";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.ForeColor = System.Drawing.Color.Silver;
            this.uiLabel12.Location = new System.Drawing.Point(5, 519);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(69, 26);
            this.uiLabel12.TabIndex = 25;
            this.uiLabel12.Text = "剔除：";
            // 
            // FrmMain
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.CloseAskString = "确定退出？";
            this.ControlBox = false;
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.btnSpeedSet);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rpDevBreadDown);
            this.Controls.Add(this.devCountBarChart);
            this.Controls.Add(this.uiLine6);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine5);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine4);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.ShowIcon = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Form1";
            this.TitleHeight = 50;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1405, 709);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UILine uiLine5;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILine uiLine6;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel lblDate;
        private Sunny.UI.UISymbolButton btnStart;
        private Sunny.UI.UISymbolButton btnSetting;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnMax;
        private Sunny.UI.UISymbolButton btnMin;
        private Sunny.UI.UIBarChart devCountBarChart;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIRoundProcess rpDevBreadDown;
        private Sunny.UI.UIComboBox SolComboBox;
        private Sunny.UI.UIPanel uiPanel1;
        private ImageControl.ViewPanel MPanel;
        private Sunny.UI.UISymbolButton btnStop;
        private Sunny.UI.UISymbolButton btnSol;
        private VisionCore.Component.LogView logView1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnAddbrand;
        private Sunny.UI.UIMillisecondTimer Timer1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UINumPadTextBox txtSpeed;
        private Sunny.UI.UISymbolButton btnSpeedSet;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel12;
    }
}

