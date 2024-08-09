using System.Text.RegularExpressions;


namespace Flarum.Api.Helpers
{
    public class StringHelper
    {
        public static string ConvertUnicodeToString(string source)
        {
            return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase | RegexOptions.Compiled).Replace(
                         source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
        }
    }
}
