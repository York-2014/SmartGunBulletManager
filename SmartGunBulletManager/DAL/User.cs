using SmartGunBulletManager.BLL;
using SmartGunBulletManager.Entity;
using SmartGunBulletManager.IDAL;
using SmartGunBulletManager.Utils.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.DAL
{
    public class User : IUser
    {
        private string strDataSource = string.Empty;

        public User(string dataSourceString)
        {
            this.strDataSource = dataSourceString;
        }

        public UserEntity CheckLoginByPwd(BLL.User.RoleType userType, string userNumber, string pwd)
        {
            UserEntity result = null;
            using (SQLiteConnection conn = new SQLiteConnection(strDataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    List<SQLiteParameter> lstParamerters = new List<SQLiteParameter>();
                    SQLiteParameter sqliteParameter = new SQLiteParameter();
                    sqliteParameter.ParameterName = "@RoleType";
                    sqliteParameter.DbType = DbType.Int32;
                    sqliteParameter.Value = userType;
                    lstParamerters.Add(sqliteParameter);
                    sqliteParameter = new SQLiteParameter();
                    sqliteParameter.ParameterName = "@UserNumber";
                    sqliteParameter.DbType = DbType.String;
                    sqliteParameter.Value = userNumber;
                    lstParamerters.Add(sqliteParameter);
                    sqliteParameter = new SQLiteParameter();
                    sqliteParameter.ParameterName = "@PWD";
                    sqliteParameter.DbType = DbType.String;
                    sqliteParameter.Value = Utils.Common.GetMd5Hash(pwd);
                    lstParamerters.Add(sqliteParameter);
                    DataTable dt = sh.Select("SELECT * FROM [user] WHERE roleid=@RoleType AND usernumber=@UserNumber AND password=@PWD;", lstParamerters);
                    //List<UserEntity> lstUser = new List<UserEntity>();
                    //lstUser = Utils.DataTableUtility.ToList<UserEntity>(dt) as List<UserEntity>;
                    if (dt.Rows.Count == 1)
                    {
                        result = new UserEntity();
                        result = Utils.DataTableUtility.ToEntity<UserEntity>(dt.Rows[0]);
                    }
                    conn.Close();
                }
            }
            return result;
        }

        public UserEntity CheckLoginByFingerprint(BLL.User.RoleType userType, string user, object fingerprintInfo)
        {
            UserEntity result = new UserEntity();
            return result;
        }
    }
}