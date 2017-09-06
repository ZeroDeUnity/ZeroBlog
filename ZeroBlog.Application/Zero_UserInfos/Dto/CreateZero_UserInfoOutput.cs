using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 创建用户方法的返回数据Dto
    /// </summary>
    public class CreateZero_UserInfoOutput
    {
        /// <summary>
        /// 创建用户的状态值,0表示失败,1表示成功
        /// </summary>
        public int state { get; set; }
    }
}
