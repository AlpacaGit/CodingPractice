using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Alpaca.Notes.Web.Common;

namespace Alpaca.Notes.Web.Controllers
{
    public class AuthController : Controller
    {
        /// <summary>
        /// DBコンテキストクラス
        /// </summary>
        Data.AlpacaNotesWebContext db = new Data.AlpacaNotesWebContext();

        #region ログイン処理系

        // GET: Login
        public ActionResult Login()
        {
            //未実装
            if(System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID] == null || System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID].ToString() == "")
            {
                return View();
            }
            else
            {
                System.Web.HttpContext.Current.Session.Remove(SessionVariable.LOGIN_USERID);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "UserID")] Models.NoteUser noteUser, string passwd)
        {
            //TODO：ログイン処理の実装予定。
            //パスワードソルトの仕組みを利用する。
            Models.NoteUser loginUser = db.NoteUsers.FirstOrDefault(x => x.UserID == noteUser.UserID);

            if(loginUser == null)
            {
                //ログインユーザが見つからない場合。ログイン画面に戻す。
                //アトリビュート？や、セッション変数を利用するなどして「ユーザIDまたはパスワードが間違っています」と表示させる。
                return View(noteUser);
            }

            //パスワードソルトの仕組みを使って、入力値の照合を行う。
            //ユーザ情報.パスワードハッシュ値 と 「入力したパスワード+ユーザ情報.ソルト値」をハッシュ計算した結果 とを
            //照らし合わせて、一致すればログイン成功。
            //そうでなければログイン失敗とする。
            //☆テーブル構成自体を変えないといけないので、いったん仮。
            //string aSoltValue = db.UserCertification.SoltValue;
            Models.UserCertificationInfo aCert = db.UserCertificationInfo.FirstOrDefault(x => x.UserID == loginUser.UserID);

            if(aCert == null)
            {
                return View(noteUser);
            }

            string hashResult = Common.Util.GetMD5HashString(passwd + aCert.SoltValue);

            if (hashResult.Equals(aCert.HashValue))
            {
                System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID] = loginUser.UserID;

                return RedirectToAction("Index", "Home");
            }


            return View(noteUser);
        }
        #endregion

        #region ログアウト処理系
        /// <summary>
        /// ログアウト
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            //セッション変数 ログインユーザIDを破棄し、ログアウトとする。
            System.Web.HttpContext.Current.Session.Remove(SessionVariable.LOGIN_USERID);
            return View();
        }

        #endregion
    }
}