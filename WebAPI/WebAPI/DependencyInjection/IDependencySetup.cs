using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.DependencyInjection
{
    /// <summary>
    /// アプリケーション構成インターフェース
    /// </summary>
    public interface IDependencySetup
    {
        /// <summary>
        /// セットアップ
        /// </summary>
        /// <param name="service"></param>
        void Run(IServiceCollection service);
    }
}