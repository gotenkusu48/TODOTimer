using Microsoft.Practices.Prism.Mvvm;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace HelloWorldApp
{
    /// <summary>
    /// 既定の Application クラスに対してアプリケーション独自の動作を実装します。
    /// </summary>
    public sealed partial class App : MvvmAppBase
    {
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            this.NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }
    }
}