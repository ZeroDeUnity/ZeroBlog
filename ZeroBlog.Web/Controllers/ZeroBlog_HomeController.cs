using Abp.Web.Mvc.Controllers;
using Abp.Web.Security.AntiForgery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return RegisterState.state;
        }

    }
}
