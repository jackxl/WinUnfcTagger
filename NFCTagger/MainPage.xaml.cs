using NFCTagger.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NFCTagger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        /// <summary>
        /// Object required for databinding. Made private so it can't be changed
        /// </summary>
        private ObservableCollection<NavigationItem> _NavigationLinks = new ObservableCollection<NavigationItem>()
        {
            new NavigationItem() {name = "Home", symbol = Symbol.Home },
            new NavigationItem() {name = "Message", symbol = Symbol.Message },
            new NavigationItem() {name = "Message 2", symbol = Symbol.Message },
        };

        /// <summary>
        /// Allowes access for databinding, used c# 6.0 lampda expression to make it shorter
        /// </summary>
        public ObservableCollection<NavigationItem> navigationLinks => _NavigationLinks;

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event for clicking an item in the ListView.
        /// For now it only changes the background color for one specific item.
        /// </summary>
        private void svItemList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (sender != typeof(ListView))
                return;
            var listItem = sender as ListView;
            SolidColorBrush blueBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(1,0,0,1));
            listItem.Background = blueBrush;
        }

        private void btHamburger_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private async void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            var uriBing = new Uri(@"http://www.bing.com");
            var success = await Windows.System.Launcher.LaunchUriAsync(uriBing);

            tbOpenStatus.Text = success ? "Succes" : "Failed";
        }
    }
}
