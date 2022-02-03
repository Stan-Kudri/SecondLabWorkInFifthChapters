namespace SecondLabWorkInFifthChapters
{
    public class EuclidAlgorithm
    {
        public EuclidAlgorithm()
        {

        }

        public int GreatestCommonDivisor(int firstValue, int secondValue)
        {
            if (firstValue != secondValue)
            {
                if (firstValue > secondValue)
                    return GreatestCommonDivisor(firstValue - secondValue, secondValue);
                return GreatestCommonDivisor(secondValue, secondValue - firstValue);
            }
            return firstValue;
        }

        public int GreatestCommonDivisor(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue != secondValue)
            {
                if (firstValue > secondValue)
                    return GreatestCommonDivisor(firstValue - secondValue, secondValue);
                return GreatestCommonDivisor(secondValue, secondValue - firstValue);
            }
            return GreatestCommonDivisor(firstValue, thirdValue);
        }
    }
}
