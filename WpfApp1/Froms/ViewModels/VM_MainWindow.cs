using Playground.BaseClasses;
using Playground.StaticClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MainClasses;

namespace WpfApp1.Froms.ViewModels
{
    public class VM_MainWindow : DataContext
    {
        public ObservableCollection<Person> People { get => Get(); set => Set(value); }
        public Person SelectedPerson { get => Get(); set => Set(value); }

        public VM_MainWindow()
        {
            InitializeProperties();
        }

        private void InitializeProperties()
        {
            People = new ObservableCollection<Person>();
            SelectedPerson = People.FirstOrDefault();
        }

        public void GetPeople()
        {
            People.Clear();
            RandomPersonGenerator.GetPeople(10).ForEach(x => People.Add(x));
        }

        public async Task GetPeopleFromAPI(int count)
        {
            People.Clear();
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResult = await httpClient.GetAsync(GetPeopleURL(count));

            if (httpResult.IsSuccessStatusCode)
                People = await httpResult.Content.ReadFromJsonAsync<ObservableCollection<Person>>();
        }

        public static string GetPeopleURL(int count) => $"https://localhost:7266/people?count={count}";
    }
}
