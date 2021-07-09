using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FRIDAY.CyberOfSale.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            var nav = SystemNavigationManager.GetForCurrentView();
            nav.BackRequested += Nav_BackRequested;
        }

        private void Nav_BackRequested(object sender, BackRequestedEventArgs e)
        {
            var ignored = _navigationService.GoBackAsync();
            e.Handled = true;
        }

        private void appNavFrame_Navigated(object sender, NavigationEventArgs e)
        {
            switch (e.SourcePageType)
            {
                case Type c when e.SourcePageType == typeof(Home):
                    ((NavigationViewItem)navview.MenuItems[0]).IsSelected = true;
                    break;
                case Type c when e.SourcePageType == typeof(Player):
                    ((NavigationViewItem)navview.MenuItems[1]).IsSelected = true;
                    break;
                case Type c when e.SourcePageType == typeof(Favorites):
                    ((NavigationViewItem)navview.MenuItems[2]).IsSelected = true;
                    break;
                case Type c when e.SourcePageType == typeof(Notes):
                    ((NavigationViewItem)navview.MenuItems[3]).IsSelected = true;
                    break;
                case Type c when e.SourcePageType == typeof(Downloads):
                    ((NavigationViewItem)navview.MenuItems[4]).IsSelected = true;
                    break;
            }
        }
    }
}
