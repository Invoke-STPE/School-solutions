namespace CalculationSimulation
{
    /// <summary>
    /// This class acts as a cache of already calculated results
    /// </summary>
    public class Cache
    {
        #region Instance fields
        private int[,] cacheValues;
        private const int MaxGrid = 5;
        private const int MinGrid = 0;
        private const int NoValue = -1;
        #endregion

        #region Constructor
        public Cache()
        {
            // Create a 5x5 cache of results
            cacheValues = new int[MaxGrid, MaxGrid];

            for (int x = MinGrid; x < MaxGrid; x++)
            {
                for (int y = MinGrid; y < MaxGrid; y++)
                {
                    cacheValues[x, y] = NoValue; // -1 means "no result stored"
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Look up the value stored in cell [x,y]
        /// </summary>
        public int Lookup(int x, int y)
        {
            return cacheValues[x, y];
        }

        /// <summary>
        /// Stores the given value in cell [x,y]
        /// </summary>
        public void Insert(int x, int y, int value)
        {
            cacheValues[x, y] = value;
        } 
        #endregion
    }
}
