using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WENYU_EIO32P;
using VisionCore.Log;

namespace TissueDet
{
    class TissueOp
    {
        public static bool Init()
        {
            // step1: 尝试打开 IO 口，失败后直接返回 false。
            // 旧实现无论打开是否成功都返回 true，调用方无法判断初始化真实状态。
            bool r1 = OpenIo();
            if (!r1)
            {
                LogNet.Error("IO卡打开失败");
                return false;
            }
            LogNet.Info("IO卡加载成功");
            return true;
        }
        public static bool OpenIo()
        {
            long VersionNumber = 0;
            try
            {
                if (WENYU_EIO32P.Program.WY_Open() == 0)
                {
                    LogNet.Error("板卡没有找到！");
                    return false;
                }
                if (WENYU_EIO32P.Program.WY_GetCardVersion(0, ref VersionNumber) == 1)
                {
                    LogNet.Warn("IO卡---通讯异常！");
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                LogNet.Error("IO卡打开异常：" + e.Message);
                return false;
            }
        }
        public static bool CloseIo()
        {
            try
            {
                // 约定返回 0 表示调用成功完成。
                return WENYU_EIO32P.Program.WY_Close() == 0;
            }
            catch (Exception e)
            {
                LogNet.Error("IO卡关闭异常：" + e.Message);
                return false;
            }
        }

    }
}
