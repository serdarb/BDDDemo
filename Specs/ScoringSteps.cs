using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specs
{
    using NUnit.Framework;

    using SuperBowlingScorer;

    [Binding]
    public class ScoringSteps {
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
        public void ThenIShouldSeeAnAndAMessageThatSays(string p0, string p1)
        {
            Assert.AreEqual("Good job!",_scorer.BowlerMessage);
            Assert.AreEqual("X", _scorer.Score);
        }
    }
}
