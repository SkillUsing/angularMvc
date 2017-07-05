using AutoMapper;
using ElecSales.Models;
using mvcProject.Core;

namespace ElecSales
{
    public class AutoMapperConfig
    {
        public static void RegisterMapper()
        {
            RegisterProject();
        }
        private static void RegisterProject()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMissingTypeMaps = true;
                cfg.CreateMap<AccountsViewModel, Accounts>();
            });
            MapperUtil.Config(config.CreateMapper());
        }

    }
}