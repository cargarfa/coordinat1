using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace coordinat.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
 

    public sealed partial class vInsertar : Page
    {
        Template10.Services.SerializationService.ISerializationService _SerializationService;
        public vInsertar()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
            _SerializationService = Template10.Services.SerializationService.SerializationService.Json;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var index = int.Parse(_SerializationService.Deserialize(e.Parameter?.ToString()).ToString());
            //index es el parametro que le paso cuando lo llamo desde shell
            pivotInsertar.SelectedIndex = index;
        }
    }
}

//Template10.Services.SerializationService.ISerializationService _SerializationService;

//public SettingsPage()
//{
//    InitializeComponent();
//    NavigationCacheMode = NavigationCacheMode.Required;
//    _SerializationService = Template10.Services.SerializationService.SerializationService.Json;
//}

//protected override void OnNavigatedTo(NavigationEventArgs e)
//{
//    var index = int.Parse(_SerializationService.Deserialize(e.Parameter?.ToString()).ToString());
//    //index es el parametro que le paso cuando lo llamo desde shell
//    MyPivot.SelectedIndex = index;
//}