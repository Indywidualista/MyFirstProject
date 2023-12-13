namespace MyFirstProject
{
    public class ScoreInFile
    {
        int goals = 0;
        int assist = 0;
        int ycard = 0;
        int rcard = 0;

        public void AddGoals()
        {
            goals++;
        }
        public void AddAssist()
        {
            assist++;
        }
        public void AddYellowCard()
        {
            int yellowCardCount = int.Parse(Console.ReadLine());
            ycard += yellowCardCount;
            if (ycard >=2 )
            {
                AddRedCard();
            }
        }
        public void AddRedCard()
        {
            int redCardCount = int.Parse(Console.ReadLine());
            rcard += redCardCount;
        }
    }
}
