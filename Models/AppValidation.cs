using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Models
{
    public static class AppValidation
    {
        public static bool Email (string email)
        {
            Regex emailRegex=new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }
        public static bool Name (string name)
        {
            Regex nameRegex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
           
            return nameRegex.IsMatch(name)&&(name.Length>=3 && name.Length<=50);
        }
        public static bool LengthValidation(string text)
        {
            return text.Length >= 3 && text.Length <= 50;
        }
        public static bool BirthDate (DateTime date)
        {
            return (date.Year >= 1920 && date.Year <= 2003);
        }

    }
}
