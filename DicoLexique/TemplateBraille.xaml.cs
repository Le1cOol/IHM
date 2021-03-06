﻿using DicoLexique.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DicoLexique
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TemplateBraille : Page
    {
        private Settings settings = new Settings();

        public TemplateBraille()
        {
            this.InitializeComponent();
            this.lepivot.SelectionChanged += Lepivot_SelectionChanged;
            this.Accueil.Children.Add(new Accueil(settings));
            this.Favoris.Children.Add(new Favoris(settings));
            this.Reglages.Children.Add(new Reglages(settings));
        }

        private void Lepivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.settings = e.Parameter as Settings;
            base.OnNavigatedTo(e);
        }
        
    }
}
