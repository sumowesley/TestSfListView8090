using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSfListView.Models;

namespace TestSfListView.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {

        [ObservableProperty]
        public Country? selectedCountry;

        [ObservableProperty]
        public ObservableCollection<Country> countries = new();


        public MainPageViewModel()
        {
            Countries.Add(new Models.Country { Name = "Australia", IsoCode = "AU" });
            Countries.Add(new Models.Country { Name = "Brazil", IsoCode = "BR" });
            Countries.Add(new Models.Country { Name = "Canada", IsoCode = "CA" });
            Countries.Add(new Models.Country { Name = "China", IsoCode = "CN" });
            Countries.Add(new Models.Country { Name = "France", IsoCode = "FR" });
            Countries.Add(new Models.Country { Name = "Germany", IsoCode = "DE" });
            Countries.Add(new Models.Country { Name = "India", IsoCode = "IN" });
            Countries.Add(new Models.Country { Name = "Italy", IsoCode = "IT" });
            Countries.Add(new Models.Country { Name = "Japan", IsoCode = "JP" });
            Countries.Add(new Models.Country { Name = "Mexico", IsoCode = "MX" });
            Countries.Add(new Models.Country { Name = "Russia", IsoCode = "RU" });
            Countries.Add(new Models.Country { Name = "South Africa", IsoCode = "ZA" });
            Countries.Add(new Models.Country { Name = "Spain", IsoCode = "ES" });
            Countries.Add(new Models.Country { Name = "United Kingdom", IsoCode = "GB" });
            Countries.Add(new Models.Country { Name = "United States", IsoCode = "US" });

            SelectedCountry = Countries.First();

        }
    }
}
