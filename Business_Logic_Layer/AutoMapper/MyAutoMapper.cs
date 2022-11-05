using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.AutoMapper
{
    public static class MyAutoMapper<TSourse, TDestination>
    {
        private static Mapper _myMapper = new Mapper(new MapperConfiguration(
            cfg => cfg.CreateMap<TSourse, TDestination>().ReverseMap()
            ));

        public static TDestination Map(TSourse source)
        {
            return _myMapper.Map<TDestination>(source);
        }

        public static List<TDestination> MapList(List<TSourse> source)
        {
            var list = new List<TDestination>();
            source.ForEach(x => list.Add(Map(x)));
            return list;
        }

        
    }
}
