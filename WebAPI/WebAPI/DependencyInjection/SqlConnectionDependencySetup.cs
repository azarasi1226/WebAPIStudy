using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.DependencyInjection
{
    /// <summary>
    /// DBを使用した本番環境用構成
    /// </summary>
    public class SqlConnectionDependencySetup : IDependencySetup
    {
        /// <summary>
        /// アプリケーション設定
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="configuration">アプリケーション設定</param>
        public SqlConnectionDependencySetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Run(IServiceCollection services)
        {
            SetupDbContexts(services);
            SetupRepositories(services);
            SetupApplicationServices(services);
            SetupDomainServices(services);
        }

        /// <summary>
        /// DbContextをIoCに登録
        /// </summary>
        /// <param name="services"></param>
        private void SetupDbContexts(IServiceCollection services)
        {
        }

        /// <summary>
        /// レポジトリをIoCに登録
        /// </summary>
        /// <param name="services"></param>
        private void SetupRepositories(IServiceCollection services)
        {

        }

        /// <summary>
        /// アプリケーションサービスをIoCに登録
        /// </summary>
        /// <param name="services"></param>
        private void SetupApplicationServices(IServiceCollection services)
        {

        }

        /// <summary>
        /// ドメインサービスをIocに登録
        /// </summary>
        /// <param name="services"></param>
        private void SetupDomainServices(IServiceCollection services)
        {

        }
    }
}
