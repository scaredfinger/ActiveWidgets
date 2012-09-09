namespace ActiveWidgets.Utils
{
    /// <summary>
    /// Provides a more object oriented looking way to call <see cref="string.Format(string,object[])"/>
    /// </summary>
    public static class RenderExtension
    {
        /// <summary>
        /// Provides a cleaner way to call <see cref="string.Format(string,object[])"/>
        /// </summary>
        /// <param name="format">format string</param>
        /// <param name="args">arguments to be replaced</param>
        /// <returns>formatted string</returns>
        public static string Render(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}