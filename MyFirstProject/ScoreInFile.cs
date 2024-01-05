
namespace MyFirstProject
{
    public class ScoreInFile
    {
        public ScoreInFile()
        {
            this.Goals = 0;
            this.Assist = 0;
            this.Ycard = 0;
            this.Rcard = 0;
        }

        public int Goals { get; set; }
        public int Assist { get; set; }
        public int Ycard { get; set; }
        public int Rcard { get; set; }

        public void AddGoals()
        {
            this.Goals = int.Parse(Console.ReadLine());
        }
        public void AddAssist()
        {
            this.Assist = int.Parse(Console.ReadLine());
        }
        public void AddYellowCard()
        {
            this.Ycard = int.Parse(Console.ReadLine());
            if (Ycard >= 2)
            {
                this.Rcard++;
            }
        }
        public void AddRedCard()
        {
            this.Rcard = int.Parse(Console.ReadLine());
        }
        internal static void ShowPlayerStat(ScoreInFile scoreInFile)
        {
            if (scoreInFile != null)
            {
                Console.WriteLine("\nStatystyki:");
                Console.WriteLine($"Gole: {scoreInFile.Goals}");
                Console.WriteLine($"Asysty: {scoreInFile.Assist}");
                Console.WriteLine($"Żółte kartki: {scoreInFile.Ycard}");
                Console.WriteLine($"Czerwone kartki: {scoreInFile.Rcard}");
            }
            else
            {
                Console.WriteLine("Nie wprowadzono statystyk piłkarza");
            }
        }
    }
}
