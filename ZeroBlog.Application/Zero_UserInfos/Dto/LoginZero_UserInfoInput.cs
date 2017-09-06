using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 用户登录方法输入数据Dto
    /// </summary>
    public class LoginZero_UserInfoInput
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string User_Name { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string User_Pwd { get; set; }
    }
}
