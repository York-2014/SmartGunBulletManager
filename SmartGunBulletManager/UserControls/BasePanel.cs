using System.Drawing;
using System.Windows.Forms;

namespace SmartGunBulletManager.UserControls
{
    public class BasePanel : UserControl
    {
        public BasePanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(180, 40, 60, 82);
        }
    }
}
