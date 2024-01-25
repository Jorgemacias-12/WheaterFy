using System;
using System.Collections.Generic;
using System.ComponentModel;
using WeatherFy.Models;
using WeatherFy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherFy.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}