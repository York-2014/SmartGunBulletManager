using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartGunBulletManager.BLL;
using System.Threading;

namespace SmartGunBulletManager.UI.Forms
{
    public class BaseForm : Form
    {
        /// <summary>
        /// 外部获取或内部设置温度传感器的值.
        /// </summary>
        public int Temperature { get; private set; }

        /// <summary>
        /// 外部获取或内部设置湿度传感器的值.
        /// </summary>
        public int Humidity { get; private set; }

        /// <summary>
        /// 外部获取或内部设置酒精浓度传感器的值.
        /// </summary>
        public int AlcoholConcentration { get; private set; }

        /// <summary>
        /// 外部获取或内部设置电源状态.
        /// </summary>
        public Enums.PowerStatusType PowerState { get; private set; }

        /// <summary>
        /// 外部获取或内部设置网络状态.
        /// </summary>
        public Enums.NetworkStatusType NetworkState { get; private set; }

        /// <summary>
        /// 外部获取或内部设置服务器状态.
        /// </summary>
        public Enums.ServerStatusType ServerState { get; private set; }

        /// <summary>
        /// 获取当前时间字符串
        /// </summary>
        public string GetCurrentTimeString(string timeFormat)
        {
            return DateTime.Now.ToString(timeFormat);
        }

        /// <summary>
        /// 检查并更新所有状态
        /// </summary>
        public void CheckAndUpdateAllStatus()
        {
            CheckAndUpdateTemperature();
            CheckAndUpdateHumidity();
            CheckAndUpdateAlcoholConcentration();
            CheckAndUpdatePowerState();
            CheckAndUpdateNetworkState();
            CheckAndUpdateServerState();
        }

        /// <summary>
        /// 检查并更新温度
        /// </summary>
        public void CheckAndUpdateTemperature()
        {
            //TODO: 检查并更新温度
            Temperature = 10;
        }

        /// <summary>
        /// 检查并更新湿度
        /// </summary>
        public void CheckAndUpdateHumidity()
        {
            //TODO: 检查并更新湿度
            Humidity = 20;
        }

        /// <summary>
        /// 检查并更新酒精浓度
        /// </summary>
        public void CheckAndUpdateAlcoholConcentration()
        {
            //TODO: 检查并更新酒精浓度
            AlcoholConcentration = 30;
        }

        /// <summary>
        /// 检查并更新电源类型
        /// </summary>
        public void CheckAndUpdatePowerState()
        {
            if ("Online" == SystemInformation.PowerStatus.PowerLineStatus.ToString())
            {
                PowerState = Enums.PowerStatusType.Normal;
            }
            else
            {
                PowerState = Enums.PowerStatusType.Battery;
            }
        }

        /// <summary>
        /// 检查并更新网络连接状态
        /// </summary>
        public void CheckAndUpdateNetworkState()
        {
            if (Utils.Common.LocalConnectionStatus())
            {
                NetworkState = Enums.NetworkStatusType.Connected;
            }
            else
            {
                NetworkState = Enums.NetworkStatusType.Disconnect;
            }
        }

        /// <summary>
        /// 检查并更新服务器状态
        /// </summary>
        public void CheckAndUpdateServerState()
        {
            if (Utils.Common.MyPing("www.baidu.com"))
            {
                ServerState = Enums.ServerStatusType.Online;
            }
            else
            {
                ServerState = Enums.ServerStatusType.Offline;
            }
            ////TODO: 检查并更新服务器状态
            //if (false == string.IsNullOrEmpty(JsonRequest.jsonrequest.Execute("http://www.baidu.com").ToString()))
            //{
            //ServerState = Enums.ServerStatusType.Online;
            //}
            //else
            //{
            //    ServerState = Enums.ServerStatusType.Offline;
            //}
        }
    }
}