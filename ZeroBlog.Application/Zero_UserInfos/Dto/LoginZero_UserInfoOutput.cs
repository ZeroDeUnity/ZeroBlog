using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 用户登录方法的输出数据Dto
    /// </summary>
    public class LoginZero_UserInfoOutput
    {
        /// <summary>
        /// 用户在数据库状态,0表示不存在,1表示存在,可以登录
        /// </summary>
        public int state { get; set; }
    }
}
