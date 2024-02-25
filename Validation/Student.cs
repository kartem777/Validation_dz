using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    internal class Student : IDataErrorInfo
    {

        public string Name {  get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Number {  get; set; }
        public string this[string columnName]
        {
            get 
            { 
                string error = String.Empty;
                switch (columnName)
                { 
                    case "Age":
                        if ((Age < 0) || (Age > 100))
                        {
                            error = "Age can be from 0 to 100";
                        }
                        break;
                    case "Name":
                        if(Name.Length < 1)
                            {
                                error = "Name cannot be null";
                            }
                        break;
                    case "Password":
                        if (Password.Length < 8)
                        {
                            error = "Password length must be minimum 8 symbols";
                        }
                        break;
                    case "Number":
                        if (Number[0] != '+')
                        {
                            error = "Number first symbol is +";
                        }
                        else
                        {
                            if (Number.Length < 13)
                            {
                                error = "That is not a number";
                            }
                            for (int i = 1; i < Number.Length; i++)
                            {
                                if (Number[i] < 48 || Number[i] > 57)
                                {
                                    error = "That is not a number";
                                }
                            }
                        }
                        break;
                }
                return error;
            }
        }
        public Student(string name, string password, int age, string number)
        {
            Name = name;
            Password = password;
            Age = age;
            Number = number;
        }

        public string Error => throw new NotImplementedException();
    }
}
