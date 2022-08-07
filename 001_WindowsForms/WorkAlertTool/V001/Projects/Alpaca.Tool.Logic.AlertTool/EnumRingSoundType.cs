using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Tool.Logic.AlertTool
{
    /// <summary>
    /// 鳴動音声種別
    /// </summary>
    public enum EnumRingSoundType
    {
        /// <summary>
        /// 通常チャイム
        /// </summary>
        NORMAL_CHIME = 0,
        /// <summary>
        /// そろそろ業務終了
        /// </summary>
        WORK_CLOSING,
    }
}
