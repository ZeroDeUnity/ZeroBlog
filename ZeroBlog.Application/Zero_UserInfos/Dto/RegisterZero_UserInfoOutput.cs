using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 注册用户方法的返回数据Dto
    /// </summary>
    public class RegisterZero_UserInfoOutput
    {
        /// <summary>
        /// 注册情况,注册成功就返回注册成功
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 返回用户部分信息
        /// </summary>
        public ListZero_UserInfoDto UserInfo;
    }
}
