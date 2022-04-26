using Playground.BaseClasses;
using Playground.Enums;
using Playground.StaticClasses;

XY point1 = new XY(5, 4);
XY point2 = new XY(5, 8);

for(int i = 0; i < 10; i++)
{
    RandomPointGenerator.GetRandomPoint().Print();
}
