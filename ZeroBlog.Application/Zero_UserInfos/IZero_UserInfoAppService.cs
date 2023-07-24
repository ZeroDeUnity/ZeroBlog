using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroBlog.Zero_UserInfos.Dto;

namespace ZeroBlog.Zero_UserInfos
{
    /// <summary>
    /// 用户实体类应用服务接口
    /// </summary>
    public interface IZero_UserInfoAppService
    {
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        LoginZero_UserInfoOutput Login(LoginZero_UserInfoInput input);

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        RegisterZero_UserInfoOutput RegisterUser(RegisterZero_UserInfoInput input);

        /// <summary>
        /// 验证用户名是否存在
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValidateUserOutput ValidateUser(ValidateUserInput input);

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="Page" type="int">当前页数</param>
        /// <param name="PageSize" type="int">当前页最大展示数据条数</param>
        /// <param name="SelectInput" type="SelectZero_UserInfoListInput">查询用户列表输入参数</param>
        /// <returns>SelectZero_UserInfoListOut</returns>
        SelectZero_UserInfoListOut SelectZero_UserInfoList(int Page, int PageSize, SelectZero_UserInfoListInput SelectInput);
    }
}
