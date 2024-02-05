using Newtonsoft.Json;
using EscobarRecuperacion.EscobarModels;
using static EscobarRecuperacion.EscobarModels.DogBreedModel;


namespace EscobarRecuperacion.EscobarViews
{
    public partial class SearchPage : ContentPage
    {
        private readonly SearchViewModel _viewModel;

        public SearchPage()
        {
            InitializeComponent();
            _viewModel = new SearchViewModel();
            BindingContext = _viewModel;
        }

        private async void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            await _viewModel.SearchBreedsAsync(e.NewTextValue);
        }

        private async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            await _viewModel.SearchBreedsAsync(BreedEntry.Text);
        }
    }
}