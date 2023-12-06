using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace CountryInfo.Models.ViewModels
{
    public partial class CountryViewModel : ObservableObject
    {
        /// <summary>
        /// The selected country
        /// </summary>
        private Country _selectedCountry;

        /// <summary>
        /// Gets or sets the selected country.
        /// </summary>
        /// <value>
        /// The selected country.
        /// </value>
        public Country SelectedCountry
        {
            get => _selectedCountry;
            set => SetProperty(ref _selectedCountry, value);
        }

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