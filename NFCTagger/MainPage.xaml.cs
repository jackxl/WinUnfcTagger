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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NFCTagger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ListView bla = DatabindingExampleListView();
            List<String> bla2 = DatabindingExampleList();

            svItemList.Items.Add(bla);
        }

        private ListView DatabindingExampleListView()
        {
            ListView list = new ListView();
            list.Items.Add("Item 0");
            list.Items.Add("Item 1");
            list.Items.Add("Item 2");
            list.Items.Add("Item 3");
            list.Items.Add("Item 4");

            list.SelectionChanged += List_SelectionChanged;

            return list;
        }
        private List<string> DatabindingExampleList()
        {
            List<String> list = new List<string>();
            list.Add("Item 0");
            list.Add("Item 1");
            list.Add("Item 2");
            list.Add("Item 3");
            list.Add("Item 4");
            
            return list;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SolidColorBrush blueBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(1, 0, 0, 1));
            this.Background = blueBrush;
        }

        private void svItemList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SolidColorBrush blueBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(1,0,0,1));
            this.Background = blueBrush;
            var obj = (ListView)sender
//            tbContent.Text = 
        }

        private void btHamburger_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }
    }
}
