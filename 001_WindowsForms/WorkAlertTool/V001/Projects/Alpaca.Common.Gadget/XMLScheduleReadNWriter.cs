using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alpaca.Common.Gadget
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
        public const string DEFAULT_XML_FILEPATH = "../AlertSchedule.xml";

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




        #endregion
    }
}
