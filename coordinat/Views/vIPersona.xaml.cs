using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using modeloDatos;
using System.Collections.ObjectModel;
using coordinat.ViewModels;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace coordinat.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class vIPersona : Page
    {
        //creo objeto del viewmodel que tiene todos los datos que necesito para la vista
        public vmIPersona vm { get; set; }
       
        public vIPersona()
        {
            this.InitializeComponent();        
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {          
            base.OnNavigatedTo(e);
            vm = new vmIPersona();
            vm.personasLista = new ObservableCollection<mdb_Persona>(mdb_Persona.PersonasListaModelo);
            //cargo la primera persona de la lista personas
            vm.personaActual = vm.personasLista[0];
      
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //Lo enlado cuando lo cargo
            this.DataContext = vm;
        }
    }
}
