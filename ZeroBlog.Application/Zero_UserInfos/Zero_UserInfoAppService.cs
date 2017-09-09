using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroBlog.IRepositories;
using ZeroBlog.Zero_UserInfos.Dto;
using ZeroBlog.ZeroBlogSQL;


namespace ZeroBlog.Zero_UserInfos
{
    public class Zero_UserInfoAppService :ZeroBlogAppServiceBase, IZero_UserInfoAppService
    {
        private readonly IZero_UserInfoRepository _Zero_UserInfoRepository;
        public IAbpSession AbpSession { get; set; }
        //private readonly IRepository<Zero_UserInfo,Guid> _Zero_UserInfoRepository;

        public Zero_UserInfoAppService
            (
            IZero_UserInfoRepository Zero_UserInfoRepository
            )
        {
            _Zero_UserInfoRepository = Zero_UserInfoRepository;
            AbpSession = NullAbpSession.Instance;
        }

        /// <summary>
        /// 检查用户是否登录成功
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LoginZero_UserInfoOutput Login(LoginZero_UserInfoInput input)
        {
            var user = _Zero_UserInfoRepository.CheckUser(input.User_Name, input.User_Pwd);
            LoginZero_UserInfoOutput ouput = new LoginZero_UserInfoOutput();

            if (user.Any())
            {
                ouput.state = 1;
                ouput.UserInfo = Mapper.Map<ListZero_UserInfoDto>(user.FirstOrDefault());
            }
            else
            {
                ouput.state = 0;
                ouput.UserInfo = null;
            }


            return ouput;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public RegisterZero_UserInfoOutput RegisterUser(RegisterZero_UserInfoInput input)
        {
            var RegisterMsg = string.Empty;
            RegisterZero_UserInfoOutput ouput = new RegisterZero_UserInfoOutput();
            //下面被注释的是因为验证用户存在和这一块注册进数据库分开了.所以注释
            //var users = from userss in _Zero_UserInfoRepository.GetAll()
            //            where userss.User_Name == input.User_Name
            //            select userss;

            //if (!users.Any())
            //{
            var Zero_UserInfo = new Zero_UserInfo
                {
                    User_Name = input.User_Name,
                    User_Sex = input.User_Sex,
                    User_Pwd = input.User_Pwd,
                    MailBox = input.MailBox,
                    LoginTime = DateTime.Now,
                    CreateTime = DateTime.Now
                };
            var id= _Zero_UserInfoRepository.InsertAndGetId(Zero_UserInfo);
            if (id!=null)
            {
                ouput.state = "注册成功";
                ouput.UserInfo = Mapper.Map<ListZero_UserInfoDto>(Zero_UserInfo);
            }
            else
            {
                ouput.state = "注册失败";
                ouput = null;
            }
                
            //}
            //else
            //{
            //    //尽管前端会进行验证用户名,但后台还是把方法写全
            //    RegisterMsg = "用户名已存在!";
            //}

            return ouput;
        }

        /// <summary>
        /// 验证用户名是否存在
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ValidateUserOutput ValidateUser(ValidateUserInput input) {
            var RegisterState = string.Empty;
            var users = _Zero_UserInfoRepository.ValidateUser(input.UserName);

            if (users.Any())
            {
                //表示存在该用户
                RegisterState = "1";
            }
            else
            {
                //表示不存在
                RegisterState = "0";
            }

            return new ValidateUserOutput() { state= RegisterState };
        }
    }
}
