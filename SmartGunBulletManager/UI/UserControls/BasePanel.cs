using SmartGunBulletManager.UI.Forms;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SmartGunBulletManager.UI.UserControls
{
    public class BasePanel : UserControl
    {
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public BasePanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(180, 40, 60, 82);
            this.UpdateStyles();
        }
        #endregion

        #region 获取主窗体
        /// <summary>
        /// 获取主窗体
        /// </summary>
        /// <returns></returns>
        public MainForm GetMainForm()
        {
            return (MainForm)TopLevelControl;
        }
        #endregion

        #region 控件字体颜色闪烁
        /// <summary>
        /// 控件字体颜色闪烁
        /// </summary>
        /// <param name="ctl">要闪烁的控件</param>
        /// <param name="anotherForeColor">闪烁的另外一种颜色</param>
        public void TwinkleControlFontColor(Control ctl, Color anotherForeColor)
        {
            Color ctlForeColor = ctl.ForeColor;
            ctl.ForeColor = anotherForeColor;
            Application.DoEvents();
            Thread.Sleep(100);
            ctl.ForeColor = ctlForeColor;
        }
        #endregion
    }
}