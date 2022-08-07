using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Common.Gadget
{
    /// <summary>
    /// 設定データクラス
    /// </summary>
    public static class SettingData
    {
        /// <summary>
        /// 接続先の SQL Server インスタンス
        /// </summary>
        public const string DB_DATASOURCE = @"localhost\SQLEXPRESS";

        /// <summary>
        /// 接続ユーザ名
        /// </summary>
        public const string DB_USERID = "sa";

        /// <summary>
        /// 接続パスワード
        /// </summary>
        public const string DB_PASSWORD = "admin@saba";

        /// <summary>
        /// 接続するデータベース
        /// </summary>
        public const string DB_INITIAL_CATALOG = "Chiebukuro";
        
    }
}
