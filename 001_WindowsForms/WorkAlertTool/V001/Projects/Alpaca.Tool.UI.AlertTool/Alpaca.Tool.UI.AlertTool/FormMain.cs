using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Alpaca.Tool.UI.AlertTool
{
    public partial class FormMain : Form
    {
        #region テキストボックス 入力前の値
        private string beforeTxtBxPlayTime = "";

        #endregion


        /// <summary>
        /// スケジュールデータテーブル
        /// </summary>
        private DataTable scheduleDataTable = new DataTable();


        /// <summary>
        /// スケジュールタイマー 状態
        /// </summary>
        private bool isScheduleEnabled = false;

        /// <summary>
        /// 蛍の光 サウンドプレイヤー
        /// </summary>
        private System.Media.SoundPlayer hotaruSound = new SoundPlayer(".\\hotaru.wav");

        /// <summary>
        /// チャイム サウンドプレイヤー
        /// </summary>
        private System.Media.SoundPlayer chimeSound = new SoundPlayer(".\\chime.wav");

        /// <summary>
        /// アラートスケジュールリスト
        /// </summary>
        private List<Alpaca.Repository.Model.AlertSchedule> AlertScheduleList = new List<Repository.Model.AlertSchedule>();


        #region 定数

        /// <summary>
        /// スケジュール時間
        /// </summary>
        private const string COL_SCHEDULE_TIME = "ScheduleTime";

        /// <summary>
        /// スケジュール名称
        /// </summary>
        private const string COL_SCHEDULE_NAME = "ScheduleName";

        /// <summary>
        /// 鳴動種別
        /// </summary>
        private const string COL_PLAY_TYPE = "PlayType";

        /// <summary>
        /// 鳴動種別
        /// </summary>
        private const string HT_PLAY_TYPE = "鳴動種別";

        private const string HT_SCHEDULE_TIME = "再生時刻";

        private const string HT_SCHEDULE_NAME = "スケジュール名称";

        private const string BTN_TEXT_START = "開始";

        private const string BTN_TEXT_STOP = "停止";

        /// <summary>
        /// 鳴動スケジュール停止メッセージ
        /// </summary>
        private const string MSG_STOP_SCHEDULE = "鳴動スケジュールを停止しました。";

        List<string> dcScheduleType = new List<string>()
        {
            "チャイム","蛍の光"
        };

        #endregion

        public FormMain()
        {
            InitializeComponent();
            scheduleDataTable.Columns.Add(COL_SCHEDULE_TIME);
            scheduleDataTable.Columns.Add(COL_SCHEDULE_NAME);
            scheduleDataTable.Columns.Add(COL_PLAY_TYPE);

            dgvAlertList.DataSource = scheduleDataTable;
            //ソート禁止！
            for(int i = 0; i < dgvAlertList.Columns.Count; i++)
            {
                dgvAlertList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvAlertList.Columns[COL_SCHEDULE_TIME].HeaderText = HT_SCHEDULE_TIME;
            dgvAlertList.Columns[COL_SCHEDULE_TIME].Width = 150;
            dgvAlertList.Columns[COL_SCHEDULE_NAME].HeaderText = HT_SCHEDULE_NAME;
            dgvAlertList.Columns[COL_SCHEDULE_NAME].Width = 300;

            dgvAlertList.Columns[COL_PLAY_TYPE].HeaderText = HT_PLAY_TYPE;
            dgvAlertList.Columns[COL_PLAY_TYPE].Width = 90;
            
            cmbScheduleType.DataSource = dcScheduleType;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            
        }

        /// <summary>
        /// 蛍の光を再生する
        /// </summary>
        private void playHotaruSound()
        {
            //再生されていれば止める
            hotaruSound.Stop();
            hotaruSound = new SoundPlayer(Tool.Logic.AlertTool.RingFileManager.GetRingSoundPath(Logic.AlertTool.EnumRingSoundType.WORK_CLOSING));
            //再生する。
            hotaruSound.Play();
        }

        /// <summary>
        /// チャイムを再生する。
        /// </summary>
        private void playChimeSound()
        {
            //再生されていれば止める
            chimeSound.Stop();
            //再生する。
            chimeSound.Play();
        }

        /// <summary>
        /// フォーム読み込み時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            timerTime.Start();
            DataTable dtAlertTable = new DataTable();


        }

        /// <summary>
        /// 設定ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScheduleSetting_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            System.Media.SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = @"C:\Windows\Media\chord.wav";
            soundPlayer.PlayLooping();
            MessageBox.Show("未実装");
            soundPlayer.Stop();
        }

        private void btnScheduleAdd_Click(object sender, EventArgs e)
        {
            DataRow aDataRow = scheduleDataTable.NewRow();
            
            aDataRow[COL_SCHEDULE_TIME] = txtBxPlayTime.Text;
            aDataRow[COL_SCHEDULE_NAME] = txtBxScheduleName.Text;
            aDataRow[COL_PLAY_TYPE] = cmbScheduleType.Text;
            
            scheduleDataTable.Rows.Add(aDataRow);
            scheduleDataTable.DefaultView.Sort = COL_SCHEDULE_TIME + " ASC";

            txtBxScheduleName.Text = "";
            cmbScheduleType.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartNStopSchedule_Click(object sender, EventArgs e)
        {
            if (isScheduleEnabled)
            {
                DialogResult dr = MessageBox.Show("鳴動スケジュールを停止しますか？", "", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    isScheduleEnabled = false;
                    btnStartNStopSchedule.Text = BTN_TEXT_START;
                    MessageBox.Show(MSG_STOP_SCHEDULE);
                    scheduleTimer.Enabled = false;
                    dgvAlertList.ReadOnly = false;
                    btnRowDelete.Enabled = true;
                    hotaruSound.Stop();
                    chimeSound.Stop();
                }
                
            }
            else
            {
                isScheduleEnabled = true;
                btnStartNStopSchedule.Text = BTN_TEXT_STOP;
                scheduleTimer.Enabled = true;
                dgvAlertList.ReadOnly = true;
                btnRowDelete.Enabled = false;
            }

        }

        private bool _playingHotaru = false;
        /// <summary>
        /// 蛍の光 テスト再生ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayHotaru_Click(object sender, EventArgs e)
        {
            if (_playingHotaru)
            {
                hotaruSound.Stop();
                btnPlayHotaru.Text = "蛍の光 再生";
                _playingHotaru = false;
            }
            else
            {
                playHotaruSound();
                btnPlayHotaru.Text = "停止";
                _playingHotaru = true;
            }
        }

        /// <summary>
        /// スケジュールチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scheduleTimer_Tick(object sender, EventArgs e)
        {
            string aTime = DateTime.Now.ToString("HH:mm:ss");
            string aScheduleTime = "";
            string aSoundType = "";
            foreach (DataRow aSchedule in scheduleDataTable.Rows)
            {
                aScheduleTime = aSchedule[COL_SCHEDULE_TIME].ToString() + ":00";
                aSoundType = aSchedule[COL_PLAY_TYPE].ToString();
                if (aScheduleTime.Equals(aTime))
                {
                    switch (aSoundType)
                    {
                        case "蛍の光":
                            playHotaruSound();
                            break;
                        case "チャイム":
                            playChimeSound();
                            break;
                        default:
                            break;
                    }
                    FormAlert formAlert = new FormAlert(aScheduleTime, aSchedule[COL_SCHEDULE_NAME].ToString(), 10000);
                    formAlert.ShowDialog();
                }
            }
        }

        /// <summary>
        /// チャイム 再生ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayChime_Click(object sender, EventArgs e)
        {
            playChimeSound();
        }

        private void txtBxPlayTime_Validating(object sender, CancelEventArgs e)
        {
            bool validatedOK = DateTime.TryParse(txtBxPlayTime.Text, out DateTime test);
            if (!validatedOK)
            {
                //e.Cancel = true;
                txtBxPlayTime.Text = beforeTxtBxPlayTime;
                
            }
        }

        private void txtBxPlayTime_Enter(object sender, EventArgs e)
        {
            beforeTxtBxPlayTime = txtBxPlayTime.Text;
        }

        private void btnLoadPreset_Click(object sender, EventArgs e)
        {
            FormSelectPreset formSelectPreset = new FormSelectPreset();
            formSelectPreset.presetDataTable = scheduleDataTable;
            formSelectPreset.ShowDialog();
        }

        /// <summary>
        /// 時刻テキストボックス キー押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxPlayTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnScheduleAdd.PerformClick();
                txtBxPlayTime.Text = "";
            }
        }

        /// <summary>
        /// スケジュール削除 今のところ1個単位のみ対応。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRowDelete_Click(object sender, EventArgs e)
        {
            if (dgvAlertList.SelectedRows.Count < 1 || dgvAlertList.SelectedRows[0].Index < 0)
            {
                return;
            }

            dgvAlertList.Rows.RemoveAt(dgvAlertList.SelectedRows[0].Index);


        }
    }
}
