using Abp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroBlog.IRepositories;
using ZeroBlog.ZeroBlogSQL;

namespace ZeroBlog.EntityFramework.Repositories
{
    public class Zero_UserInfoRepository : ZeroBlogRepositoryBase<Zero_UserInfo, Guid>, IZero_UserInfoRepository
    {
        public Zero_UserInfoRepository(IDbContextProvider<ZeroBlogDbContext> dbContextProvider) : base(dbContextProvider)
        { }

        /// <summary>
        /// 根据用户名和用户密码检查用户是否在表中存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <param name="UserPwd">用户密码</param>
        /// <returns></returns>
        public IQueryable<Zero_UserInfo> CheckUser(string UserName, string UserPwd)
        {
            var datas = GetAll().Where(d => d.User_Name == UserName && d.User_Pwd == UserPwd);

            return datas;
        }

        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns></returns>
        public IQueryable<Zero_UserInfo> ValidateUser(string UserName) {
            var users = from userss in GetAll()
                        where userss.User_Name == UserName
                        select userss;
            return users;
        }


    }
}
