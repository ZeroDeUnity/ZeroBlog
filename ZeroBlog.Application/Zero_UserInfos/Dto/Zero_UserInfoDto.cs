using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// Zero_UserInfo实体Dto
    /// </summary>
    public class Zero_UserInfoDto:EntityDto<Guid>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string User_Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool User_Sex { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string User_Pwd { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string MailBox { get; set; }


    }
}
