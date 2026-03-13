using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TissueDet
{
    public partial class FrmRegister : UIForm
    {
        public FrmRegister()
        {
            InitializeComponent();
            txtMachineCode.Text = LicenseHelper.GetMachineCode();
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string inputKey = txtLicenseKey.Text.Trim();

            if (LicenseHelper.VerifyLicense(inputKey))
            {
                // 验证成功后，统一保存到程序根目录。
                // 这样主程序读取与注册窗口写入使用同一路径，避免路径不一致问题。
                File.WriteAllText(LicenseHelper.GetLicenseFilePath(), inputKey);

                this.DialogResult = DialogResult.OK; // 通知 Main 方法可以启动主程序了
                this.Close();
            }
            else
            {
                MessageBox.Show("注册码无效！");
            }
        }
    }
}
