using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ZeroBlog.Zero_UserInfos.Dto;
using ZeroBlog.ZeroBlogSQL;

namespace ZeroBlog.Zero_UserInfos
{
    public class Zero_UserInfoDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            
            mapperConfig.CreateMap<Zero_UserInfo,Zero_UserInfoDto>();
            mapperConfig.CreateMap<Zero_UserInfo, ListZero_UserInfoDto>();

            ////自定义映射
            //var taskDtoMapper = mapperConfig.CreateMap<TasksTT, TaskDto>();
            //taskDtoMapper.ForMember<string>(dto => dto.AssignedPersonName, map => map.MapFrom(m => m.AssignedPerson.FullName));
        }
    }
}
