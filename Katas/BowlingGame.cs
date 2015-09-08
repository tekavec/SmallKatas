namespace Katas
{
    public class BowlingGame
    {
        private int _CurrentRoll;
        private readonly int[] _Rolls = new int[21];
        private const int MaxPinsInOneFrame = 10;

        public void Roll(int pins)
        {
            _Rolls[_CurrentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += MaxPinsInOneFrame + GetStrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += MaxPinsInOneFrame + GetSpareBouns(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfPinsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

        private int GetSpareBouns(int frameIndex)
        {
            return _Rolls[frameIndex + 2];
        }

        private int GetStrikeBonus(int frameIndex)
        {
            return _Rolls[frameIndex + 1] + _Rolls[frameIndex + 2];
        }

        private bool IsStrike(int frameIndex)
        {
            return (_Rolls[frameIndex] == MaxPinsInOneFrame);
        }

        private bool IsSpare(int frameIndex)
        {
            return (SumOfPinsInFrame(frameIndex)) == MaxPinsInOneFrame;
        }

        private int SumOfPinsInFrame(int frameIndex)
        {
            return _Rolls[frameIndex] + _Rolls[frameIndex + 1];
        }
    }
}