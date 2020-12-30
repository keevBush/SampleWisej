using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace HelloWorld.Extensions
{
    public static class Validations
    {
        public static void IsEmail (this string value, string fieldName = "")
        {
            try
            {
                MailAddress address = new MailAddress(value);
            }
            catch (Exception)
            {
                throw new Exception($"The field {fieldName} must be an email address");
            }
        }

        public static void IsRequired(this string value, string fieldName = "")
        {
            if (string.IsNullOrEmpty(value.Trim()))
                throw new Exception($"The field {fieldName} is required");
            if (string.IsNullOrWhiteSpace(value.Trim()))
                throw new Exception($"The field {fieldName} is required");
        }

        public static void IsDigits(this string value, string fieldName = "")
        {
            if (!char.IsDigit(value[0]) && value[0] != '+')
                throw new Exception($"The field {fieldName} must have only digits");

            for (var i = 1; i < value.Length; i++)
            {
                if(!char.IsDigit(value[i]))
                    throw new Exception($"The field {fieldName} must have only digits");
            }
        }
    }
}