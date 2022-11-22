using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyingSellingGuide.Validation
{
    public static class CarValidation
    {
        public static bool Year(int year, string message)
        {
            int yearnow = DateTime.Now.Year;
            if (!(year >= 1920 && year<=yearnow))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
        public static bool LengthValidation(string text, string message)
        {
            if (!(text.Length >= 1 && text.Length <= 50))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
        public static bool CarRegNum(string name, string message)
        {
            if (!(name.Length >= 7 && name.Length <= 8))
            {
                MessageBox.Show(message);
                return false;
            }
            else return true;
        }
    }
}
