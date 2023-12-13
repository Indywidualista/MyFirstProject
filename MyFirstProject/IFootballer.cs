using static MyFirstProject.FootballerBase;

namespace MyFirstProject
{
    public interface IFootballer
    {
        string Name { get; }
        string Surname { get; }
        string Country { get; }
    }
}
