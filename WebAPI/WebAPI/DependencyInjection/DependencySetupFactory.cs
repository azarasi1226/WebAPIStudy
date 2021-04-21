using Microsoft.Extensions.Configuration;
using System;

namespace WebAPI.DependencyInjection
{
    /// <summary>
    /// アプリケーション構成ファクトリ
    /// </summary>
    public class DependencySetupFactory
    {
        /// <summary>
        /// appsettings.jsonの設定に合わせてアプリケーション構成を作成
        /// </summary>
        /// <param name="configuration">アプリケーション設定</param>
        /// <returns></returns>
        public IDependencySetup CreateSetup(IConfiguration configuration)
        {
            var setupName = configuration["Dependency:SetupName"];

            return setupName switch
            {
                nameof(InMemoryModuleDependencySetup) => new InMemoryModuleDependencySetup(),
                nameof(SqlConnectionDependencySetup) => new SqlConnectionDependencySetup(configuration),
                _ => throw new NotSupportedException($"セットアップ名[{setupName}]は登録できませんでした。"),
            };
        }
    }
}
