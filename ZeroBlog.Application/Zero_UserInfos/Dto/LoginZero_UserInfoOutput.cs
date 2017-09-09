using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 检查用户是否登录成功方法的输出数据Dto
    /// </summary>
    public class LoginZero_UserInfoOutput
    {
        /// <summary>
        /// 用户状态,0表示登录失败,1表示数据匹配登录成功
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 返回用户部分信息
        /// </summary>
        public ListZero_UserInfoDto UserInfo;

    }
}
