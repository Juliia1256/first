using CitiesAPI.Model;

namespace CitiesAPI.ViewModels
{
    public class CityInfoViewModel
    {
        public CityInfoViewModel(City city)
        {
            Id = city.Id.ToString("N");
            Title = city.Title;
        }

        public string Id { get; set; }
        public string Title { get; set; }

    }
}
