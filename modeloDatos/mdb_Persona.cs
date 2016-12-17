using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace modeloDatos
{
    public class mdb_Persona  : INotifyPropertyChanged

    {
        #region     ATRIBUTOS
        /// <summary>
        /// iDPersona, sera MAC+USUARIO+PER+000000001
        /// </summary>
        private string _idPersona;

        public string IdPersona
        {
            get { return _idPersona; }
            set { EstablecerPropiedad(ref _idPersona,value);}
        }
        /// <summary>
        /// Nombre
        /// </summary>
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { EstablecerPropiedad(ref _nombre, value); }
        }
        /// <summary>
        /// Apellido1
        /// </summary>
        private string _apellido1;

        public string Apellido1
        {
            get { return _apellido1; }
            set { EstablecerPropiedad(ref _apellido1, value); }
        
        }

        /// <summary>
        /// Apellido2
        /// </summary>
        private string _apellido2;

        public string Apellido2
        {
            get { return _apellido2; }
            set { EstablecerPropiedad(ref _apellido2, value); }
        }

        /// <summary>
        /// Imagen uri
        /// </summary>
        private Uri _foto;

        public Uri Foto
        {
            get { return _foto; }
            set { EstablecerPropiedad(ref _foto, value); }
        }
        #endregion
        /// <summary>
        /// Creo lista estatica para pruebas mientras creo bd
        /// </summary>
        public static List<mdb_Persona> PersonasListaModelo
        {
            get
            {
                return new List<mdb_Persona>
                {
               new mdb_Persona("1", "Carlos", "Garcia", "Fabra", new System.Uri("ms-appx:///Assets/hombre.jpg")),
               new mdb_Persona("1", "Carlos", "Garcia", "Fabra", new System.Uri("ms-appx:///Assets/hombre.jpg")),
               new mdb_Persona("1", "Carlos", "Garcia", "Fabra", new System.Uri("ms-appx:///Assets/hombre.jpg")),
               new mdb_Persona("1", "Carlos", "Garcia", "Fabra", new System.Uri("ms-appx:///Assets/hombre.jpg"))
                };
            }
        }
        //#region LISTAS DEPENDIENTES PERSONA
        ///// <summary>
        ///// Lista de documentos que tiene persona
        ///// </summary>
        //public List<nDocumento> nDocumento
        //{
        //    get
        //    {
        //        return new List<nDocumento>
        //        {
        //            new nDocumento(),


        //        }
        //    }
        //}

        ///// <summary>
        ///// Lista de documentos que tiene persona
        ///// </summary>
        //public List<nObservacion> nObservacion
        //{
        //    get
        //    {
        //        return new List<nObservacion>
        //        {
        //            new nObservacion(),


        //        };
        //    }
        //}
        ///// <summary>
        ///// Acceso que dispone la persona
        ///// </summary>
        //public mdz8_Acceso Acceso
        //{
        //    get
        //    {
        //        return new mdz8_Acceso(),
        //    };
        //}



        //#endregion
      
        #region CONSTRUCTORES
        public mdb_Persona()
        {
            //Carlos = new ViewModels.vmIPersona()
            //{
            //    IdPersona = "idpersona",
            //    Nombre = "Carlos",
            //    Apellido1 = "Garcia",
            //    Apellido2 = "Fabra",
            //    Foto = new System.Uri("ms-appx:///Assets/hombre.jpg")
            //};

        }

        public mdb_Persona(string idPersona, string nombre, string apellido1, string apellido2, Uri foto)
        {
            this.IdPersona = idPersona;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = Apellido2;
            this.Foto = foto;
        }
        #endregion

        #region METODOS/FUNCIONES

        public String MostrarApellidoNombrePersona()
        {
            return String.Format("{0} {1}, {2}", Apellido1, Apellido2, Nombre);
        }

        #endregion

        #region INotifyPrppertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropiedadCambiada(String nombrePropiedad = "")
        {
            //si no hay ninguna ventana enlazada salgo
            if (PropertyChanged == null)
                return;         
            PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
        public void EstablecerPropiedad<T>(ref T campoPrivado, T nuevoValor,[CallerMemberName]String nombrePropiedad="" )
        {
            //si no hay cambios no activa el evento
            if (EqualityComparer<T>.Default.Equals(campoPrivado, nuevoValor))
                return;
            campoPrivado = nuevoValor;
            //invoco el evento
            OnPropiedadCambiada(nombrePropiedad);
        }
        #endregion
    }




    //para relacion varios a varios
    //de una lista de items me retorna el codigo especificado por mi
    //capitulo 4 de video wpf 37:50
    //public class Itemes : List<Item>
    //{
    //    #region INDIZADOR
    //    public new Item this[int id]
    //    {
    //        get
    //        {
    //            //implementar con linqq para poder hacer filtrado
    //            foreach (Item itemActual in this)
    //            {
    //                if (itemActual.IdItem == id)
    //                    return itemActual;
    //            }
    //            return null;
    //        }
    //    }
    //    #endregion
    //}
}