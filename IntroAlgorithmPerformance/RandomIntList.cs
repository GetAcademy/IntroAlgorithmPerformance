namespace IntroAlgorithmPerformance
{
    internal class RandomIntList : List<int>
    {
        public RandomIntList(int size) : base(size)
        {
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                Add(random.Next());
            }
        }
    }
}
