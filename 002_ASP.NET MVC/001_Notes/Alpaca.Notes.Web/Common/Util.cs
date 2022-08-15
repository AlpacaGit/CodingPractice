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

        #region 定数

        private static readonly char[] _randomStringCharaset =  { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };


        #endregion


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

        /// <summary>
        /// 指定桁数分のランダムな文字列を生成する。
        /// </summary>
        /// <param name="numberOfDigit">生成する文字列の桁数</param>
        public static string GenerateRandomString(int numberOfDigit)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for(int i = 0; i < numberOfDigit; i++)
            {
                char aChar = _randomStringCharaset[random.Next(_randomStringCharaset.Count())];
                sb.Append(aChar);

            }
            return sb.ToString();
        }
    }
}