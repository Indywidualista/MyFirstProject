namespace MyFirstProject
{
    public class Player
    {
        private int Score;

        public Player()
        {
            this.Name = "";
            this.Surname = "";
            this.Country = "";

        }
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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string Nickname { get; set; }

        public void SetName()
        {
            this.Name = Console.ReadLine();
        }
        public void SetSurname()
        {
            this.Surname = Console.ReadLine();
        }
        public void SetCountry()
        {
            this.Country = Console.ReadLine();
        }

    }
}
