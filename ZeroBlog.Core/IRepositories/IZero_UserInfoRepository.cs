using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroBlog.ZeroBlogSQL;

namespace ZeroBlog.IRepositories
{
    public interface IZero_UserInfoRepository:IRepository<Zero_UserInfo, Guid>
    {
        /// <summary>
        /// 根据用户名和用户密码检查用户是否在表中存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="UserPwd">用户密码</param>
        /// <returns>返回0和1,0代表没有数据,1代表用户存在</returns>
        int CheckUser(string UserName,string UserPwd);
    }
}
