using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 查询用户数据List的输出Dto
    /// </summary>
    public class SelectZero_UserInfoListOut
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// 当前页最大展示数据条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 用户信息Dto
        /// </summary>
        public Zero_UserInfoDto Zero_UserInfoDto { get; set; }


    }
}
