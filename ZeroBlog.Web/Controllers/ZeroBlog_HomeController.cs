using Abp.Web.Mvc.Controllers;
using Abp.Web.Security.AntiForgery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroBlog.IRepositories;
using ZeroBlog.Zero_UserInfos;
using ZeroBlog.Zero_UserInfos.Dto;

namespace ZeroBlog.Web.Controllers
{
    public class ZeroBlog_HomeController : AbpController
    {
        private readonly IZero_UserInfoAppService _Zero_UserInfoAppService;
        
        public ZeroBlog_HomeController
            (
            IZero_UserInfoAppService Zero_UserInfoAppService
            )
        {
            _Zero_UserInfoAppService = Zero_UserInfoAppService;
        }

        public ActionResult Index()
        {
            //var userid = System.Web.HttpContext.Current.Request.Cookies["Id"];
            //if (userid!=null)
            //{
            //    var username = System.Web.HttpContext.Current.Request.Cookies["UserName"];
            //    ViewBag.UserName = username;
            //}

            return View();
        }

        public ActionResult single()
        {
            return View();
        }

        public ActionResult Tste1()
        {
            return View();
        }

        public ActionResult RegisterUser()
        {
            return View();
        }

        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DisableAbpAntiForgeryTokenValidation]
        public string ValidateUser(ValidateUserInput input)
        {
            var ValidateState = _Zero_UserInfoAppService.ValidateUser(input);

            return ValidateState.state;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DisableAbpAntiForgeryTokenValidation]
        public string RegisterUserFF(RegisterZero_UserInfoInput input) {

            var RegisterState = _Zero_UserInfoAppService.RegisterUser(input);

            if (RegisterState.state == "注册成功")
            {
                HttpCookie cookie = new HttpCookie("Id", Convert.ToString(RegisterState.UserInfo.Id));
                cookie.Expires = DateTime.Now.AddMinutes(30);//30分钟的co0kie
                System.Web.HttpContext.Current.Response.AppendCookie(cookie); //写入Cookie
                HttpCookie cookie1 = new HttpCookie("UserName", RegisterState.UserInfo.User_Name);
                cookie1.Expires = DateTime.Now.AddMinutes(30);//30分钟的co0kie
                System.Web.HttpContext.Current.Response.AppendCookie(cookie1); //写入Cookie
            }

            return RegisterState.state;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DisableAbpAntiForgeryTokenValidation]
        public string Login(LoginZero_UserInfoInput input) {

            var loginstate = _Zero_UserInfoAppService.Login(input);
            var ret = string.Empty;

            if (loginstate.state==1)
            {
                ret = "成功";
                HttpCookie cookie = new HttpCookie("Id", Convert.ToString(loginstate.UserInfo.Id));
                cookie.Expires = DateTime.Now.AddMinutes(30);//30分钟的co0kie
                System.Web.HttpContext.Current.Response.AppendCookie(cookie); //写入Cookie
                HttpCookie cookie1 = new HttpCookie("UserName", loginstate.UserInfo.User_Name);
                cookie1.Expires = DateTime.Now.AddMinutes(30);//30分钟的co0kie
                System.Web.HttpContext.Current.Response.AppendCookie(cookie1); //写入Cookie
            }
            else
            {
                ret = "失败";
            }

            return ret;
        }

    }
}
