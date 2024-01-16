using System;
using YourNamespace.Models;
using Microsoft.Maui.Controls;

namespace TodoOdev.Views
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();

            var weatherInfo = new WeatherInfo
            {
                City = "Ankara",
                Temperature = "15°C",
                Description = "Parçalý bulutlu"
            };

            CityLabel.Text = weatherInfo.City;
            TemperatureLabel.Text = weatherInfo.Temperature;
            DescriptionLabel.Text = weatherInfo.Description;
        }
    }
}
