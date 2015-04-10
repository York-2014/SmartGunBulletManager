using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SmartGunBulletManager.Utils
{
    /// <summary>
    /// RSA加密解密
    /// </summary>
    public class RSA
    {
        #region RSA
        public struct RSAKey
        {
            /// <summary>
            /// 公钥
            /// </summary>
            public string PublicKey { get; set; }

            /// <summary>
            /// 私钥
            /// </summary>
            public string PrivateKey { get; set; }
        }

        /// <summary>
        /// 获取RSA密钥(公钥和私钥)
        /// </summary>
        /// <returns></returns>
        public static RSAKey GetRASKey()
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
            return new RSAKey()
            {
                PublicKey = rsaProvider.ToXmlString(false),
                PrivateKey = rsaProvider.ToXmlString(true)
            };
        }

        /// <summary>
        /// 用公钥对字符串加密
        /// </summary>
        /// <param name="strData">待加密的字符串</param>
        /// <param name="PublicKey">公钥字符串</param>
        /// <returns></returns>
        public static string RSAEncryptData(string strData, string PublicKey)
        {
            byte[] data = Encoding.Default.GetBytes(strData);
            byte[] result = RSAEncryptData(data, PublicKey);
            return Convert.ToBase64String(result);
        }

        /// <summary>
        /// 用公钥对byte数组加密
        /// </summary>
        /// <param name="data">待加密的byte数组</param>
        /// <param name="PublicKey">公钥字符串</param>
        /// <returns></returns>
        public static byte[] RSAEncryptData(byte[] data, string PublicKey)
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
            //将公钥导入到RSA对象中，准备加密；
            rsaProvider.FromXmlString(PublicKey);
            //对数据data进行加密，并返回加密结果；
            //第二个参数用来选择Padding的格式
            return rsaProvider.Encrypt(data, false);
        }

        /// <summary>
        /// 用私钥对字符串解密
        /// </summary>
        /// <param name="strData">待解密的字符串</param>
        /// <param name="PrivateKey">私钥字符串</param>
        /// <returns></returns>
        public static string RSADecryptData(string strData, string PrivateKey)
        {
            byte[] data = Convert.FromBase64String(strData);
            byte[] result = RSADecryptData(data, PrivateKey);
            return Encoding.Default.GetString(result);
        }

        /// <summary>
        /// 用私钥对byte数组解密
        /// </summary>
        /// <param name="data">待解密的字符串</param>
        /// <param name="PrivateKey">私钥字符串</param>
        /// <returns></returns>
        public static byte[] RSADecryptData(byte[] data, string PrivateKey)
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
            //将私钥导入RSA中，准备解密；  
            rsaProvider.FromXmlString(PrivateKey);
            //对数据进行解密，并返回解密结果；
            return rsaProvider.Decrypt(data, false);
        }

        /// <summary>
        /// 用公钥和签名byte数组验证字符串数据是否通过
        /// </summary>
        /// <param name="data"></param>
        /// <param name="Signature"></param>
        /// <param name="PublicKey"></param>
        /// <returns></returns>
        public static bool RSAVerify(string data, byte[] Signature, string PublicKey)
        {
            return RSAVerify(Encoding.UTF8.GetBytes(data), Signature, PublicKey);
        }

        /// <summary>
        /// 用公钥和签名byte数组验证byte数组数据是否通过
        /// </summary>
        /// <param name="data"></param>
        /// <param name="Signature"></param>
        /// <param name="PublicKey"></param>
        /// <returns></returns>
        public static bool RSAVerify(byte[] data, byte[] Signature, string PublicKey)
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
            //导入公钥，准备验证签名  
            rsaProvider.FromXmlString(PublicKey);
            //返回数据验证结果  
            return rsaProvider.VerifyData(data, "MD5", Signature);
        }

        /// <summary>
        /// 用私钥对字符串数据产生数字签名
        /// </summary>
        /// <param name="data"></param>
        /// <param name="PrivateKey"></param>
        /// <returns></returns>
        public static byte[] RSASign(string data, string PrivateKey)
        {
            return RSASign(Encoding.UTF8.GetBytes(data), PrivateKey);
        }

        /// <summary>
        /// 用私钥对byte数组数据产生数字签名
        /// </summary>
        /// <param name="data"></param>
        /// <param name="PrivateKey"></param>
        /// <returns></returns>
        public static byte[] RSASign(byte[] data, string PrivateKey)
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024);
            //导入私钥，准备签名  
            rsaProvider.FromXmlString(PrivateKey);
            //将数据使用MD5进行消息摘要，然后对摘要进行签名并返回签名数据  
            return rsaProvider.SignData(data, "MD5");
        }
        #endregion

        #region RSA加密解密Demo
        //RSA.RSAKey rsaKey = RSA.GetRASKey();

            //string temp = "测试Rsa加密";
            
            ////加密
            //temp = RSA.RSAEncryptData(temp, rsaKey.PublicKey);

            ////给数据签名
            //byte[] sign = RSA.RSASign(temp, rsaKey.PrivateKey);

            ////服务器验证加密的数据是否有效
            //bool resultVerifyed = RSA.RSAVerify(temp, sign, rsaKey.PublicKey);

            ////服务器解密
            //string resultDecrypted = RSA.RSADecryptData(temp, rsaKey.PrivateKey);
        #endregion
    }
}