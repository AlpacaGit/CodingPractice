using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Repository.Model
{
    /// <summary>
    /// データモデルクラス。
    /// </summary>
    interface IDataModel
    {
        /// <summary>
        /// クラスプロパティの初期値を設定する。
        /// </summary>
        void Init();
    }
}
