using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using VisionCore.Ext;

namespace TissueDet
{
    public class FrmStatisticsDashboard : UIForm
    {
        private const string OkKey = "ok";
        private const string NgKey = "ng";
        private static readonly string[] DefectKeys = { "vs1", "vs2", "vs3", "vs4", "vs5" };

        private readonly Timer refreshTimer;
        private readonly UILabel lblTimeValue;
        private readonly UIDigitalLabel lblTotalValue;
        private readonly UIDigitalLabel lblOkValue;
        private readonly UIDigitalLabel lblNgValue;
        private readonly UIRoundProcess rpPassRate;
        private readonly UIBarChart chartNgCount;
        private readonly UIBarChart chartNgRate;
        private readonly UIBarOption ngCountOption;
        private readonly UIBarOption ngRateOption;
        private readonly DataGridView dgvDetail;

        public FrmStatisticsDashboard()
        {
            Text = "统计大屏";
            ShowTitle = false;
            AllowShowTitle = false;
            ControlBox = false;
            ShowIcon = false;
            Padding = Padding.Empty;
            Style = UIStyle.Custom;
            BackColor = Color.FromArgb(17, 24, 39);
            RectColor = Color.FromArgb(17, 24, 39);
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(1400, 850);
            ClientSize = new Size(1600, 900);
            WindowState = FormWindowState.Maximized;

            var headerPanel = new UIPanel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.FillColor = Color.FromArgb(14, 30, 40);
            headerPanel.FillColor2 = Color.FromArgb(14, 30, 50);
            headerPanel.RectColor = Color.DarkSlateGray;
            headerPanel.RadiusSides = UICornerRadiusSides.None;
            headerPanel.Text = null;
            Controls.Add(headerPanel);

            var lblTitle = new UILabel();
            lblTitle.Text = "抽纸在线检测 - 统计大屏";
            lblTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);
            headerPanel.Controls.Add(lblTitle);

            lblTimeValue = new UILabel();
            lblTimeValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimeValue.AutoSize = true;
            lblTimeValue.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTimeValue.ForeColor = Color.White;
            lblTimeValue.Location = new Point(1220, 20);
            headerPanel.Controls.Add(lblTimeValue);

            var btnClose = new UISymbolButton();
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FillColor = Color.FromArgb(14, 30, 40);
            btnClose.FillHoverColor = Color.Red;
            btnClose.FillPressColor = Color.Maroon;
            btnClose.FillSelectedColor = Color.FromArgb(14, 30, 40);
            btnClose.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnClose.Location = new Point(1500, 12);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.RadiusSides = UICornerRadiusSides.None;
            btnClose.RectSides = ToolStripStatusLabelBorderSides.None;
            btnClose.Size = new Size(80, 34);
            btnClose.Symbol = 61453;
            btnClose.SymbolSize = 18;
            btnClose.Text = "关闭";
            btnClose.Click += delegate { Close(); };
            headerPanel.Controls.Add(btnClose);

            Controls.Add(CreateStatCard("总检测", new Point(20, 80), new Size(290, 120), Color.DeepSkyBlue, out lblTotalValue));
            Controls.Add(CreateStatCard("OK总数", new Point(330, 80), new Size(290, 120), Color.LimeGreen, out lblOkValue));
            Controls.Add(CreateStatCard("NG总数", new Point(640, 80), new Size(290, 120), Color.OrangeRed, out lblNgValue));

            var passRatePanel = new UIPanel();
            passRatePanel.Location = new Point(950, 80);
            passRatePanel.Size = new Size(630, 120);
            passRatePanel.FillColor = Color.FromArgb(28, 38, 54);
            passRatePanel.RectColor = Color.FromArgb(46, 77, 102);
            passRatePanel.Style = UIStyle.Custom;
            passRatePanel.Text = null;
            Controls.Add(passRatePanel);

            var lblPassTitle = new UILabel();
            lblPassTitle.Text = "实时合格率";
            lblPassTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblPassTitle.ForeColor = Color.WhiteSmoke;
            lblPassTitle.AutoSize = true;
            lblPassTitle.Location = new Point(20, 15);
            passRatePanel.Controls.Add(lblPassTitle);

            var lblPassHint = new UILabel();
            lblPassHint.Text = "根据 OK / (OK + NG) 实时计算";
            lblPassHint.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblPassHint.ForeColor = Color.Silver;
            lblPassHint.AutoSize = true;
            lblPassHint.Location = new Point(20, 52);
            passRatePanel.Controls.Add(lblPassHint);

