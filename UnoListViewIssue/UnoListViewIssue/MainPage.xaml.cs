using System.Collections.ObjectModel;

namespace UnoListViewIssue
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var items = new ObservableCollection<string>(new[]
            {
                "String 1",
                "String 1",
                "String 1",
                "String 2",
                "String 2",
                "String 2",
                "String 3",
                "String 3",
                "String 3",
                "String 1",
                "String 1",
                "String 1",
                "String 2",
                "String 2",
                "String 2",
                "String 3",
                "String 3",
                "String 3",
            });
            listView.ItemsSource = items;
        }
    }
}