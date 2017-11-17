using System;

namespace Utils
{
    public static class EmailUtils
    {
        public static bool IsValidEmail(string email)
        {
            var emailPattern = new System.Text.RegularExpressions.Regex(@"^.+?@.+\..+$");
            return emailPattern.IsMatch(email);
        }
    }
}
