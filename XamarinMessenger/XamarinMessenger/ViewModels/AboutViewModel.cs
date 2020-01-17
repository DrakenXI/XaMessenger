using Syncfusion.SfMaps.XForms;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamarinMessenger.ViewModels
{
    /*a mettre ici*/
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Carte";
            SfMaps map = new SfMaps();
            map.BackgroundColor = Color.White;
            ShapeFileLayer layer = new ShapeFileLayer();
            layer.Uri = "usa_state.shp";
            map.Layers.Add(layer);
            this.Content = map;
            //OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
        public SfMaps Content { get; private set; }
    }
}