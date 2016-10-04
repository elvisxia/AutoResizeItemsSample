using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AutoResizeItemsSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Random rand = new Random();
            List<Item> list = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                int count = rand.Next(20);
                String str = String.Empty;
                for (int j = 0; j < count; j++)
                {
                    str += "word ";
                }
                var item = new Item
                {
                    Text = str
                };
                list.Add(item);
            }
            gridView.ItemsSource = list;
            base.OnNavigatedTo(e);
        }
        
        
    }

    public class Item
    {
        public String Text { get; set; }
    }
}
