using CitiesAPI.ViewModels;
using CitiesAPI.Model;
using CitiesAPI.Controllers;

namespace CitiesAPI.Model
{
    public static class StringExtension   //метод расширения (особенности: статические, должны в качестве первого аргумента принимать this - указывает какой тип расширяет)
    {
        public static string Capitalize(this string title)
        {
            return char.ToUpper(title[0]) + title.Substring(1).ToLower();
        }
    }
}
