using static MyFirstProject.FootballerBase;

namespace MyFirstProject
{
    internal interface IFootballer
    {
        string Name { get; }
        string Surname { get; }
        string Country { get; }
    }
}
