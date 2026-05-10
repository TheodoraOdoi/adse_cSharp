namespace sess06_abstract_classes_and_interfaces
{
    /// <summary>
    /// This interface has methods that all 2 dimensional shapes must implement to
    /// calculate their perimeter or circumference
    /// </summary>
    public interface I2DShape
    {
        /// <summary>
        /// Method to calculate the perimeter of the 2-D shape
        /// </summary>
        /// <returns>The perimeter of the shape as a float</returns>
        public float CalcPerimeter();

        /// <summary>
        /// Default method to calculate the circumference of the 2-D circle
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        /// <returns>The circumference of the circle as a float</returns>
        public virtual float CalcCircum1ference(int radius)
        {
            return (float)(Math.PI * (radius * 2));
        }
    }
}
