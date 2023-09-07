namespace ObjectiveTestExercise2.Services
{
    public static class CounterService
    {
        private static readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();

        private static int _count = 0;

        public static int GetCount()
        {
            try
            {
                _rwLock.EnterReadLock();
                return _count;
            }
            finally
            {
                _rwLock.ExitReadLock();
            }
        }

        public static void AddCount(int count)
        {
            try
            {
                _rwLock.EnterWriteLock();
                _count += count;
            }
            finally
            {
                _rwLock.ExitWriteLock();
            }
        }
    }
}
