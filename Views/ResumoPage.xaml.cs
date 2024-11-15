using MauiAg15.Models;
using Microsoft.Maui.Controls;

namespace MauiAg15.Views;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento; // Define o contexto de dados como o evento recebido.
    }
}
