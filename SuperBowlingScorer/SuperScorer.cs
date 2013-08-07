namespace SuperBowlingScorer
{
    public class SuperScorer
    {
        public int Frame { get; set; }

        public string Score { get; set; }
        public string BowlerMessage { get; set; }

        public SuperScorer()
        {
            Frame = 1;
        }

        private bool IsStrike(bool isFirstBall, int pinsKnockedDown)
        {
            return isFirstBall && pinsKnockedDown == 10;
        }

        public void ScoreFirtsBall(int pinsKnockedDown)
        {
            if (IsStrike(true, pinsKnockedDown))
            {
                Score = "X";
                BowlerMessage = "Good job!";
            }
        }
    }
}