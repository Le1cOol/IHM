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

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace DicoLexique
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class TemplateBase : Page
    {
        public TemplateBase()
        {
            this.InitializeComponent();
            this.lepivot.SelectionChanged += Lepivot_SelectionChanged;
            this.Accueil.Children.Add(new Accueil());
            this.Favoris.Children.Add(new Favoris());
            this.Reglages.Children.Add(new Reglages());
        }

        private void Lepivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
