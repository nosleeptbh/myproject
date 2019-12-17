using myproject.Services;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms.Xaml;


namespace myproject.Services
{
    public static class DataService
    {
        public static List<string> Contacts { get; } = new List<string>
        {
            "Adrienne",
            "Charlie",
            "David",
            "Enda",
            "John",
            "Kate",
            "Kim",
            "Nathan",
            "Owen",
            "Raymond"
            
          
            
        };

        public static List<string> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return Contacts.Where(f => f.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }   
    }
}

