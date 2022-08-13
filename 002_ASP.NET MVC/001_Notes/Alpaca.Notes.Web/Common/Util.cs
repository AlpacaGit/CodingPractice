using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Alpaca.Notes.Web.Common
{
    public static class Util
    {
        /// <summary>
        /// MD5によりハッシュ化した文字列を返す。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetMD5HashString(string text)
        {
            // 文字列をバイト型配列に変換する
            byte[] data = Encoding.UTF8.GetBytes(text);

            // MD5ハッシュアルゴリズム生成
            var algorithm = new MD5CryptoServiceProvider();

            // ハッシュ値を計算する
            byte[] bs = algorithm.ComputeHash(data);

            // リソースを解放する
            algorithm.Clear();

            // バイト型配列を16進数文字列に変換
            var result = new StringBuilder();
            foreach (byte b in bs)
            {
                result.Append(b.ToString("X2"));
            }
            return result.ToString();
        }
    }
}