namespace MyFirstProject
{
    public class Player
    {
        private int Score;
        public Player(string nickname, string country)
        {
            this.Nickname = nickname;
            this.Country = country;
            this.Score = 0;
        }

        public Player(string name, string surname, string country)
        {
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.Score = 0;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Country { get; private set; }
        public string Nickname { get; private set; }

    }
}
