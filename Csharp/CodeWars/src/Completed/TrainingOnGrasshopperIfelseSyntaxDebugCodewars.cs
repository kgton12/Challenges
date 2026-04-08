namespace CodeWars.Completed
{
    public class TrainingOnGrasshopperIfelseSyntaxDebugCodewars
    {
        private int health = 100;
        public int Health
        {
            get => health;
            set => health = value;
        }

        public TrainingOnGrasshopperIfelseSyntaxDebugCodewars()
        {
        }

        public bool CheckAlive()
        {
            if (Health <= 0)
                return false;
            else
                return true;
        }
    }
}
