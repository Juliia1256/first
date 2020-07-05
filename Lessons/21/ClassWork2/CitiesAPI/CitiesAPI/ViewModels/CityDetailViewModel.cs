using CitiesAPI.Model;

namespace CitiesAPI.ViewModels
{
    public class CityDetailViewModel
    {
        public CityDetailViewModel(City city)
        {
            Title = city.Title;
            Description = city.Description;
            Population = city.Population;
            Id = city.Id.ToString("N");
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public string Id { get; set; }
    }
}
