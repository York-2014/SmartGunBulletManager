using SmartGunBulletManager.Utils;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace SmartGunBulletManager.BLL
{
    /// <summary>
    /// 电控锁控制类
    /// </summary>
    public class LockController
    {
        private SerialPort serialPort = null;

        private readonly List<byte[]> lstOpenCommands = new List<byte[]>() { 
                new byte[] { 0xFE, 0x05, 0x00, 0x00, 0xFF, 0x00, 0x98, 0x35 },    //1
                new byte[] { 0xFE, 0x05, 0x00, 0x01, 0xFF, 0x00, 0xC9, 0xF5 },    //2
                new byte[] { 0xFE, 0x05, 0x00, 0x02, 0xFF, 0x00, 0x39, 0xF5 },    //3
                new byte[] { 0xFE, 0x05, 0x00, 0x03, 0xFF, 0x00, 0x68, 0x35 },    //4
                                                           
                new byte[] { 0xFE, 0x05, 0x00, 0x04, 0xFF, 0x00, 0xD9, 0xF4 },    //5
                new byte[] { 0xFE, 0x05, 0x00, 0x05, 0xFF, 0x00, 0x88, 0x34 },    //6
                new byte[] { 0xFE, 0x05, 0x00, 0x06, 0xFF, 0x00, 0x78, 0x34 },    //7
                new byte[] { 0xFE, 0x05, 0x00, 0x07, 0xFF, 0x00, 0x29, 0xF4 },    //8
                                                           
                new byte[] { 0xFE, 0x05, 0x00, 0x08, 0xFF, 0x00, 0x19, 0xF7 },    //9
                new byte[] { 0xFE, 0x05, 0x00, 0x09, 0xFF, 0x00, 0x48, 0x37 },    //10
                new byte[] { 0xFE, 0x05, 0x00, 0x0A, 0xFF, 0x00, 0xB8, 0x37 },    //11
                new byte[] { 0xFE, 0x05, 0x00, 0x0B, 0xFF, 0x00, 0xE9, 0xF7 },    //12
                                                           
                new byte[] { 0xFE, 0x05, 0x00, 0x0C, 0xFF, 0x00, 0x58, 0x36 },    //13
                new byte[] { 0xFE, 0x05, 0x00, 0x0D, 0xFF, 0x00, 0x09, 0xF6 },    //14
                new byte[] { 0xFE, 0x05, 0x00, 0x0E, 0xFF, 0x00, 0xF9, 0xF6 },    //15
                new byte[] { 0xFE, 0x05, 0x00, 0x0F, 0xFF, 0x00, 0xA8, 0x36 }     //16
        };

        public bool Init(string strCommNumber, int baudRate)
        {
            bool result = false;
            serialPort = new SerialPort();
            //设置串口的端口
            serialPort.PortName = strCommNumber;
            //设置波特率
            serialPort.BaudRate = baudRate;
            //设置停止位
            serialPort.StopBits = StopBits.One;
            //设置校验位
            serialPort.Parity = Parity.None;
            //设置数据位
            serialPort.DataBits = 8;
            serialPort.ReceivedBytesThreshold = 20;
            serialPort.ReadTimeout = 200;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(CommDataReceived);
            try
            {
                //打开串口
                serialPort.Open();
                //写入信息日志
                LogHelper.logger.Info("电控锁串口打开成功！");
                result = true;
            }
            catch (Exception ex)
            {
                //写入异常日志
                LogHelper.logger.Error("电控锁串口打开失败", ex);
                result = false;
            }
            return result;
        }

        //串口数据处理函数
        public void CommDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            //Comm.BytesToRead中为要读入的字节长度
            int len = serialPort.BytesToRead;
            //保存串口读取的数据
            Byte[] readBuffer = new Byte[len];
            //Logger.log.Info("串口返回字符串的长度：" + len);
            //将数据读入缓存
            serialPort.Read(readBuffer, 0, len);
            Byte[] tmp = readBuffer;
        }

        public bool SendOpenLockCommand(int lockAddress)
        {
            bool result = false;
            lock (this)
            {
                try
                {
                    serialPort.DiscardInBuffer();
                    serialPort.Write(lstOpenCommands[lockAddress - 1], 0, 8);
                    result = true;
                }
                catch (Exception ex)
                {
                    //写入异常日志
                    LogHelper.logger.Error(string.Format("{0}号电控锁打开失败", lockAddress), ex);
                    result = false;
                }
            }
            return result;
        }
    }
}
