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

        private UIBarOption option;
        public FrmMain()
        {
            InitializeComponent();

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

            // 先初始化几个数据点，比如 5 个
            for (int i = 0; i < 5; i++)
            {
                series.AddData(0); // 先填 0，后面再更新
            }

            option.Series.Add(series);

            // X 轴标签（和上面 5 个数据对应）
            for (int i = 1; i <= 5; i++)
            {
                option.XAxis.Data.Add($"vs{i}");
            }

            option.YAxis.Name = "数量";
            option.XAxis.Name = "组件";

            // 应用配置
            devCountBarChart.SetOption(option);
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
            Task.Run(() =>
            {
                InitVibrating();
                AutoLoad();
            });
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
                SolComboBox.Items.Clear();
                bool r = false;
                foreach (string sol in Sols)
                {
                    if (sol == ExtHandler.GetAutoLoadSolName())
                    {
                        r = true;
                    }
                    SolComboBox.Items.Add(sol);
                }
                if (r)
                {
                    SolComboBox.SelectedItem = ExtHandler.GetAutoLoadSolName();
                }
                else
                {
                    SolComboBox.SelectedItem = null;
                }
            }));
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
                    // All UI updates must run on the UI thread because this Elapsed
                    // handler runs on a thread-pool thread (System.Timers.Timer).
                    this.BeginInvoke(new Action(() =>
                    {
                        lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd    HH:mm:ss");

                        // 缺陷数
                        if (option == null) return;
                        if (option.Series == null || option.Series.Count == 0) return;

                        var series = option.Series[0] as UIBarSeries;
                        if (series == null) return;

                        if (ExtHandler.IsLoad)
                        {
                            // 先清空旧数据
                            series.Clear();
                            series.AddData(ExtHandler.GetGlobalVar<Int32>("vs1"));
                            series.AddData(ExtHandler.GetGlobalVar<Int32>("vs2"));
                            series.AddData(ExtHandler.GetGlobalVar<Int32>("vs3"));
                            series.AddData(ExtHandler.GetGlobalVar<Int32>("vs4"));
                            series.AddData(ExtHandler.GetGlobalVar<Int32>("vs5"));
                            devCountBarChart.SetOption(option);
                        }
                    }));



                }
                catch
                {
                    return;
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
            var r = EComManageer.GetECommunication("ModbusTcpNet0");
            if (r.status)
            {
                EComManageer.Write<short>("ModbusTcpNet0", "1101", 1);
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            var r = EComManageer.GetECommunication("ModbusTcpNet0");
            if (r.status)
            {
                EComManageer.Write<short>("ModbusTcpNet0", "1112", 1);
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
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
            var r = EComManageer.GetECommunication("ModbusTcpNet0");
            if (r.status)
            {
                var speed = EComManageer.Read<float>("ModbusTcpNet0", "1000");
                if (speed.status)
                {
                    // 直接使用 Invoke
                    this.Invoke((MethodInvoker)delegate
                    {
                        txtSpeed.Text = speed.data.ToString();
                    });
                }
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
            }
        }

        /// <summary>
        /// 速度设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeedSet_Click(object sender, EventArgs e)
        {
            var r = EComManageer.GetECommunication("ModbusTcpNet0");
            if (r.status)
            {
                // 目标寄存器为 float（Read<float> 在 ReadSpeed 中使用），
                // 所以这里解析为 float 并写回。
                float speedValue = 0f;
                if (!float.TryParse(txtSpeed.Text, out speedValue))
                {
                    this.ShowErrorDialog("速度格式不正确");
                    return;
                }

                EComManageer.Write<float>("ModbusTcpNet0", "1000", speedValue);
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
            }
        }
    }
}