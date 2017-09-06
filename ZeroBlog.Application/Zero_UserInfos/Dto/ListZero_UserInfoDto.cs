using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.Zero_UserInfos.Dto
{
    /// <summary>
    /// 用户列表数据Dto,定义要展现给客户端的用户实体,不暴露密码
    /// </summary>
    public class ListZero_UserInfoDto
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string User_Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool User_Sex { get; set; }

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
