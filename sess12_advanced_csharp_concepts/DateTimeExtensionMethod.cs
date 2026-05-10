namespace sess12_advanced_csharp_concepts
{
    /// <summary>
    /// Provides an extension method for the <see cref="DateTime"/> struct.
    /// </summary>
    public static class DateTimeExtensionMethod
    {
        /// <summary>
        /// Formats a <see cref="DateTime"/> object as a string in the "dd-MM-yyyy" format.
        /// If the year is before 2000, the "19" prefix is removed from the year.
        /// </summary>
        /// <param name="date">The <see cref="DateTime"/> object to format.</param>
        /// <returns>A formatted date string.</returns>
        /// <example>
        /// <code>
        /// DateTime date1 = new DateTime(2016, 03, 25);
        /// Console.WriteLine(date1.FormatDate()); // output: 25-03-2016
        /// 
        /// DateTime date2 = new DateTime(1996, 03, 12);
        /// Console.WriteLine(date2.FormatDate()); // output: 12-03-1996
        /// </code>
        /// </example>
        public static string FormatDate(this DateTime date)
        {
            string dateFormat = date.ToString("dd-mm-yyyy");
            return date.Year >= 2000 ? dateFormat : dateFormat.Replace("19", "");
        }

        static void Main (string [] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.FormatDate());

            DateTime date1 = new DateTime(1996, 03, 12);
            Console.WriteLine(date1.FormatDate());
        }
    }
}
