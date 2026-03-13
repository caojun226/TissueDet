using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision.Service;
using VisionCore.Communication;
using VisionCore.Core;
using VisionCore.Ext;
using VisionCore.Frm;
using VisionCore.Log;
using VisionCore.Tools;

namespace TissueDet
{
    public partial class FrmMain : UIForm
    {
        private const string PlcName = "ModbusTcpNet0";
        private const string StartAddress = "1101";
        private const string StopAddress = "1112";
        private const string SpeedAddress = "1000";
        private const string OkKey = "ok";
        private const string NgKey = "ng";
        private static readonly string[] DefectKeys = { "vs1", "vs2", "vs3", "vs4", "vs5" };

        private UIBarOption option;
        private UISymbolButton btnStatisticsBoard;
        private FrmStatisticsDashboard statisticsDashboard;

        public FrmMain()
        {
            InitializeComponent();
            InitializeStatisticsBoardButton();

            //初始化柱状图
            // 初始化柱状图配置（示例）
            option = new UIBarOption();

            // 标题
            option.Title = new UITitle
            {
                Text = "",
                SubText = ""
            };

            // 图例
            option.Legend = new UILegend();
            option.Legend.AddData("缺陷数");  // 系列名称

            // 创建一个系列
            var series = new UIBarSeries
            {
                Name = "缺陷数"
            };

            // 先初始化默认数据点，数量与 DefectKeys 保持一致。
            for (int i = 0; i < DefectKeys.Length; i++)
            {
                series.AddData(0); // 先填 0，后面再更新
            }

            option.Series.Add(series);

            // X 轴标签与全局变量键一一对应，后续维护时只需要修改一个数组。
            foreach (string defectKey in DefectKeys)
            {
                option.XAxis.Data.Add(defectKey);
            }

            option.YAxis.Name = "数量";
            option.XAxis.Name = "组件";

            // 应用配置
            devCountBarChart.SetOption(option);
        }

        /// <summary>
        /// 在主界面顶部增加“统计大屏”入口。
        /// 右侧详细统计已经移到独立页面中，主界面只保留简要统计。
        /// </summary>
        private void InitializeStatisticsBoardButton()
        {
            btnStatisticsBoard = new UISymbolButton();
            btnStatisticsBoard.Cursor = Cursors.Hand;
            btnStatisticsBoard.FillColor = Color.FromArgb(14, 30, 40);
            btnStatisticsBoard.FillHoverColor = Color.FromArgb(28, 57, 66);
            btnStatisticsBoard.FillPressColor = Color.FromArgb(28, 57, 66);
            btnStatisticsBoard.FillSelectedColor = Color.FromArgb(14, 30, 40);
            btnStatisticsBoard.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnStatisticsBoard.Location = new Point(292, 12);
            btnStatisticsBoard.MinimumSize = new Size(1, 1);
            btnStatisticsBoard.Name = "btnStatisticsBoard";
            btnStatisticsBoard.RadiusSides = UICornerRadiusSides.None;
            btnStatisticsBoard.RectSides = ToolStripStatusLabelBorderSides.None;
            btnStatisticsBoard.Size = new Size(110, 32);
            btnStatisticsBoard.Symbol = 61960;
            btnStatisticsBoard.SymbolColor = Color.Gainsboro;
            btnStatisticsBoard.SymbolSize = 18;
            btnStatisticsBoard.Text = "统计大屏";
            btnStatisticsBoard.TipsFont = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnStatisticsBoard.Click += btnStatisticsBoard_Click;
            panelTop.Controls.Add(btnStatisticsBoard);
        }

        /// <summary>
        /// 打开独立统计大屏。
        /// 如果窗口已打开则只激活，不重复创建实例。
        /// </summary>
        private void btnStatisticsBoard_Click(object sender, EventArgs e)
        {
            if (statisticsDashboard == null || statisticsDashboard.IsDisposed)
            {
                statisticsDashboard = new FrmStatisticsDashboard();
            }

            statisticsDashboard.Show();
            statisticsDashboard.Activate();
        }


        System.Timers.Timer timeTimer;
        /// <summary>
        /// 系统初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;//最大化
            btnMax.Symbol = 262029;//Normal 
            //初始化时间
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd    HH:mm:ss");
            //定时器的初始化
            {
                timeTimer = new System.Timers.Timer();
                timeTimer.Interval = 1000;
                timeTimer.Elapsed += TimeTimer_Elapsed;
                timeTimer.Start();
                //readTimer = new System.Timers.Timer();
                //readTimer.Interval = 1000;
                //readTimer.Elapsed += ReadTimer_Elapsed 
            }
            // 这里两段逻辑最终都会访问 UI，直接在加载流程中执行更直观，
            // 同时避免额外创建后台任务后再切回 UI 线程的无效切换。
            InitVibrating();
            AutoLoad();
            Timer1.Start();

        }
        private void InitVibrating()
        {
            Invoke(new Action(() =>
            {
                Config.LoadConfig();
                Config.SetCanvas(MPanel);
                //TissueOp.Init();
                logView1.Start();
            }));
        }
        private void AutoLoad()
        {
            Invoke(new Action(() =>
            {
                List<string> Sols = ExtHandler.GetSols();
                string autoLoadSolName = ExtHandler.GetAutoLoadSolName();
                SolComboBox.Items.Clear();
                bool r = false;
                foreach (string sol in Sols)
                {
                    if (sol == autoLoadSolName)
                    {
                        r = true;
                    }
                    SolComboBox.Items.Add(sol);
                }
                if (r)
                {
                    SolComboBox.SelectedItem = autoLoadSolName;
                }
                else
                {
                    SolComboBox.SelectedItem = null;
                }
            }));
        }

