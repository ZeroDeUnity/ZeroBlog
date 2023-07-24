using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos
{
    /// <summary>
    /// 查询用户数据List的输入Dto
    /// </summary>
    public class SelectZero_UserInfoListInput
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool User_Sex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string MailBox { get; set;}
    }
}
