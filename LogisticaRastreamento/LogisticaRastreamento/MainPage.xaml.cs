using TpRastreamento.Models;
using TpRastreamento.ViewModels;

namespace TpRastreamento
{
    public partial class MainPage : ContentPage
    {
        public PacoteViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new PacoteViewModel();
        }

        private async void OnClickedTracking(object sender, EventArgs e)
        {
            string codigoRastreamento = CodRastreamento.Text;
            PacoteModel PacoteEncontrado =  ViewModel.RastrearPacotePorCodigo(codigoRastreamento);

            if (PacoteEncontrado != null) await Navigation.PushAsync(new ResultadosPage { BindingContext = ViewModel });
      
            else CodRastreamento.Text = ""; //Limpa entrada
            
        }

    }
}
