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
    public partial class FormSelectPreset : Form
    {
        public FormSelectPreset()
        {
            InitializeComponent();
        }

        #region プロパティ
        /// <summary>
        /// ダイアログの処理結果
        /// </summary>
        public DialogResult DialogResult = DialogResult.Cancel;

        /// <summary>
        /// 画面で選択されたプリセットの名前
        /// </summary>
        public String selectedPresetName = "";
        #endregion

        /// <summary>
        /// プリセット名
        /// </summary>
        private const string COL_PRESET_NAME = "PresetName";

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



        #region プリセット情報

        public DataTable presetDataTable = new DataTable();

        #endregion


        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //var aSelectRow = dgvPreset.SelectedRows;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// フォームが読み込まれたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSelectPreset_Load(object sender, EventArgs e)
        {
            //presetDataTable.Columns.Add(COL_SCHEDULE_TIME);
            //presetDataTable.Columns.Add(COL_SCHEDULE_NAME);
            //presetDataTable.Columns.Add(COL_PLAY_TYPE);

            presetDataTable.Rows.Clear();
            DataRow aPresetRow;
            #region 従来方式

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "09:00";
            //aPresetRow[COL_SCHEDULE_NAME] = "業務開始";
            //aPresetRow[COL_PLAY_TYPE] = "チャイム";
            //presetDataTable.Rows.Add(aPresetRow);

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "12:00";
            //aPresetRow[COL_SCHEDULE_NAME] = "昼休憩 開始";
            //aPresetRow[COL_PLAY_TYPE] = "チャイム";
            //presetDataTable.Rows.Add(aPresetRow);

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "13:00";
            //aPresetRow[COL_SCHEDULE_NAME] = "昼休憩 終了";
            //aPresetRow[COL_PLAY_TYPE] = "チャイム";
            //presetDataTable.Rows.Add(aPresetRow);

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "17:00";
            //aPresetRow[COL_SCHEDULE_NAME] = "夕礼";
            //aPresetRow[COL_PLAY_TYPE] = "チャイム";
            //presetDataTable.Rows.Add(aPresetRow);

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "17:30";
            //aPresetRow[COL_SCHEDULE_NAME] = "日報提出時間";
            //aPresetRow[COL_PLAY_TYPE] = "チャイム";
            //presetDataTable.Rows.Add(aPresetRow);

            //aPresetRow = presetDataTable.NewRow();
            //aPresetRow[COL_SCHEDULE_TIME] = "17:55";
            //aPresetRow[COL_SCHEDULE_NAME] = "定時5分前";
            //aPresetRow[COL_PLAY_TYPE] = "蛍の光";
            //presetDataTable.Rows.Add(aPresetRow);

            #endregion


            Alpaca.Repository.Provider.XMLScheduleReadNWriter xmlSchedule = new Repository.Provider.XMLScheduleReadNWriter();
            List<Alpaca.Repository.Model.AlertSchedule> AlertScheduleList = new List<Repository.Model.AlertSchedule>();
            AlertScheduleList = xmlSchedule.GetAlertScheduleList();
            foreach(Alpaca.Repository.Model.AlertSchedule aSchedule in AlertScheduleList)
            {
                aPresetRow = presetDataTable.NewRow();
                aPresetRow[COL_SCHEDULE_TIME] = aSchedule.ScheduleTime;
                aPresetRow[COL_SCHEDULE_NAME] = aSchedule.ScheduleName;
                //一旦鳴動種別は直書きで。
                string aType = "";
                if(aSchedule.RingingType == "HOTARU")
                {
                    aType = "蛍の光";
                }
                else
                {
                    aType = "チャイム";
                }
                aPresetRow[COL_PLAY_TYPE] = aType;
                presetDataTable.Rows.Add(aPresetRow);
            }


            //データグリッドにバインド
            dgvPreset.DataSource = presetDataTable;
        
            
        }
    }
}