            rpPassRate = new UIRoundProcess();
            rpPassRate.DecimalPlaces = 0;
            rpPassRate.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rpPassRate.ForeColor = Color.FromArgb(0, 220, 130);
            rpPassRate.ForeColor2 = Color.Black;
            rpPassRate.Inner = 40;
            rpPassRate.Location = new Point(460, 5);
            rpPassRate.MinimumSize = new Size(1, 1);
            rpPassRate.ProcessBackColor = Color.FromArgb(50, 60, 70);
            rpPassRate.ProcessColor = Color.FromArgb(0, 200, 120);
            rpPassRate.ShowProcess = true;
            rpPassRate.Size = new Size(110, 110);
            rpPassRate.Style = UIStyle.Custom;
            rpPassRate.Text = "0%";
            rpPassRate.Value = 0;
            passRatePanel.Controls.Add(rpPassRate);

            var lblChart1 = CreateSectionTitle("NG缺陷数量分布", new Point(20, 215));
            Controls.Add(lblChart1);
            chartNgCount = CreateBarChart(new Point(20, 245), new Size(760, 250));
            Controls.Add(chartNgCount);

            var lblChart2 = CreateSectionTitle("NG缺陷占比分析", new Point(800, 215));
            Controls.Add(lblChart2);
            chartNgRate = CreateBarChart(new Point(800, 245), new Size(780, 250));
            Controls.Add(chartNgRate);

            var lblGridTitle = CreateSectionTitle("NG缺陷明细表", new Point(20, 515));
            Controls.Add(lblGridTitle);
            dgvDetail = CreateGrid(new Point(20, 545), new Size(1560, 305));
            Controls.Add(dgvDetail);

            ngCountOption = CreateChartOption("NG数量", "缺陷项", "数量", false);
            var ngCountSeries = new UIBarSeries();
            ngCountSeries.Name = "NG数量";
            ngCountSeries.MaxWidth = 32;
            ngCountSeries.DecimalPlaces = 0;
            for (int i = 0; i < DefectKeys.Length; i++)
            {
                ngCountSeries.AddData(0);
                ngCountOption.XAxis.Data.Add(DefectKeys[i].ToUpperInvariant());
            }
            ngCountOption.Series.Add(ngCountSeries);
            chartNgCount.SetOption(ngCountOption);

            ngRateOption = CreateChartOption("占比(%)", "缺陷项", "占比%", true);
            var ngRateSeries = new UIBarSeries();
            ngRateSeries.Name = "占比(%)";
            ngRateSeries.MaxWidth = 32;
            ngRateSeries.DecimalPlaces = 2;
            for (int i = 0; i < DefectKeys.Length; i++)
            {
                ngRateSeries.AddData(0);
                ngRateOption.XAxis.Data.Add(DefectKeys[i].ToUpperInvariant());
            }
            ngRateOption.Series.Add(ngRateSeries);
            chartNgRate.SetOption(ngRateOption);

            refreshTimer = new Timer();
            refreshTimer.Interval = 1000;
            refreshTimer.Tick += delegate
            {
                RefreshDashboard();
            };
            refreshTimer.Start();

            RefreshDashboard();
        }

        private UIPanel CreateStatCard(string title, Point location, Size size, Color titleColor, out UIDigitalLabel valueLabel)
        {
            var panel = new UIPanel();
            panel.Location = location;
            panel.Size = size;
            panel.FillColor = Color.FromArgb(28, 38, 54);
            panel.RectColor = Color.FromArgb(46, 77, 102);
            panel.Style = UIStyle.Custom;
            panel.Text = null;

            var titleLabel = new UILabel();
            titleLabel.Text = title;
            titleLabel.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            titleLabel.ForeColor = titleColor;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(20, 15);
            panel.Controls.Add(titleLabel);

            valueLabel = new UIDigitalLabel();
            valueLabel.DecimalPlaces = 0;
            valueLabel.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            valueLabel.ForeColor = Color.WhiteSmoke;
            valueLabel.Location = new Point(18, 48);
            valueLabel.MinimumSize = new Size(1, 1);
            valueLabel.Size = new Size(size.Width - 36, 50);
            valueLabel.Text = "0";
            panel.Controls.Add(valueLabel);

            return panel;
        }

        private UILabel CreateSectionTitle(string text, Point location)
        {
            var label = new UILabel();
            label.AutoSize = true;
            label.Font = new Font("微软雅黑", 11F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label.ForeColor = Color.WhiteSmoke;
            label.Location = location;
            label.Text = text;
            return label;
        }

        private UIBarChart CreateBarChart(Point location, Size size)
        {
            var chart = new UIBarChart();
            chart.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chart.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chart.Location = location;
            chart.MinimumSize = new Size(1, 1);
            chart.RadiusSides = UICornerRadiusSides.None;
            chart.RectSides = ToolStripStatusLabelBorderSides.None;
            chart.Size = size;
            chart.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chart.Style = UIStyle.Custom;
            chart.TextAlign = ContentAlignment.MiddleLeft;
            return chart;
        }

        private UIBarOption CreateChartOption(string legendName, string xAxisName, string yAxisName, bool showDecimal)
        {
            var option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = string.Empty;
            option.Legend = new UILegend();
            option.Legend.AddData(legendName);
            option.ToolTip.Visible = true;
            option.BarInterval = 1;
            option.XAxis.Name = xAxisName;
            option.XAxis.AxisLabel.Angle = 10;
            option.YAxis.Name = yAxisName;
            option.YAxis.AxisLabel.DecimalPlaces = showDecimal ? 2 : 0;
            option.YAxis.ShowGridLine = false;
            option.ShowValue = true;
            option.Grid.Left = 35;
            option.Grid.Right = 15;
            option.Grid.Top = 35;
            option.Grid.Bottom = 55;
            return option;
        }

        private DataGridView CreateGrid(Point location, Size size)
        {
            var grid = new DataGridView();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(28, 38, 54);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.DimGray;
            grid.Location = location;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 28;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = size;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 46, 62);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.BackColor = Color.FromArgb(24, 33, 47);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(24, 33, 47);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 41, 58);

