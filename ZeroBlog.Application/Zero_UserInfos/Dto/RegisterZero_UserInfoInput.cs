using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 注册用户的用户输入数据Dto
    /// </summary>
    public class RegisterZero_UserInfoInput
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
        /// 用户邮箱
        /// </summary>
        public string MailBox { get; set; }
    }
}
