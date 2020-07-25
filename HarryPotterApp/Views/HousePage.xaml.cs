﻿using HarryPotterApp.Models;
using HarryPotterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HarryPotterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HousePage : ContentPage
    {
        public HousePage(House house)
        {
            InitializeComponent();
            BindingContext = new HouseViewModel(house);
        }
    }
}