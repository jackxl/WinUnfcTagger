using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace NFCTagger.Model
{
    public class NavigationItem
    {
        public string name { get; set; }
        public Symbol symbol { get; set; }
        public Type pageFrame { get; set; }
    }
}
