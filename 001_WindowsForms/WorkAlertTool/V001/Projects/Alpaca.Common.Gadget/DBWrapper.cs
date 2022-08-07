using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Alpaca.Common.Gadget
{
    /// <summary>
    /// データベースに接続するためのラッパー
    /// 通常はSettingDataで設定された設定DBに接続します。
    /// </summary>
    public class DBWrapper:IDisposable
    {
        /// <summary>
        /// 接続先の SQL Server インスタンス
        /// </summary>
        private string _dbDataSource = SettingData.DB_DATASOURCE;

        /// <summary>
        /// 接続ユーザ名
        /// </summary>
        private string _dbUserID = SettingData.DB_USERID;

        /// <summary>
        /// 接続パスワード
        /// </summary>
        private string _dbPassWord = SettingData.DB_PASSWORD;

        /// <summary>
        /// 接続するデータベース(変更しない)
        /// </summary>
        private string _dbInitialCatalog = SettingData.DB_INITIAL_CATALOG;

        /// <summary>
        /// SQL接続文字列ビルダー
        /// </summary>
        private SqlConnectionStringBuilder _builder;

        /// <summary>
        /// SQLコネクション
        /// </summary>
        private SqlConnection _connection;

        /// <summary>
        /// SQLコマンド
        /// </summary>
        public SqlCommand sqlCommand;

        /// <summary>
        /// SQLデータリーダー
        /// </summary>
        private SqlDataReader sqlDataReader;

        /// <summary>
        /// SQLトランザクション
        /// </summary>
        private SqlTransaction sqlTransaction;

        /// <summary>
        /// 未実装
        /// </summary>
        /// <param name="dbType"></param>
        public DBWrapper(EnumDBType dbType)
        {

        }

        /// <summary>
        /// 未実装
        /// </summary>
        public DBWrapper()
        {

        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~DBWrapper()
        {

        }

        /// <summary>
        /// Disposeメソッド
        /// </summary>
        public void Dispose()
        {
            try
            {
                //トランザクションがあればコミットします。
                if (sqlTransaction != null)
                {
                    sqlTransaction.Commit();
                    sqlTransaction = null;
                }
            }
            catch (Exception)
            {
                //特に何もしない。
            }
            try
            {
                //SQL接続があればクローズします。
                if (_connection != null)
                {
                    _connection.Close();
                    _connection = null;
                }
            }
            catch (Exception)
            {
                //特に何もしない。
            }

        }

        /// <summary>
        /// データベース接続設定を行う。現状設定DBしか実装してない。
        /// </summary>
        /// <param name="dBType"></param>
        private void SetDBSetting(EnumDBType dBType)
        {
            switch (dBType)
            {
                case EnumDBType.REPOSITORY:
                    _dbDataSource = SettingData.DB_DATASOURCE;
                    _dbUserID = SettingData.DB_USERID;
                    _dbPassWord = SettingData.DB_PASSWORD;
                    _dbInitialCatalog = SettingData.DB_INITIAL_CATALOG;
                    break;

            }

        }

        /// <summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTransaction()
        {
            // 接続文字列を構築
            if(_builder == null)
            {
                _builder = new SqlConnectionStringBuilder();
                _builder.DataSource = _dbDataSource;   // 接続先の SQL Server インスタンス
                _builder.UserID = _dbUserID;              // 接続ユーザー名
                _builder.Password = _dbPassWord; // 接続パスワード
                _builder.InitialCatalog = _dbInitialCatalog;
            }
            
            //コネクションがnullなら新規接続を開始
            if(_connection == null)
            {
                _connection = new SqlConnection(_builder.ConnectionString);
                _connection.Open();
            }

            sqlTransaction = _connection.BeginTransaction();
        }

        /// <summary>
        /// 
        /// </summary>
        public int ExecuteNonQuery()
        {
            return sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        // ExecuteReader処理
        /// </summary>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteReader()
        {
            if(sqlCommand.Connection == null)
            {
                //単純なリーダーでもトランザクション開始する。
                sqlCommand.Connection = new SqlConnection(_builder.ConnectionString);
                sqlCommand.Connection.Open();
            }
            return sqlCommand.ExecuteReader();
        }

        /// <summary>
        /// トランザクションをコミットします。
        /// </summary>
        public void CommitTransaction()
        {
            sqlTransaction.Commit();
        }
    }
}
