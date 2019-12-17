using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using myproject.Services;

namespace myproject
{
    public class SearchBarRealtimeCodePage : ContentPage
    {
        ListView searchResults;

        public SearchBarRealtimeCodePage()
        {
            Title = "Code Realtime SearchBar";
            Padding = 10;

            SearchBar searchBar = new SearchBar
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Placeholder = "Search contacts...",
                CancelButtonColor = Color.Blue,
                PlaceholderColor = Color.Blue
            };

            Label label = new Label
            {
                Text = "Type in the searchbox to filter results in realtime.",
                HorizontalOptions = LayoutOptions.Fill, 
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            searchResults = new ListView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            Content = new StackLayout
            {
                Children =
                {
                    searchBar,
                    label,
                    searchResults
                }
            };

            searchBar.TextChanged += OnTextChanged;
            searchResults.ItemsSource = DataService.Contacts;
        }

        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }


    }
}
