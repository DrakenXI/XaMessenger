using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamarinMessenger.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "A propos";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/DrakenXI/XaMessenger")));
        }

        public ICommand OpenWebCommand { get; }
    }
}