using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpaca.Tool.UI.AlertTool
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }

        private string scheduleTime = "";
        private string scheduleName = "";
        private int closeTimeMilisecond = 0;


        /// <summary>
        /// コンストラクタ 再生される時間、スケジュール名、自動で閉じるまでの秒数をセット
        /// </summary>
        /// <param name="scheduleTime">スケジュール時間時間</param>
        /// <param name="scheduleName">スケジュール名</param>
        /// <param name="closeTimeMilisecond">自動で子画面を閉じるまでの時間</param>
        public FormAlert(string scheduleTime, string scheduleName ,int closeTimeMilisecond = 0)
        {
            this.scheduleTime = scheduleTime;
            this.scheduleName = scheduleName;
            this.closeTimeMilisecond = closeTimeMilisecond;

        }



        /// <summary>
        /// 閉じるボタンがクリックされた
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// クローズタイマーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// フォームが読み込まれたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAlert_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblTime.Text = this.scheduleTime;
            lblEventName.Text = this.scheduleName;

            if (this.closeTimeMilisecond != 0)
            {
                closeTimer.Interval = closeTimeMilisecond;
                closeTimer.Enabled = true;
            }
            else
            {
                closeTimer.Enabled = false;
            }
        }
    }
}
