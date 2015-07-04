using Microsoft.Practices.Prism.Mvvm;

namespace HelloWorldApp.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private string message = "Hello Prism for Windows Runtime!!";

        public string Message
        {
            get { return this.message; }
            set { this.SetProperty(ref this.message, value); }
        }

    }
}
