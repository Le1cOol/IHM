using DicoLexique.Models;
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
    public sealed partial class Reglages : Page
    {
        private Settings settings = new Settings();

        public Reglages(Settings s)
        {
            this.settings = s;
            this.InitializeComponent();
            this.reglageMicroBox.IsChecked = settings.Micro;
            this.reglageBrailleBox.IsChecked = settings.ModeAveugle;
            this.reglageSonBox.IsChecked = settings.Sound;
        }

        private void reglageMicroBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.reglageMicroBox.IsChecked == true)
            {
                this.settings.Micro = true;
            }
            else
            {
                this.settings.Micro = false;
                (Window.Current.Content as Frame).Navigate(typeof(TemplateBase), settings);
            }
        }

        private void reglageBrailleBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.reglageBrailleBox.IsChecked == true)
            {
                this.settings.ModeAveugle = true;
                this.reglageMicroBox.IsChecked = true;
                this.reglageMicroBox.IsEnabled = false;
                (Window.Current.Content as Frame).Navigate(typeof(TemplateBraille), settings);
            }
            else
            {
                this.settings.ModeAveugle = false;
                this.reglageMicroBox.IsEnabled = true;
                (Window.Current.Content as Frame).Navigate(typeof(TemplateVocal), settings);
            }
        }

        private void reglageSonBox_Checked(object sender, RoutedEventArgs e)
        {
            if (this.reglageSonBox.IsChecked == true)
            {
                this.settings.Sound = true;
            }
            else
            {
                this.settings.Sound = false;
            }
        }
    }
}
