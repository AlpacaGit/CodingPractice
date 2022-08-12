using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alpaca.Notes.Web.Common;

namespace Alpaca.Notes.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            //未実装
            if(System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID] == null || System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID].ToString() == "")
            {
                System.Web.HttpContext.Current.Session[SessionVariable.LOGIN_USERID] = "Alpaca";
            }
            else
            {
                System.Web.HttpContext.Current.Session.Remove(SessionVariable.LOGIN_USERID);
            }
            return View();
        }
    }
}