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
    public partial class SpellPage : ContentPage
    {
        public SpellPage(Spell spell)
        {
            InitializeComponent();
            BindingContext = new SpellViewModel(spell);
        }
    }
}