namespace IntroAlgorithmPerformance
{
    internal class RandomSortedIntList : SortedSet<int>
    {
        public RandomSortedIntList(int size) 
        {
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                Add(random.Next());
            }
        }
    }
}
