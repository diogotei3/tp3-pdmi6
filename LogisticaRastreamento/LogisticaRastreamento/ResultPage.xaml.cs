
using TpRastreamento.ViewModels;

namespace TpRastreamento;

public partial class ResultadosPage : ContentPage
{
	public ResultadosPage()
	{
        InitializeComponent();
        BindingContext = new PacoteViewModel();
	}

    private async void OnClickedReturn(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}