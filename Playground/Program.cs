using Playground.BaseClasses;
using Playground.Enums;
using Playground.StaticClasses;
using System.Drawing;

List<Person> persons = new List<Person>(); 

for(int i = 0; i < 50; i++)
{
    persons.Add(RandomPersonGenerator.GetRandomPerson());
}

persons.ForEach(persons => persons.PrintOut());


