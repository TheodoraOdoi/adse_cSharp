namespace sess07_properties_records_indexers
{
    /// <summary>
    /// This program demonstrates a read only property to display the current time
    /// </summary>
    public class ReadOnlyProp
    {
        private DateTime _currentTime = DateTime.Now;

        public DateTime CurrentTime { get { return _currentTime; } }

        static void Main(string[] args)
        {
            Console.WriteLine($"The current time is {new ReadOnlyProp().CurrentTime:T}");
        }

    }
}