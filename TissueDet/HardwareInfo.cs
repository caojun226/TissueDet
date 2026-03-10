using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

public static class HardwareInfo
{
    /// <summary>
    /// 获取机器码
    /// </summary>
    /// <returns>32位大写机器码</returns>
    public static string GetMachineCode()
    {
        try
        {
            // 1. 获取 CPU ID
            string cpuId = GetCpuId();
            // 2. 获取主板序列号
            string mbSerial = GetMotherboardSerial();

            // 为了防止其中一项为空导致冲突，做个简单的检查
            if (string.IsNullOrEmpty(cpuId)) cpuId = "CPU_NULL";
            if (string.IsNullOrEmpty(mbSerial)) mbSerial = "MB_NULL";

            // 3. 组合字符串
            string combinedId = cpuId + "_" + mbSerial;

            // 4. 进行 MD5 加算，生成一个固定长度（32位）且看起来像乱码的唯一标识
            return ComputeMd5(combinedId);
        }
        catch (Exception ex)
        {
            // 如果获取失败（例如非Windows系统），返回一个备用码
            Console.WriteLine($"获取硬件ID失败: {ex.Message}");
            return "FALLBACK_MACHINE_ID";
        }
    }

    /// <summary>
    /// 获取 CPU 处理器 ID
    /// </summary>
    private static string GetCpuId()
    {
        string cpuInfo = "";
        try
        {
            // 查询 Win32_Processor
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                break; 
            }
        }
        catch { }
        return cpuInfo;
    }

    /// <summary>
    /// 获取主板序列号
    /// </summary>
    private static string GetMotherboardSerial()
    {
        string serial = "";
        try
        {
            // 查询 Win32_BaseBoard
            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                serial = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
        }
        catch { }
        return serial;
    }

    /// <summary>
    /// 计算 MD5 哈希字符串
    /// </summary>
    private static string ComputeMd5(string plainText)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                // 转为两位的 16 进制字符串
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
