using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmployeeManagement
{
    public class Utilities
    {
        public bool validateField(string fieldName, string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput)) return false;

            switch (fieldName.ToLower())
            {
                case "name":
                    if (!Regex.IsMatch(userInput, "^[A-Za-z]+[A-Za-z ]*$")) return false;
                    break;

                case "address":
                    if (!Regex.IsMatch(userInput, "^[a-zA-Z0-9 ,:/\\-]*$")) return false;
                    break;

                case "designation":
                    if (Regex.IsMatch(userInput, "^[0-9-]*$") || !Regex.IsMatch(userInput, "^[a-zA-Z0-9 ,:/\\-]*$")) return false;
                    break;

                case "gender":
                    if (!Regex.IsMatch(userInput, "^[0-9-]*$")) return false;
                    break;

                case "salary":
                    if (!Regex.IsMatch(userInput, "^[0-9]+(\\.[0-9]{1,15})?$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Salary!!"); 
                        Console.ResetColor();
                        return false;
                    }
                    break;

                case "department":
                    if (!Regex.IsMatch(userInput, "^[0-9-]*$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Department!!");
                        Console.ResetColor();
                        return false;
                    }
                    break;

                case "departmentname":
                    if (Regex.IsMatch(userInput, "^[0-9-]*$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Department!!");
                        Console.ResetColor();
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}
