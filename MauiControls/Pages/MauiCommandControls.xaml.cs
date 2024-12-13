namespace MauiControls.Pages;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnImgDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 5000);

    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        await DisplayAlert("Pesquisando...", $"{searchBar.Text}", "OK");
    }


    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 2000);
        await DisplayAlert("Button", "Tarefa concluida", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        if (lblPets2 != null)
        {
            lblPets2.Text = $"Selecionou: {selectedRadioButton.Value}";
            lblPets2.FontSize = 20;
        }
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Elemento tocado", "OK");
    }

    private void btnDemoDisabled_Clicked(object sender, EventArgs e)
    {

    }
}