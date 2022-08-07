using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Alpaca.Repository.Model.ViewModel
{
    public class AlertTool : IViewModel
    {
        private AlertSchedule[] _AlertSchedules;
        /// <summary>
        /// 複数のアラートスケジュールを保持している配列
        /// </summary>
        public AlertSchedule[] AlertSchedules
        {
            get
            {
                return _AlertSchedules;
            }
            set
            {
                _AlertSchedules = value;
            }
        }

        private bool _IsRunning;
        /// <summary>
        /// スケジュールの動作状態
        /// </summary>
        public bool IsRunning
        {
            get
            {
                return _IsRunning;
            }

            set
            {
                _IsRunning = value;
            }
        }

        private List<string> _AlertType;
        public List<string> AlertType
        {
            get { return _AlertType; }
            set { _AlertType = value; }
        }
        
        /// <summary>
        /// 初期化する。
        /// </summary>
        public void Init()
        {
            _IsRunning = false;
        }



    }
}
