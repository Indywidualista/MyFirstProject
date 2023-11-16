namespace MyFirstProject
{
    public abstract class Footballer
    {
        public Footballer(string nickname, string country)
        {
            this.Nickname = nickname;
            this.Country = country;
        }

        public Footballer(string name, string surname, string country)
        {
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Country { get; private set; } 
        public string Nickname { get; private set; }

    }
}
