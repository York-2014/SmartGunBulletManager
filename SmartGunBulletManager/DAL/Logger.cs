using SmartGunBulletManager.IDAL;
using System;
using System.IO;
using System.Security.AccessControl;

namespace SmartGunBulletManager.DAL
{
    public class Logger : ILogger
    {
        enum LogLevel
        {
            Debug,
            Info,
            Error
        }

        private string LoggerPath { set; get; }

        public Logger()
        {
            LoggerPath = Utils.Config.LogPath;            
        }

        public void Debug(object message)
        {
            WirteLog(message, null, LogLevel.Debug);
        }

        public void Debug(object message, Exception exception)
        {
            WirteLog(message, exception, LogLevel.Debug);
        }

        public void Info(object message)
        {
            WirteLog(message, null, LogLevel.Info);
        }

        public void Info(object message, Exception exception)
        {
            WirteLog(message, exception, LogLevel.Info);
        }

        public void Error(object message)
        {
            WirteLog(message, null, LogLevel.Error);
        }

        public void Error(object message, Exception exception)
        {
            WirteLog(message, exception, LogLevel.Error);
        }

        private void WirteLog(object message, Exception exception, LogLevel level)
        {
            string strLog = string.Empty;
            if (null != exception)
            {
                strLog = string.Format("{0}\r\n{1}\r\n{2}", message.ToString(), exception.Message, exception.StackTrace);
            }
            else
            {
                strLog = message.ToString();
            }
            string savePath = string.Format("{0}\\Log\\{1}\\{2}.txt", LoggerPath, level.ToString(), System.DateTime.Now.ToString("yyyy-MM-dd"));
            string saveFolder = Path.GetDirectoryName(savePath);
            if (!System.IO.Directory.Exists(saveFolder))
            {
                System.IO.Directory.CreateDirectory(saveFolder);
                DirectorySecurity secu = new DirectorySecurity(Path.GetDirectoryName(savePath), AccessControlSections.Access);
                FileSystemAccessRule fsar = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow);
                secu.SetAccessRule(fsar);
                System.IO.Directory.SetAccessControl(saveFolder, secu);
            }
            using (StreamWriter sw = new StreamWriter(savePath, true))
            {
                sw.WriteLine(string.Format("【{0}】\r\n  {1}\r\n", DateTime.Now.ToString("HH:mm:ss"), strLog));
            }
        }
    }
}