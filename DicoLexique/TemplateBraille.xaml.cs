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
        String vnv;
        public TemplateBraille()
        {
            this.InitializeComponent();
            this.lepivot.SelectionChanged += Lepivot_SelectionChanged;
        }

        private void Lepivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Accueil = new Accueil();
            this.Favoris = new Favoris();
            this.Reglages = new Reglages();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //vnv = e.Parameter as String;
            //if (this.vnv.Equals("true"))
            //{

            //}
            //else
            //{
            //    this.Btn_micro.SetValue(Grid.RowSpanProperty, 1);
            //    this.Btn_micro.SetValue(Grid.RowProperty, 2);
            //    this.Btn_micro_m.SetValue(Grid.RowSpanProperty, 1);
            //    this.Btn_micro_m.SetValue(Grid.RowProperty, 2);
            //    this.gridPivot.SetValue(Grid.RowSpanProperty, 2);
            //}
            base.OnNavigatedTo(e);
        }
    }
}
