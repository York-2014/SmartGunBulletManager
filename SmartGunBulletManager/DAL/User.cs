using SmartGunBulletManager.IDAL;
using SmartGunBulletManager.Utils;
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

        public bool CheckLogin(string user, string pwd)
        {
            bool result = false;
            using (SQLiteConnection conn = new SQLiteConnection(strDataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    List<SQLiteParameter> lstParamerters = new List<SQLiteParameter>();
                    SQLiteParameter sqliteParameter = new SQLiteParameter();
                    sqliteParameter.ParameterName = "@user";
                    sqliteParameter.DbType = DbType.String;
                    sqliteParameter.Value = user;
                    lstParamerters.Add(sqliteParameter);
                    sqliteParameter = new SQLiteParameter();
                    sqliteParameter.ParameterName = "@pwd";
                    sqliteParameter.DbType = DbType.String;
                    sqliteParameter.Value = pwd;
                    lstParamerters.Add(sqliteParameter);
                    DataTable dt = sh.Select("Select Count(id) From [user] where name=@user and password=@pwd;", lstParamerters);
                    result = Convert.ToBoolean(dt.Rows[0][0]);
                    conn.Close();
                }
            }
            return result;
        }
    }
}