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
        /// <returns>返回0和1,0代表没有数据,1代表用户存在</returns>
        public int CheckUser(string UserName, string UserPwd)
        {
            var datas = GetAll();
            int state = 0;

            if (UserName.Length > 0 && UserPwd.Length > 0)
            {
                //这是用count统计数量来判断,下面的any性能更优
                //int nums = 0;
                //nums = datas.Where(d => d.User_Name == UserName && d.User_Pwd == UserPwd).Count();
                //if (nums > 0)
                //{
                //    state = 1;
                //}
                if (datas.Where(d => d.User_Name == UserName && d.User_Pwd == UserPwd).Any())
                {
                    state = 1;
                }
            }

            return state;
        }


    }
}
