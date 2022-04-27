using Playground.BaseClasses;
using Playground.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MainClasses;

namespace WpfApp1.Froms.ViewModels
{
    public class VM_MainWindow : DataContext
    {
        public string People { get => Get(); set => Set(value); }

        public VM_MainWindow()
        {
            People = "";
        }

        public void GetPeople() =>
                People += $"{RandomPersonGenerator.GetRandomPerson()}\n\n";
    }
}
