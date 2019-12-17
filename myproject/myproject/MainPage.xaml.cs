using myproject.Services;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms.Xaml;


namespace myproject
{
    public partial class MainPage : ContentPage
    {

        //variables
        String Test;
        String nameNum, nameNum2, nameNum3, nameNum4, nameNum5;
        String savedNum, savedNum2, savedNum3, savedNum4, savedNum5;
        int counter, counter2;
               
        public MainPage()
        {
            InitializeComponent();
         
            searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }



        // Predictive searchbar
        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }

        // New Contact button
        async void OnButtonClicked2(object sender, EventArgs args)
        {           
            await DisplayAlert("Add new Contact", "Fill in name and Number", "OK");
            saveContact.IsVisible = true;

            AccountName.Text = " ";
            NewAccountName.Text = " ";
            MobileNo.Text = " ";
            WorkNo.Text = " ";
            EmailAddress.Text = " ";
            Facebook.Text = " ";
            Instagram.Text = " ";
            Snapchat.Text = " ";

            newContact.IsVisible = true;            
        }

        // Contact saved button
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Contact added!", "New contacts are displayed below favourites", "OK");
            saved.IsVisible = true;
            counter2++;

            //if statement to save multipul contacts 
            if (counter2 == 1)
            {
                savedNum = NewAccountName.Text + MobileNo.Text;
                newNumber.Text = savedNum;
            }
            else if (counter2 == 2)
            {
                savedNum2 = NewAccountName.Text + MobileNo.Text;
                newNumber2.Text = savedNum2;
            }
            else if (counter2 == 3)
            {
                savedNum3 = NewAccountName.Text + MobileNo.Text;
                newNumber3.Text = savedNum3;
            }
            else if (counter2 == 4)
            {
                savedNum4 = NewAccountName.Text + MobileNo.Text;
                newNumber4.Text = savedNum4;
            }
            else if (counter2 == 5)
            {
                savedNum5 = NewAccountName.Text + MobileNo.Text;
                newNumber5.Text = savedNum5;
            }


        }

        // Favourite button
        async void OnButtonClicked(object sender, EventArgs args)
        {
                    
            await DisplayAlert("Added to favourite!", "Favourites displayed below", "OK");
            counter++;

            if(counter == 1)
            {                
                nameNum = AccountName.Text + MobileNo.Text;
                favouriteName.Text = nameNum;
            }
            else if(counter == 2)
            {
                nameNum2 = AccountName.Text + MobileNo.Text;
                favouriteName2.Text = nameNum2;
            }
            else if (counter == 3)
            {
                nameNum3 = AccountName.Text + MobileNo.Text;
                favouriteName3.Text = nameNum3;
            }
            else if (counter == 4)
            {
                nameNum4 = AccountName.Text + MobileNo.Text;
                favouriteName4.Text = nameNum4;
            }
            else if (counter == 5)
            {
                nameNum5 = AccountName.Text + MobileNo.Text;
                favouriteName5.Text = nameNum5;
            }
            favourite.IsVisible = true;
        }

        //Contact list
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {

            newContact.IsVisible = false;

            if (e.SelectedItem == null)
            {
                return;
            }
            
            Test = e.SelectedItem.ToString();

            if(Test == "Adrienne")
            {
                AccountName.Text = "Adrienne Duen ";
                MobileNo.Text = "0862091260";
                WorkNo.Text = "0862091197";
                EmailAddress.Text = "adriennetest@gmail.com";
                Facebook.Text = "Adrienne Duen";
                Instagram.Text = "adrienne3000";
                Snapchat.Text = "chewbacaX";
            }      
            else if (Test == "Charlie")
            {
                AccountName.Text = "Charlie Piermain ";
                MobileNo.Text = "0872091007";
                WorkNo.Text = "0872091340";
                EmailAddress.Text = "charlietest@gmail.com";
                Facebook.Text = "Charlie Piermain";
                Instagram.Text = "charlie_piermain1";
                Snapchat.Text = "charles174";
            }
            else if (Test == "David")
            {
                AccountName.Text = "David Oloughran ";
                MobileNo.Text = "0862091029";
                WorkNo.Text = "0862091106";
                EmailAddress.Text = "davidtest@gmail.com";
                Facebook.Text = "David OLoughran";
                Instagram.Text = "dav0loughran";
                Snapchat.Text = "david98";
            }
            else if (Test == "Enda")
            {
                AccountName.Text = "Enda Goggins ";
                MobileNo.Text = "0872091729";
                WorkNo.Text = "0872091782";
                EmailAddress.Text = "endatest@gmail.com";
                Facebook.Text = "Enda Goggins";
                Instagram.Text = "gogginsenda";
                Snapchat.Text = "froggy1";
            }
            else if (Test == "John")
            {
                AccountName.Text = "John Kelly ";
                MobileNo.Text = "0832091517";
                WorkNo.Text = "0832091685";
                EmailAddress.Text = "johntest@gmail.com";
                Facebook.Text = "John Kelly";
                Instagram.Text = "Ke11y";
                Snapchat.Text = "johnkelly99";
            }
            else if (Test == "Kate")
            {
                AccountName.Text = "Kate Holms ";
                MobileNo.Text = "0892091707";
                WorkNo.Text = "089209140826";
                EmailAddress.Text = "katetest@gmail.com";
                Facebook.Text = "Kate Holms";
                Instagram.Text = "artgirl2001";
                Snapchat.Text = "kate.holms";

            }
            else if (Test == "Kim")
            {
                AccountName.Text = "Kim Vlanderin ";
                MobileNo.Text = "0862091782";
                WorkNo.Text = "0862917267";
                EmailAddress.Text = "kimtest@gmail.com";
                Facebook.Text = "Kim Vlanderin";
                Instagram.Text = "small_p1xel";
                Snapchat.Text = "kimlikesfood";
            }
            else if (Test == "Nathan")
            {
                AccountName.Text = "Nathan Geraghty ";
                MobileNo.Text = "0872091815";
                WorkNo.Text = "0872091468";
                EmailAddress.Text = "nathantest@gmail.com";
                Facebook.Text = "Nathan Geraghty";
                Instagram.Text = "npgeraghty";
                Snapchat.Text = "geraghty47";
            }
            else if (Test == "Owen")
            {
                AccountName.Text = "Owen Kelly ";
                MobileNo.Text = "0858355556";
                WorkNo.Text = "0858355594";
                EmailAddress.Text = "owentest@gmail.com";
                Facebook.Text = "Owen Kelly";
                Instagram.Text = "owenkelly1";
                Snapchat.Text = "bigdawg";
            }
            else if (Test == "Raymond")
            {
                AccountName.Text = "Raymond Gunnings ";
                MobileNo.Text = "0878555583";
                WorkNo.Text = "0878355555";
                EmailAddress.Text = "raymondtest@gmail.com";
                Facebook.Text = "Raymond Gunning";
                Instagram.Text = "raygunning";
                Snapchat.Text = "raygunning123";
            }
        }
    }
}

