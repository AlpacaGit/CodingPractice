using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Alpaca.Common.Gadget;

namespace Alpaca.Repository.Provider
{
    /// <summary>
    /// XMLによる鳴動スケジュール設定の読み書きクラス
    /// </summary>
    public class XMLScheduleReadNWriter
    {
        #region 定数

        /// <summary>
        /// 未指定時のXMLファイルパス
        /// </summary>
        public const string DEFAULT_XML_FILEPATH = "AlertSchedule.xml";

        #endregion

        #region プロパティ

        /// <summary>
        /// XMLファイルのパス
        /// </summary>
        private readonly string XmlFilePath;

        /// <summary>
        /// XML XElement
        /// </summary>
        private XElement XMLElement;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// デフォルトXMLファイルパスで読み込む
        /// </summary>
        public XMLScheduleReadNWriter()
        {
            XmlFilePath = DEFAULT_XML_FILEPATH;
        }

        /// <summary>
        /// 指定されたXMLファイルパスで読み込む
        /// </summary>
        /// <param name="filePath"></param>
        public XMLScheduleReadNWriter(string filePath)
        {
            XmlFilePath = filePath;
        }

        /// <summary>
        /// スケジュール設定リストを取得する。
        /// </summary>
        /// <returns></returns>
        public List<Alpaca.Repository.Model.AlertSchedule> GetAlertScheduleList()
        {
            List<Alpaca.Repository.Model.AlertSchedule> alertScheduleList = new List<Model.AlertSchedule>();

            try
            {
                //xmlファイルを指定する
                XMLElement = XElement.Load(@XmlFilePath);

                //メンバー情報のタグ内の「名前」の情報を取得する
                IEnumerable<XElement> infos = from item
                                            in XMLElement.Elements(ConstInfo.XMLSettingElements.ALERT_NOTIFY_SETTING)
                                              select item;


                foreach (XElement aInfo in infos)
                {
                    Alpaca.Repository.Model.AlertSchedule alertSchedule = new Alpaca.Repository.Model.AlertSchedule();
                    alertSchedule.ScheduleTime = aInfo.Element(ConstInfo.AlertNotifySettings.SCHEDULE_TIME).Value;
                    alertSchedule.ScheduleName = aInfo.Element(ConstInfo.AlertNotifySettings.SCHEDULE_NAME).Value;
                    alertSchedule.RingingType = aInfo.Element(ConstInfo.AlertNotifySettings.RINGING_TYPE).Value;
                    alertSchedule.RingingRepeat = Boolean.Parse(aInfo.Element(ConstInfo.AlertNotifySettings.RINGING_REPEAT).Value);
                    alertScheduleList.Add(alertSchedule);
                }
                alertScheduleList = alertScheduleList.OrderBy(x => x.ScheduleTime).ToList();

            }
            catch (Exception e)
            {
                throw e;
            }

            return alertScheduleList;
        }


        #endregion
    }
}
