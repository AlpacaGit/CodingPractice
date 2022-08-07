using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca.Tool.Logic.AlertTool
{
    /// <summary>
    /// 鳴動ファイルを操るためのstaticクラス
    /// </summary>
    public static class RingFileManager
    {

        /// <summary>
        /// 通常チャイム
        /// </summary>
        private static readonly string _normalChime = "chime.wav";

        /// <summary>
        /// 
        /// </summary>
        private static readonly string[] _workClosing = new string[] {
            "hotaru.wav","GetWild.wav"
        };


        /// <summary>
        /// 鳴動サウンドのパスを取得
        /// </summary>
        /// <param name="soundType"></param>
        /// <returns></returns>
        public static string GetRingSoundPath(EnumRingSoundType soundType)
        {
            string filePath = "";

            switch (soundType)
            {
                case EnumRingSoundType.NORMAL_CHIME:
                    filePath = _normalChime;
                    break;

                case EnumRingSoundType.WORK_CLOSING:
                    Random ran = new System.Random();
                    filePath = _workClosing[ran.Next(0, _workClosing.Length)];
                    break;
            }


            return filePath;
        }
    }
}
