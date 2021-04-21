using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.DependencyInjection
{
    /// <summary>
    /// テスト用インメモリ構成
    /// </summary>
    public class InMemoryModuleDependencySetup : IDependencySetup
    {
        public void Run(IServiceCollection servicess)
        {
            SetupRepositories(servicess);
            SetupApplicationServices(servicess);
            SetupDomainServices(servicess);
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
