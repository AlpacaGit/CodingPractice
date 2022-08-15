using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpaca.Notes.Web.Common
{
    public class ConstInfo
    {

    }

    /// <summary>
    /// ページ名
    /// </summary>
    public class PageName
    {
        /// <summary>
        /// ユーザ情報一覧
        /// </summary>
        public const string NoteUsers = "ユーザ情報一覧";

        /// <summary>
        /// ユーザ情報新規登録
        /// </summary>
        public const string NoteUsersRegist = "ユーザ情報新規登録";

        /// <summary>
        /// ユーザ情報詳細
        /// </summary>
        public const string NoteUsersDetail = "ユーザ情報詳細";

        /// <summary>
        /// ユーザ情報編集
        /// </summary>
        public const string NoteUsersEdit = "ユーザ情報編集";

        /// <summary>
        /// ユーザ情報削除
        /// </summary>
        public const string NoteUsersDelete = "ユーザ情報削除";


        public const string Login = "ログイン";

    }

    /// <summary>
    /// ページ列挙
    /// </summary>
    public enum EnumPage
    {
        /// <summary>
        /// ユーザ情報一覧
        /// </summary>
        NOTE_USERS = 0,
        /// <summary>
        /// ユーザ情報新規登録
        /// </summary>
        NOTE_USERS_REGIST = 1,
        /// <summary>
        /// ユーザ情報詳細
        /// </summary>
        NOTE_USERS_DETAIL = 2,
        /// <summary>
        /// ユーザ情報編集
        /// </summary>
        NOTE_USERS_EDIT = 3,
        /// <summary>
        /// ユーザ情報削除
        /// </summary>
        NOTE_USERS_DELETE = 4,

        /// <summary>
        /// ログイン
        /// </summary>
        LOGIN = 5,

    }

    /// <summary>
    /// メッセージ集
    /// </summary>
    public class Messages
    {
        /// <summary>
        /// 本当に削除してもよろしいですか？
        /// </summary>
        public const string CAUTION_BEFORE_DELETE = "本当に削除してもよろしいですか？";
    }

    /// <summary>
    /// セッション変数名
    /// </summary>
    public class SessionVariable
    {
        /// <summary>
        /// ログイン中ユーザID
        /// </summary>
        public const string LOGIN_USERID = "LoginUserID";


    }

    /// <summary>
    /// コントローラ名
    /// </summary>
    public class ControllerName
    {
        /// <summary>
        /// ユーザ情報
        /// </summary>
        public const string NOTE_USERS = "NoteUsers";

        /// <summary>
        /// 認証
        /// </summary>
        public const string AUTH = "Auth";
    }

}