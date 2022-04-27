using Playground.BaseClasses;
using Playground.StaticClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
            for (int i = 0; i < 5; i++)
                People.Add(RandomPersonGenerator.GetRandomPerson());
        }
    }
}
