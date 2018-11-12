﻿using NUnit.Framework;

namespace Ruyi.SDK.Online.Tests.Trueskill
{
    [TestFixture]
    public class FactorGraphTrueSkillCalculatorTests
    {
        [Test]
        public void FullFactorGraphCalculatorTests()
        {
            var calculator = new FactorGraphTrueSkillCalculator();

            // We can test all classes 
            TrueSkillCalculatorTests.TestAllTwoPlayerScenarios(calculator);
            TrueSkillCalculatorTests.TestAllTwoTeamScenarios(calculator);
            TrueSkillCalculatorTests.TestAllMultipleTeamScenarios(calculator);

            TrueSkillCalculatorTests.TestPartialPlayScenarios(calculator);
        }
    }
}
