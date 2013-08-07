namespace Specs
{
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    using SuperBowlingScorer;

    [Binding]
    public class ScoringSteps
    {
        private SuperScorer _scorer;
        [Given(@"I am on the first frame")]
        public void GivenIAmOnTheFirstFrame()
        {
            _scorer = new SuperScorer();
            Assert.AreEqual(1, _scorer.Frame);
        }

        [When(@"I bowl a strike")]
        public void WhenIBowlAStrike()
        {
            _scorer.ScoreFirtsBall(10);
        }

        [Then(@"I should see an ""(.*)"" and a message that says ""(.*)""")]
        public void ThenIShouldSeeAnAndAMessageThatSays(string score, string message)
        {
            Assert.AreEqual(score, _scorer.Score);
            Assert.AreEqual(message, _scorer.BowlerMessage);
        }

        [When(@"I bowl a gutter ball")]
        public void WhenIBowlAGutterBall()
        {
            _scorer.ScoreFirtsBall(0);
        }
    }
}