        /// <summary>
        /// 尝试获取下位机通讯对象。
        /// 统一封装后，启动、停止、读写速度等逻辑不再重复写相同判断。
        /// </summary>
        private bool TryGetPlcCommunication()
        {
            var result = EComManageer.GetECommunication(PlcName);
            if (!result.status)
            {
                LogNet.Error("与下位机通讯异常！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 刷新缺陷柱状图。
        /// 使用统一数组驱动，减少重复代码并降低后续增加/删除统计项的修改成本。
        /// </summary>
        private void RefreshDefectChart()
        {
            if (!ExtHandler.IsLoad || option == null || option.Series == null || option.Series.Count == 0)
            {
                return;
            }

            var series = option.Series[0] as UIBarSeries;
            if (series == null)
            {
                return;
            }

            series.Clear();

            foreach (string defectKey in DefectKeys)
            {
                series.AddData(ExtHandler.GetGlobalVar<int>(defectKey));
            }

            devCountBarChart.SetOption(option);
        }

        /// <summary>
        /// 刷新 OK、NG 和合格率显示。
        /// 数据来源为全局变量：ok、ng。
        /// 合格率计算公式：OK / (OK + NG) * 100。
        /// 当总数为 0 时按 0% 处理，避免除零异常。
        /// </summary>
        private void RefreshPassStatistics()
        {
            if (!ExtHandler.IsLoad)
            {
                return;
            }

            int okCount = ExtHandler.GetGlobalVar<int>(OkKey);
            int ngCount = ExtHandler.GetGlobalVar<int>(NgKey);
            int totalCount = okCount + ngCount;
            int passRate = 0;

            if (totalCount > 0)
            {
                passRate = (int)Math.Round(okCount * 100.0 / totalCount, MidpointRounding.AwayFromZero);
            }

            // OK/NG 数量直接显示在数码标签上。
            uilabok.Text = okCount.ToString();
            uilabng.Text = ngCount.ToString();

            // 圆环控件同时刷新数值和文本，保证进度与显示一致。
            rpPassRate.Value = passRate;
            rpPassRate.Text = passRate + "%";
        }

        //初始化图表
        private void InitBarChartOption()
        {
            //创建柱状图表选项
            UIBarOption barOption = new UIBarOption();
            barOption.BarInterval = 1;
            barOption.Grid.Left = 30;
            barOption.Grid.Right = 10;
            barOption.Grid.Top = 30;
            barOption.Grid.Bottom = 60;

            //Title
            barOption.Title = new UITitle();
            barOption.Title.Text = "";
            barOption.Title.Top = UITopAlignment.Top;
            //Legend
            barOption.Legend = new UILegend();
            barOption.Legend.Orient = UIOrient.Horizontal;
            barOption.Legend.Top = UITopAlignment.Top;
            barOption.Legend.Left = UILeftAlignment.Right;
            barOption.Legend.AddData("总量", Color.DarkSeaGreen);
            barOption.Legend.AddData("运行", Color.Orange);
            barOption.Legend.AddData("停止", Color.OrangeRed);
            //Series
            var series01 = new UIBarSeries();
            series01.Name = "总量";
            series01.MaxWidth = 20;
            series01.DecimalPlaces = 0;
            barOption.AddSeries(series01);//添加序列

            var series02 = new UIBarSeries();
            series02.Name = "运行";
            series02.MaxWidth = 20;

            series02.DecimalPlaces = 0;
            barOption.AddSeries(series02);//添加序列

            var series03 = new UIBarSeries();
            series03.Name = "停止";
            series03.MaxWidth = 20;
            series03.DecimalPlaces = 0;
            barOption.AddSeries(series03);//添加序列

            //X\Y轴
            barOption.ToolTip.Visible = true;
            barOption.XAxis.Name = "设备组";
            barOption.XAxis.AxisLabel.Angle = 12;

            barOption.YAxis.Name = "总量";
            barOption.YAxis.AxisLabel.DecimalPlaces = 0;
            barOption.YAxis.ShowArrow = true;
            barOption.YAxis.ShowGridLine = false;
            barOption.YAxis.AxisTick.Length = 8;
            barOption.ShowValue = true;
            devCountBarChart.SetOption(barOption);
        }

        /// <summary>
        /// 动态时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!this.IsDisposed)
            {
                try
                {
                    // System.Timers.Timer 的 Elapsed 在线程池线程执行。
                    // 所有控件和图表更新必须切回 UI 线程，否则会出现跨线程异常。
                    if (!this.IsHandleCreated)
                    {
                        return;
                    }

                    this.BeginInvoke(new Action(() =>
                    {
                        lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd    HH:mm:ss");

                        if (ExtHandler.IsLoad)
                        {
                            RefreshDefectChart();
                            RefreshPassStatistics();
                        }
                    }));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
                catch (InvalidOperationException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    LogNet.Error(ex.ToString());
                }
            }

        }

        //重新刷新柱状图表--设备总量统计
        private void RefreshDeviceCountStat()
        {
            UIBarOption barOption = devCountBarChart.Option;
            if (barOption?.Series != null)
            {
                if (barOption.Series.Count > 1 && barOption.Series[1] != null)
                {
                    barOption.Series[1].Clear();
                }
                if (barOption.Series.Count > 2 && barOption.Series[2] != null)
                {
                    barOption.Series[2].Clear();
                }
            }
            devCountBarChart.SetOption(barOption);
        }

        //系统设置
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmTool.ShowDialog<CommonSetFrm>();
        }

        #region 窗口行为
        Point point;
        bool isMoving = false;//是否启动拖动
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            isMoving = true;//启动拖动
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMoving)
            {
                this.Location += new Size(e.Location.X - point.X, e.Location.Y - point.Y);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//释放拖动
        }

        //最小化
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //最大化与常规状态切换
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMax.Symbol = 261640;//口字型
            }
            else
            {
                WindowState = FormWindowState.Maximized;//最大化
                btnMax.Symbol = 262029;//Normal 
            }
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Timer1?.Stop();
            }
            catch { }

            try
            {
                if (timeTimer != null)
                {
                    timeTimer.Stop();
                    timeTimer.Dispose();
                    timeTimer = null;
                }
            }
            catch (Exception ex)
            {
                LogNet.Error(ex.ToString());
            }

            this.Close();
        }

        #endregion

        /// <summary>
        /// 解决方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSol_Click(object sender, EventArgs e)
        {
            ExtHandler.ShowExFrm();
        }


        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (TryGetPlcCommunication())
            {
                EComManageer.Write<short>(PlcName, StartAddress, 1);
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (TryGetPlcCommunication())
            {
                EComManageer.Write<short>(PlcName, StopAddress, 1);
            }
        }

        /// <summary>
        /// 切换牌号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SolName = (string)SolComboBox.SelectedItem;
            if (!string.IsNullOrEmpty(SolName))
            {
                ExtHandler.Load(SolName, new Action<bool>(r =>
                {
                    Invoke(new Action(() =>
                    {

                        if (!r)
                        {
                            SolComboBox.SelectedItem = null;
                            this.ShowErrorDialog("型号加载失败");
                        }

                    }));

                }));
            }
            else
            {
                this.ShowErrorDialog("请添加牌号");
            }

        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddbrand_Click(object sender, EventArgs e)
        {
            ExtHandler.AddSol(new Action<bool>(r =>
            {
                if (r)
                {
                    List<string> Sols = ExtHandler.GetSols();
                    Invoke(new Action(() =>
                    {
                        SolComboBox.Items.Clear();
                        foreach (string sol in Sols)
                        {
                            if (sol == ExtHandler.GetAutoLoadSolName())
                            {
                                r = true;
                            }
                            SolComboBox.Items.Add(sol);
                        }


                    }));

                }
            }));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (SolHandler.IsLoad)
            {
                ReadSpeed();
                Timer1.Stop();
                Timer1.Dispose();
            }
        }
        /// <summary>
        /// 读取默认速度
        /// </summary>
        private void ReadSpeed()
        {
            if (TryGetPlcCommunication())
            {
                var speed = EComManageer.Read<float>(PlcName, SpeedAddress);
                if (speed.status)
                {
                    // 读取结果最终展示到文本框，因此统一切回 UI 线程赋值。
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtSpeed.Text = speed.data.ToString();
                    });
                }
            }
        }

        /// <summary>
        /// 速度设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeedSet_Click(object sender, EventArgs e)
        {
            if (TryGetPlcCommunication())
            {
                // 目标寄存器为 float（Read<float> 在 ReadSpeed 中使用），
                // 所以这里解析为 float 并写回。
                float speedValue = 0f;
                if (!float.TryParse(txtSpeed.Text, out speedValue))
                {
                    this.ShowErrorDialog("速度格式不正确");
                    return;
                }

                EComManageer.Write<float>(PlcName, SpeedAddress, speedValue);
            }
        }
    }
}