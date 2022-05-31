using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Northwind.BLL.Helpers
{
    public static class Validator
    {
        // Regular expression used to validate a phone number.
        public const string reg = @"^([2]{1})([6]{1})([5]{1})([1|2|8|9]{1})([0-9]{6})([0-9]{2})?$";

        public static async Task<bool> IsPhoneNumber(string number)
        {
            //if (number is not null) return
            await Task.Run(() => Regex.IsMatch(number, reg));
            //else return false;

            return await Task.Run(() => true);
        }

        public static async Task<bool> IsFaxNumber(string fax)
        {
            //if (fax is not null) return
            await Task.Run(() => Regex.IsMatch(fax, reg));

            ////Fax is a nullable if the input is null return true
            //else return false;
            return await Task.Run(() => true);
        }

        public static async Task<bool> IsValidShort(short num, short min = 1, short max = short.MaxValue)
        {
            return await Task.Run(() => (num >= min && num <= max));    
        }

        public static async Task<bool> IsValidShort(short? num, short min = 1, short max = short.MaxValue)
        {
            return await Task.Run(() => (num >= min && num <= max));
        }

        public static async Task<bool> IsValidInt(int num, int min = 1, int max = int.MaxValue)
        {
            return await Task.Run(() => (num >= min && num <= max));
        }

        public static async Task<bool> IsValidFloat(float num, float min = 0.00F, float max = float.MaxValue)
        {
            return await Task.Run(() => (num >= min && num <= max));
        }

        public static async Task<bool> IsValidFloat(float? num, float min = 0, float max = float.MaxValue)
        {
            return await Task.Run(() => (num > min && num <= max));
        }

        public static async Task<bool> IsValidString(string item, int maxLength = int.MaxValue, bool checkIfNull = true)
        {
            if(checkIfNull)
            {
                if (string.IsNullOrWhiteSpace(item)) return false;
            }
            return await Task.Run(() => (item.Length <= maxLength));
        }

        public static async Task<bool> IsValidByteArray(byte[] item, int min = 0)
        {
            return await Task.Run(() => (item is not null && item.Length > min));
        }

        public static async Task<bool> IsValidDate(DateTime? date, DateTime? minDate = null, DateTime? maxDate = null)
        {
            return await Task.Run(() => true);
        }
    }
}
