using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace CountryInfo.Models.ViewModels
{
    public partial class CountryViewModel : ObservableObject
    {
        /// <summary>
        /// The selected country
        /// </summary>
        [ObservableProperty]
        private Country _selectedCountry;

        /// <summary>
        /// Loads the country data.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        public async Task LoadCountryData(string countryCode)
        {
            string apiUrl = $"https://restcountries.com/v2/alpha/{countryCode}";
            HttpClient client = new HttpClient();

            try
            {
                var response = await client.GetStringAsync(apiUrl);
                var countryData = JsonSerializer.Deserialize<Country>(response);

                SelectedCountry = countryData;
            }
            catch (Exception ex)
            {
                // Handel eventuele fouten af
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}