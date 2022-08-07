using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alpaca.Common.Gadget
{
    /// <summary>
    /// XMLで保存された設定を読み込むためのクラス
    /// </summary>
    public class XmlSettingReader
    {
        private XElement _SettingXML;
        /// <summary>
        /// 設定用XML XElement
        /// </summary>
        public XElement SettingXML
        {
            get { return _SettingXML; }
            set { _SettingXML = value; }
        }

        private XElement _MessageXML;
        /// <summary>
        /// メッセージ用XML XELement
        /// </summary>
        public XElement MessageXML
        {
            get { return _MessageXML; }
            set { _MessageXML = value; }
        }

        public XmlSettingReader()
        {
            MessageXML = XElement.Load(".\\Message.xml");
        }

        public XmlSettingReader(EnumXmlCategoryType xmlCategoryType)
        {
            
        }


        /// <summary>
        /// メッセージコードをもとに、Message.xmlにおける通常メッセージの一つを返す。
        /// </summary>
        /// <param name="messageCode">メッセージコード</param>
        /// <returns>メッセージ内容。存在しないメッセージの場合は「メッセージが見つかりません。」と返す。</returns>
        public string GetNormalMessage(string messageCode)
        {
            // userを取得
            IEnumerable<XElement> messages = from item in MessageXML.Elements("Normal").Elements("MessageItem")
                                             //where item.Elements("MessageCode").ToString() == messageCode
                                             select item;
            string aMsgBody = "メッセージが見つかりません。";
            foreach(XElement xElement in messages)
            {
                aMsgBody = xElement.Element("MessageBody").Value;
                break;
            }
            return aMsgBody;
        }

    }
}
