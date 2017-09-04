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
        int CheckUser();
    }
}
