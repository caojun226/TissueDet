using System;
using System.IO;
using System.Windows.Forms;
using LittleCommon.Tool;
using VisionCore.Ext;
using Sunny.UI;

namespace TissueDet
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 定义授权文件路径 (建议结合应用程序根目录，防止从其他位置启动时找不到文件)
            // string appPath = Application.StartupPath;
            // string filePath = Path.Combine(appPath, "detkey.xml");
            string filePath = "detkey.xml";
            string savedKey = null;

            // 1. 尝试读取本地授权码
            if (File.Exists(filePath))
            {
                try
                {
                    // 修正：使用变量 filePath 而不是硬编码字符串
                    savedKey = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    // 记录日志或处理读取异常（例如文件被占用）
                    MessageBox.Show($"读取授权文件失败: {ex.Message}");
                }
            }

            bool isLicensed = !string.IsNullOrEmpty(savedKey) && LicenseHelper.VerifyLicense(savedKey);

            if (isLicensed)
            {
                // 授权验证通过，尝试启动主程序
                StartApplication();
            }
            else
            {
                // 验证失败或没有注册码，显示注册窗体
                using (var regForm = new FrmRegister())
                {
                    if (regForm.ShowDialog() == DialogResult.OK)
                    {
                        // 用户在注册窗体点击了确定（假设已保存或通过验证）
                        StartApplication();
                    }
                    // else 用户取消或关闭，程序自然退出
                }
            }
        }

        /// <summary>
        /// 启动应用程序的公共逻辑（处理单例检查和初始化）
        /// </summary>
        static void StartApplication()
        {
            if (ProcessUtils.IsExitProcess())
            {
                UIPage page = new UIPage();
                page.ShowWarningDialog("已经打开一个程序");
            }
            else
            {
                ExtHandler.Init();
                Application.Run(new FrmMain());
            }
        }
    }
}
