using System;
using System.Security.Cryptography;
using System.Text;

public static class LicenseHelper
{
    // 公钥
    private const string PublicKey = @"<RSAKeyValue><Modulus>ul8OX5YR9SmvN/+uN71G7+gKJqP7hMjctUd2mn0JaCvZMNqhUr6xKtMC4U77/RuXyS5V/1BrXmOZ57lUQqiswhQUV2wzUpACHFgqSNiF8OGevU1SrRtSDKNSNbgj7Roxsm8Enkrgm92Qi4gUV/c4Ut/o7Pt3bJeAea2iwkcH6U/RPQUgM0HaGZdgrLp3F/K8yYkP3ZbC7XkpqmCYV4BZ9vV07SEWygCrpI7EgiG5PMY4QYwLHjXFauM+aHkaycp3nOJLrXjW+T/zbqXFZnuCX6rdcTwp+UAABc1O/c2Oo8cR8uDc5Q+TJvUA+FN27kX1AHgzi5dLuM0efgeIffCO8Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

    // 获取机器码 
    public static string GetMachineCode()
    {
        return HardwareInfo.GetMachineCode();
    }

    // 验证注册码
    public static bool VerifyLicense(string inputLicenseKey)
    {
        try
        {
            string machineCode = GetMachineCode();

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(PublicKey);

                // 将输入的注册码转回字节
                byte[] signature = Convert.FromBase64String(inputLicenseKey);
                byte[] data = Encoding.UTF8.GetBytes(machineCode);

                // 用公钥验证 签名是否匹配 机器码
                return rsa.VerifyData(data, CryptoConfig.MapNameToOID("SHA256"), signature);
            }
        }
        catch
        {
            return false;
        }
    }
}
