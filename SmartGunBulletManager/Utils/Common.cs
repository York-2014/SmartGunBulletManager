using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace SmartGunBulletManager.Utils
{
    /// <summary>
    /// 实用工具类
    /// </summary>
    public class Common
    {
        #region 转换数据类型
        /// <summary>  
        /// 转换数据类型  
        /// </summary>  
        /// <typeparam name="T">自定义数据类型</typeparam>  
        /// <param name="myvalue">传入需要转换的值</param>  
        /// <param name="defaultValue">默认值</param>  
        /// <returns></returns>  
        public static object ConvertToT<T>(object myvalue, T defaultValue)
        {
            TypeCode typeCode = System.Type.GetTypeCode(typeof(T));
            if (myvalue != null)
            {
                string value = Convert.ToString(myvalue);
                switch (typeCode)
                {
                    case TypeCode.Boolean:
                        bool flag = false;
                        if (bool.TryParse(value, out flag))
                        {
                            return flag;
                        }
                        break;
                    case TypeCode.Char:
                        char c;
                        if (Char.TryParse(value, out c))
                        {
                            return c;
                        }
                        break;
                    case TypeCode.SByte:
                        sbyte s = 0;
                        if (SByte.TryParse(value, out s))
                        {
                            return s;
                        }
                        break;
                    case TypeCode.Byte:
                        byte b = 0;
                        if (Byte.TryParse(value, out b))
                        {
                            return b;
                        }
                        break;
                    case TypeCode.Int16:
                        Int16 i16 = 0;
                        if (Int16.TryParse(value, out i16))
                        {
                            return i16;
                        }
                        break;
                    case TypeCode.UInt16:
                        UInt16 ui16 = 0;
                        if (UInt16.TryParse(value, out ui16))
                            return ui16;
                        break;
                    case TypeCode.Int32:
                        int i = 0;
                        if (Int32.TryParse(value, out i))
                        {
                            return i;
                        }
                        break;
                    case TypeCode.UInt32:
                        UInt32 ui32 = 0;
                        if (UInt32.TryParse(value, out ui32))
                        {
                            return ui32;
                        }
                        break;
                    case TypeCode.Int64:
                        Int64 i64 = 0;
                        if (Int64.TryParse(value, out i64))
                        {
                            return i64;
                        }
                        break;
                    case TypeCode.UInt64:
                        UInt64 ui64 = 0;
                        if (UInt64.TryParse(value, out ui64))
                            return ui64;
                        break;
                    case TypeCode.Single:
                        Single single = 0;
                        if (Single.TryParse(value, out single))
                        {
                            return single;
                        }
                        break;
                    case TypeCode.Double:
                        double d = 0;
                        if (Double.TryParse(value, out d))
                        {
                            return d;
                        }
                        break;
                    case TypeCode.Decimal:
                        decimal de = 0;
                        if (Decimal.TryParse(value, out de))
                        {
                            return de;
                        }
                        break;
                    case TypeCode.DateTime:
                        DateTime dt;
                        if (DateTime.TryParse(value, out dt))
                        {
                            return dt;
                        }
                        break;
                    case TypeCode.String:
                        if (!string.IsNullOrEmpty(value))
                        {
                            return value.ToString();
                        }
                        break;
                }
            }
            return defaultValue;
        }

        #endregion

        #region 获取当前程序版本号
        /// <summary>
        /// 获取当前程序版本号
        /// </summary>
        /// <returns>版本号</returns>
        public static string AssemblyFileVersion()
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
            if (attributes.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return ((AssemblyFileVersionAttribute)attributes[0]).Version;
            }
        }
        #endregion

        #region 实体与JSON互转
        /// <summary>
        /// 指定实体转JSON
        /// </summary>
        /// <typeparam name="T">类型约束</typeparam>
        /// <param name="t">类型</param>
        /// <returns>返回JSON字符串</returns>
        public static string EntityToJsonString<T>(T t)
        {
            return JsonConvert.SerializeObject(t).ToLower();
        }

        /// <summary>
        /// JSON转指定实体
        /// </summary>
        /// <typeparam name="T">类型约束</typeparam>
        /// <param name="strJson">JSON字符串</param>
        /// <param name="t">类型</param>
        /// <returns>返回指定类型</returns>
        public static T JsonStringToEntity<T>(string strJson, Type t) where T : class
        {
            return JsonConvert.DeserializeObject(strJson, t) as T;
        }
        #endregion

        #region MD5
        /// <summary>
        /// 取得输入字符串的MD5哈希值
        /// </summary>
        /// <param name="argInput">输入字符串</param>
        /// <returns>MD5哈希值</returns>
        public static string GetMd5Hash(string argInput)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(argInput));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        /// <summary>
        /// 验证MD5哈希值
        /// </summary>
        /// <param name="argInput">输入字符串</param>
        /// <param name="argHash">哈希值</param>
        /// <returns>相同返回TRUE,不同返回FALSE</returns>
        public static bool VerifyMd5Hash(string argInput, string argHash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(argInput);

            // Create a StringComparer an comare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, argHash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 字符串与Base64String互转
        /// <summary>
        /// 字符串转Base64String
        /// </summary>
        /// <param name="strString"></param>
        /// <returns></returns>
        public static string StringToBase64String(string strString)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(strString));
        }

        /// <summary>
        /// Base64String转字符串
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static string Base64StringToString(string base64String)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64String));
        }
        #endregion

        #region 获取电池状态
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public int BatteryLifeTime;
            public int BatteryFullLifeTime;
        }
        //然后导入外部函数： 
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool GetSystemPowerStatus(ref SYSTEM_POWER_STATUS systemPowerStatus);
        #region 说明
        //如果调用成功，返回 true，然后分析systemPowerStatus的数据就行。 
        //ACLineStatus为1时，表示正在使用交流电源，为0使用直流电源。 
        /*ACLineStatus 
        交流电源状态
        0
         Offline
        1
         Online
        255
         Unknown status
 
        BatteryFlag 
        电池充电状态。 可以包含一或多个以下指

        1
         高，电量大于66%
 
        2
         低，小于33%
 
        4
         极低，小于5%
 
        8
         充电中
 
        128
         没有电池
 
        255
         位置，无法读取状态。

        BatteryLifePercent 
        电池还有百分之几能充满.0~100，若未知则为255
        Reserved1 
        保留，必须为0

        BatteryLifeTime 
        秒为单位的电池剩余电量, 若未知则为-1

        BatteryFullLifeTime 
        秒为单位的电池充满电的电量，若未知则为-1*/
        #endregion
        #endregion

        #region 网络检测

        //InternetGetConnectedState返回的状态标识位的含义：
        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;
        private const int INTERNET_CONNECTION_PROXY = 4;
        private const int INTERNET_CONNECTION_MODEM_BUSY = 8;

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag, int dwReserved);
        /// <summary>
        /// 判断本地连接状态
        /// </summary>
        /// <returns></returns>
        public static bool LocalConnectionStatus()
        {
            Int32 dwFlag = new Int32();
            if (!InternetGetConnectedState(ref dwFlag, 0))
            {
                //Console.WriteLine("LocalConnectionStatus--未连网!");
                return false;
            }
            else
            {
                if ((dwFlag & INTERNET_CONNECTION_MODEM) != 0)
                {
                    //采用调制解调器上网
                    return true;
                }
                if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
                {
                    //采用网卡上网
                    return true;
                }

                if ((dwFlag & INTERNET_CONNECTION_PROXY) != 0)
                {
                    //采用代理上网
                    return true;
                }
                if ((dwFlag & INTERNET_CONNECTION_MODEM_BUSY) != 0)
                {
                    //MODEM被其他非INTERNET连接占用
                    return true;
                }
            }
            return false;
        }

        private static Ping ping;
        /// <summary>
        /// Ping命令检测网络是否畅通
        /// </summary>
        /// <param name="urls">URL数据</param>
        /// <param name="errorCount">ping时连接失败个数</param>
        /// <returns></returns>
        public static bool MyPing(string url)
        {
            bool result = false;
            ping = new Ping();
            try
            {
                if (ping.Send(url).Status == IPStatus.Success)
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }
        #endregion
    }
}