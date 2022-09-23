using AutoMapper;
using TesteProdutoStore.Models;
using TesteProdutoStore.ViewModel;

namespace TesteProdutoStore.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration registerMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<Produto, ProdutoViewModel>();
                    config.CreateMap<ProdutoViewModel, Produto>();
                }
                );
            return mappingConfig;
        }
    }
}
