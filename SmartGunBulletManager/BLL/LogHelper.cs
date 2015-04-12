using SmartGunBulletManager.IDAL;

namespace SmartGunBulletManager.BLL
{
    /// <summary>
    /// Log操作类
    /// </summary>
    public class LogHelper
    {
        public static readonly ILogger logger = new DAL.Logger();
    }
}