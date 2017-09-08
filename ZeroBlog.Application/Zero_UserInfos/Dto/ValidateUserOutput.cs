using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    ///     /// <summary>
    /// 验证用户是否重复方法的输出Dto
    /// </summary>
    public class ValidateUserOutput
    {
        /// <summary>
        /// 验证状态,将返回0和1,0代表不存在重复,1代表存在重复
        /// </summary>
        public string state { get; set; }
    }
}
