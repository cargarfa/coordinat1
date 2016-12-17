using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.SettingsService;
using Windows.UI.Xaml;
using modeloDatos;
using System.Collections.ObjectModel;

namespace coordinat.ViewModels
{
   public class vmIPersona : ViewModelBase
    {

    //creo los modelos de datos a utilizar en la vista
    //lista persona
       public ObservableCollection<mdb_Persona> personasLista { get; set; }
        //Tengo que enlazar el click del seleccionado con la propiedad personaActual
        //persona actual
       public mdb_Persona personaActual { get; set; }



    }
    public class vmIPersonaColeccion : ViewModelBase
    {

    }
}