            grid.Columns.Add("colDefectName", "缺陷项");
            grid.Columns.Add("colDefectCount", "NG数量");
            grid.Columns.Add("colDefectNgRate", "占NG比");
            grid.Columns.Add("colDefectTotalRate", "占总检比");
            grid.Columns.Add("colDefectRank", "排名");
            return grid;
        }

        private void RefreshDashboard()
        {
            lblTimeValue.Text = DateTime.Now.ToString("yyyy-MM-dd    HH:mm:ss");

            if (!ExtHandler.IsLoad)
            {
                SetEmptyState();
                return;
            }

            int okCount = ExtHandler.GetGlobalVar<int>(OkKey);
            int ngCount = ExtHandler.GetGlobalVar<int>(NgKey);
            int totalCount = okCount + ngCount;
            int passRate = 0;
            int detailTotal = 0;
            int[] defectCounts = new int[DefectKeys.Length];

            for (int i = 0; i < DefectKeys.Length; i++)
            {
                defectCounts[i] = ExtHandler.GetGlobalVar<int>(DefectKeys[i]);
                detailTotal += defectCounts[i];
            }

            if (totalCount > 0)
            {
                passRate = (int)Math.Round(okCount * 100.0 / totalCount, MidpointRounding.AwayFromZero);
            }

            lblTotalValue.Text = totalCount.ToString();
            lblOkValue.Text = okCount.ToString();
            lblNgValue.Text = ngCount.ToString();
            rpPassRate.Value = passRate;
            rpPassRate.Text = passRate + "%";

            var countSeries = ngCountOption.Series[0] as UIBarSeries;
            if (countSeries != null)
            {
                countSeries.Clear();
                for (int i = 0; i < defectCounts.Length; i++)
                {
                    countSeries.AddData(defectCounts[i]);
                }
                chartNgCount.SetOption(ngCountOption);
            }

            var rateSeries = ngRateOption.Series[0] as UIBarSeries;
            if (rateSeries != null)
            {
                rateSeries.Clear();
                for (int i = 0; i < defectCounts.Length; i++)
                {
                    double percent = detailTotal > 0 ? Math.Round(defectCounts[i] * 100.0 / detailTotal, 2) : 0d;
                    rateSeries.AddData(percent);
                }
                chartNgRate.SetOption(ngRateOption);
            }

            dgvDetail.Rows.Clear();
            for (int i = 0; i < DefectKeys.Length; i++)
            {
                double ngRate = detailTotal > 0 ? defectCounts[i] * 100.0 / detailTotal : 0d;
                double totalRate = totalCount > 0 ? defectCounts[i] * 100.0 / totalCount : 0d;
                dgvDetail.Rows.Add(
                    DefectKeys[i].ToUpperInvariant(),
                    defectCounts[i],
                    ngRate.ToString("F2") + "%",
                    totalRate.ToString("F2") + "%",
                    i + 1);
            }
        }

        private void SetEmptyState()
        {
            lblTotalValue.Text = "0";
            lblOkValue.Text = "0";
            lblNgValue.Text = "0";
            rpPassRate.Value = 0;
            rpPassRate.Text = "0%";

            var countSeries = ngCountOption.Series[0] as UIBarSeries;
            if (countSeries != null)
            {
                countSeries.Clear();
                for (int i = 0; i < DefectKeys.Length; i++)
                {
                    countSeries.AddData(0);
                }
                chartNgCount.SetOption(ngCountOption);
            }

            var rateSeries = ngRateOption.Series[0] as UIBarSeries;
            if (rateSeries != null)
            {
                rateSeries.Clear();
                for (int i = 0; i < DefectKeys.Length; i++)
                {
                    rateSeries.AddData(0);
                }
                chartNgRate.SetOption(ngRateOption);
            }

            dgvDetail.Rows.Clear();
            for (int i = 0; i < DefectKeys.Length; i++)
            {
                dgvDetail.Rows.Add(DefectKeys[i].ToUpperInvariant(), 0, "0.00%", "0.00%", i + 1);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (refreshTimer != null)
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}
