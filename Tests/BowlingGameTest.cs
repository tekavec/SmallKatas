using Katas;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class BowlingGameTest
    {
        private BowlingGame _Game;

        [SetUp]
        public void Initialize()
        {
            _Game = new BowlingGame();
        }

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, _Game.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, _Game.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            _Game.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, _Game.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            RollStrike();
            _Game.Roll(5);
            _Game.Roll(3);
            RollMany(16, 0);

            Assert.AreEqual(26, _Game.Score());
        }

        [Test]
        public void TestWholeGame()
        {
            RollMany(12, 10);

            Assert.AreEqual(300, _Game.Score());
        }


        private void RollStrike()
        {
            _Game.Roll(10);
        }

        private void RollSpare()
        {
            _Game.Roll(5);
            _Game.Roll(5);
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                _Game.Roll(pins);
            }
        }
    }
}
