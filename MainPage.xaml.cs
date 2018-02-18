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
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Microsoft.Toolkit.Uwp;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.UI;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.TitleBar.BackgroundColor = Colors.Transparent;
            appView.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            Frame1.Navigate(typeof(BlankPage1));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RightColumnCA.Width = new GridLength(100, GridUnitType.Pixel);
            Rectable1.Margin = new Thickness(0,60,0,0);
        }

        //test https://stackoverflow.com/questions/6192739/how-do-i-raise-an-event-in-a-usercontrol-and-catch-it-in-mainpage
        //test2 https://stackoverflow.com/questions/36128148/pass-click-event-of-child-control-to-the-parent-control
    }
}
