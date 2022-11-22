using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmSystem.Validation
{
    public static class Validation
    {
        
        public static bool Email(string email,string message)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        } 
        public static bool Name(string name,string message)
        {
            Regex nameRegex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
            if(!(nameRegex.IsMatch(name) && (name.Length >= 3 && name.Length <= 15)))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
        public static bool LengthValidation(string text,string message)
        {
            if(!(text.Length >= 3 && text.Length <= 50))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
        public static bool BirthDate(DateTime date, string message)
        {
            if(!(date.Year >= 1920 && date.Year <= 2003))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
    }
}
