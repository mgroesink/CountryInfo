using CountryInfo.Models.ViewModels;

namespace CountryInfo
{
    public partial class MainPage : ContentPage
    {
        public CountryViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new CountryViewModel();
            this.BindingContext = ViewModel;
        }

        /// <summary>
        /// Called when [get country information clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void OnGetCountryInfoClicked(object sender, EventArgs e)
        {
            string countryCode = countryCodeEntry.Text;
            this.grid.IsVisible = !string.IsNullOrEmpty(countryCode);

            await ViewModel.LoadCountryData(countryCode);
        }

    }
}
