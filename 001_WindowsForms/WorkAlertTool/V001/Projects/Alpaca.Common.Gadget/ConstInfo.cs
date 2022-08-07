using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Common.Gadget
{
    /// <summary>
    /// 定数クラス
    /// </summary>
    public class ConstInfo
    {
        /// <summary>
        /// XML設定種別 要素名
        /// </summary>
        public class XMLSettingElements
        {
            public const string ALERT_NOTIFY_SETTING = "AlertNotifySetting";
        }

        /// <summary>
        /// アラートスケジュール AlertSchedule.xmlにおける要素名
        /// </summary>
        public class AlertNotifySettings
        {
            /// <summary>
            /// 鳴動時刻
            /// </summary>
            public const string SCHEDULE_TIME = "ScheduleTime";

            /// <summary>
            /// スケジュール名称
            /// </summary>
            public const string SCHEDULE_NAME = "ScheduleName";

            /// <summary>
            /// 鳴動種別
            /// </summary>
            public const string RINGING_TYPE = "RingingType";

            /// <summary>
            /// 鳴動サウンドを繰り返すかどうか。
            /// </summary>
            public const string RINGING_REPEAT = "RingingRepeat";

        }
    }
}
