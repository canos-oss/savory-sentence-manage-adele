using System;

using Microsoft.Extensions.DependencyInjection;

using Savory.SentenceManage.Convertor;
using Savory.SentenceManage.Convertor.Implement;
using Savory.SentenceManage.Lookup;
using Savory.SentenceManage.Lookup.Implement;
using Savory.SentenceManage.Repository;
using Savory.SentenceManage.Repository.Mysql;

namespace Savory.SentenceManage.Configure
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {

            services.AddSingleton<ISentenceRepository, MysqlSentenceRepository>();



            return services;
        }

        public static IServiceCollection AddConvertorServices(this IServiceCollection services)
        {

            services.AddSingleton<ISentenceConvertor, SentenceConvertor>();



            return services;
        }

        public static IServiceCollection AddProviderServices(this IServiceCollection services)
        {


            return services;
        }

        public static IServiceCollection AddLookupProviderServices(this IServiceCollection services)
        {

            services.AddSingleton<ISentenceLookupProvider, SentenceLookupProvider>();

            return services;
        }
    }
}
