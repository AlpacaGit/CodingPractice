using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Tool.Logic.AlertTool
{
    /// <summary>
    /// 定数用クラス (インスタンス生成禁止)
    /// </summary>
    public class ConstInfo
    {
        private ConstInfo()
        {
            //空のコンストラクタをprivateにして見えなくする。
        }

        /// <summary>
        /// アラート種別
        /// </summary>
        public class AlertType
        {
            /// <summary>
            /// 通常チャイム
            /// </summary>
            public const string NormalChime = "NormalChime";

            /// <summary>
            /// そろそろ業務終了
            /// </summary>
            public const string WorkClosing = "WorkClosing";
        }
    }
}
