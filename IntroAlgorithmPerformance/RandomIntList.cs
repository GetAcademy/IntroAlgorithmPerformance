namespace IntroAlgorithmPerformance
{
    internal class RandomIntList : List<int>
    {
        public RandomIntList(int size) : base(size)
        {
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                this[i] = random.Next();
            }
        }
    }
}
