using System.Collections.Generic;
using System.Reactive.Linq;
using Microsoft.Practices.Prism.Mvvm;
using Reactive.Bindings;

namespace HelloWorldApp.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        //    private string message = "Hello Prism for Windows Runtime!!";

        //    public string Message
        //    {
        //        get { return this.message; }
        //        set { this.SetProperty(ref this.message, value); }
        //    }

        public ReactiveCollection<CateClass> CateCollection { get; set; }

        public ReactiveProperty<string> Message { get; set; }

        public MainPageViewModel()
        {
            Message = new ReactiveProperty<string> ();
            Message.Value = "Hello World";

            CateCollection = new List<CateClass>(30).ToObservable().ToReactiveCollection();
        }
    }

    public class CateClass
    {
        ReactiveProperty<string> Title { get; set; } 
        public string SubTitle { get; set; }

    }
}
