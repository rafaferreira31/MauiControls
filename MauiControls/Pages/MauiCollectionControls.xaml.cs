using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
        BindingContext = new FotoViewModel();
    }

    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null && e.PreviousItem != null)
        {
            Foto anterior = e.PreviousItem as Foto;
            Foto atual = e.CurrentItem as Foto;

            DisplayAlert("CarouselView", $"Anterior = {anterior?.Nome} \n\nAtual = {atual?.Nome}", "Ok");
        }
    }

    private void alertaCintoDeSeguranca_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta do Cinto de Segurança!", "Selecionou/deselecionou este componente!", "Ok");
    }
}