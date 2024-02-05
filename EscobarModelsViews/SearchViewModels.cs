using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using EscobarRecuperacion.EscobarModels;

public class SearchViewModel
{
    private readonly DogApiService _dogApiService;
    public ObservableCollection<DogBreedModel> Breeds { get; }
    public string ImageUrl { get; set; } // Agrega esta propiedad para almacenar la URL de la imagen

    public SearchViewModel()
    {
        _dogApiService = new DogApiService();
        Breeds = new ObservableCollection<DogBreedModel>();
    }

    public async Task SearchBreedsAsync(string searchTerm)
    {
        var allBreeds = await _dogApiService.GetAllBreedsAsync();
        // Aquí deberías buscar en 'allBreeds' las razas que coincidan con 'searchTerm' y agregarlas a 'Breeds'.
        // Luego, puedes obtener la URL de la imagen de la raza seleccionada y asignarla a 'ImageUrl'.
    }
}
