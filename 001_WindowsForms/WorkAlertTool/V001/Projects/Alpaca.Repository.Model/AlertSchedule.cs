using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Repository.Model
{
    [Serializable]
    public class AlertSchedule : IDataModel
    {

        /// <summary>
        /// 空の通知スケジュール
        /// </summary>
        public AlertSchedule()
        {
            Init();
        }

        private string _ScheduleTime;
        /// <summary>
        /// スケジュール時間
        /// </summary>
        public string ScheduleTime
        {
            get
            {
                return _ScheduleTime;
            }
            
            set
            {
                //入力値がDateTime型に変換できる場合は HH:mm の書式で設定
                //そうでない場合は入力前の値に戻す。
                bool isTime = false;
                string beforeStrTime = _ScheduleTime;
                DateTime aDateTime = new DateTime();
                isTime = DateTime.TryParse(value.ToString(),out aDateTime);
                _ScheduleTime = isTime ? aDateTime.ToString("HH:mm") : beforeStrTime;
            }
        }

        private string _ScheduleName;
        /// <summary>
        /// スケジュール名称
        /// </summary>
        public string ScheduleName
        {
            get;set;
        }

        private string _RingingType;
        /// <summary>
        /// 鳴動タイプ
        /// </summary>
        public string RingingType
        {
            get
            {
                return _RingingType;
            }
            set
            {
                _RingingType = value;
            }
        }

        private bool _RingingRepeat;
        /// <summary>
        /// 鳴動サウンドを繰り返すか。
        /// </summary>
        public bool RingingRepeat
        {
            get { return _RingingRepeat; }
            set { _RingingRepeat = value; }
        }


        /// <summary>
        /// クラスプロパティに初期値を設定する。
        /// </summary>
        public void Init()
        {
            this._ScheduleTime = "00:00";
            this._ScheduleName = "名称未設定";
            this._RingingType = "";
            this._RingingRepeat = false;

        }


    }
}
