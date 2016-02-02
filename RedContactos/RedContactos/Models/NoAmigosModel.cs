using System.Windows.Input;
using Autofac;
using ContactosModel.Model;
using RedContactos.ViewModel.Contactos;
using Xamarin.Forms;

namespace RedContactos.Models
{
    public class NoAmigosModel
    {
        public ICommand CmdAdd { get; set; }
        public ContactoModel ContactoModel { get; set; }
        public IComponentContext ComponentContext { get; set; }

        public NoAmigosModel()
        {
            CmdAdd=new Command(RunComandoAdd);
        }

        private async void RunComandoAdd()
        {
            var vm = ComponentContext.Resolve<AddContactoViewModel>();
            var d=await vm._servicio.AddContacto(ContactoModel);
            if (d != null)
            {
                //vm.Amigos.Add(ContactoModel);
                MessagingCenter.Send(ContactoModel,"AddContacto");
                vm.NoAmigos.Remove(this);
                await vm._page.MostrarAlerta("Exito", "Contacto añadido", "Ok");
                
            }
            else
                await vm._page.MostrarAlerta("Error", "Contacto no añadido", "Ok");
        }
    }
}