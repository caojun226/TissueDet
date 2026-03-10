using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Vision.Service;
using VisionCore.Communication;
using VisionCore.Core;
using VisionCore.Ext;
using VisionCore.Frm;
using VisionCore.Log;
using VisionCore.Tools;

namespace TissueDet
{
    public partial class FrmMain1 : UIForm
    {
        public FrmMain1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 牌号选择
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
        /// 系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            FrmTool.ShowDialog<CommonSetFrm>();
        }

        /// <summary>
        /// 方案保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            ExtHandler.SaveSol();
            btnSave.Enabled = true;
        }

        private void InitVibrating()
        {
            Invoke(new Action(() => {
                Config.LoadConfig();
                Config.SetCanvas(MPanel);
                //TissueOp.Init();
                logView1.Start();
            }));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Task.Run(() => {
                InitVibrating();
                AutoLoad();
            });
            //Timer1.Start();
        }

        private void AutoLoad()
        {
            Invoke(new Action(() => {
                List<string> Sols = ExtHandler.GetSols();
                SolComboBox.Items.Clear();
                bool r = false;
                foreach (string sol in Sols)
                {
                    var a = ExtHandler.GetAutoLoadSolName();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 退出所有窗口和应用程序
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
                EComManageer.Write<short>("ModbusTcpNet0", "1002", 1);
            }
            else
            {
                LogNet.Info("与下位机通讯异常！");
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
                EComManageer.Write<short>("ModbusTcpNet0", "1003", 1);
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
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
                    txtSpeed.Text = speed.data.ToString();
                    Timer1.Stop();
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
                short speed = txtSpeed.Text.ToShort();
                EComManageer.Write<float>("ModbusTcpNet0", "1000", speed);
            }
            else
            {
                LogNet.Error("与下位机通讯异常！");
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (SolHandler.IsLoad)
            {
                ReadSpeed();
            }
        }
    }
}
