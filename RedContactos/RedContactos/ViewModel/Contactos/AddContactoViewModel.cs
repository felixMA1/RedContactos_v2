using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ContactosModel.Model;
using MvvmLibrary.Factorias;
using RedContactos.Models;
using RedContactos.Service;
using Xamarin.Forms;

namespace RedContactos.ViewModel.Contactos
{
    public class AddContactoViewModel:GeneralViewModel
    {
        private ObservableCollection<ContactoModel> _amigos;
        private ObservableCollection<NoAmigosModel> _noAmigos;


        public ObservableCollection<ContactoModel> Amigos
        {
            get { return _amigos; }
            set { SetProperty(ref _amigos, value); }
        }

        public ObservableCollection<NoAmigosModel> NoAmigos
        {
            var a = "";
            get { return _noAmigos; }
            set { SetProperty(ref _noAmigos, value); }
        }

       // public ICommand CmdAdd { get; set; }
        public AddContactoViewModel(INavigator navigator, IServicioMovil servicio, IPage page) : base(navigator, servicio, page)
        {
           // CmdAdd=new Command(AddContacto);
        }

        //private async void AddContacto(object obj)
        //{
        //    var id = int.Parse(obj.ToString());
        //    var c = NoAmigos.FirstOrDefault(o => o.idDestino == id);
        //    if (c != null)
        //    {
        //       var r=await  _page.MostrarAlerta("Confirmacion", "Estas seguro de añadir a " + c.nombreCompleto, "Sí", "No");

        //        if (r)
        //        {
        //            var ok = await _servicio.AddContacto(c);
        //            if (ok != null)
        //            {
        //                await _page.MostrarAlerta("Exito", "Contacto añadido", "Aceptar");
        //                Amigos.Add(c);
        //                NoAmigos.Remove(c);
        //            }
        //            else
        //            {
        //                await _page.MostrarAlerta("Error", "Contacto no añadido", "Aceptar");
                        
        //            }


        //        }
        //    }


        //}


    }
}