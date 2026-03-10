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
            //step1:尝试打开IO口，失败后即刻返回
            bool r1 = OpenIo();
            if (!r1)
            {
                LogNet.Error("IO卡打开失败,");
            }
            else { LogNet.Info("IO卡加载成功"); }
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
            catch (Exception                                 e)
            {
                return false;
            }
        }
        public static bool CloseIo()
        {
            int Result;
            Result = WENYU_EIO32P.Program.WY_Close();
            return true;
        }

    }
}
