using System;
using System.ComponentModel;
using System.Windows.Input;
using MauiAg15.Models;
using MauiAg15.Views;


namespace MauiAg15.ViewModels
{
    public class EventoViewModel : INotifyPropertyChanged
    {
        public Evento Evento { get; set; } // Propriedade para o modelo Evento
        public ICommand CadastrarCommand { get; } // Comando de navegação

        public EventoViewModel()
        {
            Evento = new Evento();
            CadastrarCommand = new Command(() => NavegarParaResumo());

        }

        private async void NavegarParaResumo()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoPage(Evento));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
