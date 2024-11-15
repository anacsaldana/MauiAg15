using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MauiAg15.Models;
using MauiAg15.Views;

namespace MauiAg15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Inicializa os componentes definidos no XAML
        }
    }

    public class EventoViewModel : INotifyPropertyChanged
    {
        private Evento _evento;

        public Evento Evento
        {
            get => _evento;
            set
            {
                if (_evento != value)
                {
                    _evento = value;
                    OnPropertyChanged(nameof(Evento));
                }
            }
        }

        public ICommand CadastrarCommand { get; }

        public EventoViewModel()
        {
            Evento = new Evento(); // Inicializa o modelo de evento
            CadastrarCommand = new Command(NavegarParaResumo); // Associa o comando de navegação
        }

        private async void NavegarParaResumo()
        {
            // Garante que a navegação está configurada corretamente
            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                await navigationPage.Navigation.PushAsync(new ResumoPage(Evento));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Erro", "Navegação não está configurada corretamente.", "OK");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
