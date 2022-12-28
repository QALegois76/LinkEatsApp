using System.Text.RegularExpressions;

namespace LinkEatsApp
{
    public static class AppSetting
    {
        public const string REGEX_PATTERN_PHONE= @"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
        public const string REGEX_PATTERN_MAIL  = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        public static readonly Regex RegexMail = new Regex(REGEX_PATTERN_MAIL);
        public static readonly Regex RegexPhone = new Regex(REGEX_PATTERN_PHONE);
    }
}
