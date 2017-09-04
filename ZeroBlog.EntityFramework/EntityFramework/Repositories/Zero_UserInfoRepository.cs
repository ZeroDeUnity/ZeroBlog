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
    public class Zero_UserInfoRepository:ZeroBlogRepositoryBase<Zero_UserInfo,Guid>,IZero_UserInfoRepository
    {
        public Zero_UserInfoRepository(IDbContextProvider<ZeroBlogDbContext> dbContextProvider):base(dbContextProvider)
        {}
        public int CheckUser() {
            return 0;
        }
    }
}
