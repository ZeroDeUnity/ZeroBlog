using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBlog.ZeroBlogSQL
{
    public class Zero_UserInfo:Entity<Guid>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string User_Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool User_Sex { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string User_Pwd { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set;}

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [MaxLength(50)]
        public string MailBox { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Zero_UserInfo() {

        }

    }
}
