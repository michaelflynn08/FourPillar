using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMoveable, IEquatable<Person?>, IComparable<Person>
    {
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (LastName != other.LastName)
            {
                return LastName.CompareTo(other.LastName);
            }
            else if (FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else { return Age.CompareTo(other.Age); }
        }
        
        //private string _firstName = "";
        //private string _lastName = "";

        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";
        public int Distance { get; set; }
        //public int Age { get; set; } //This does this: under the hood
        private int _age;
        public int Age
        {
            get { return _age; }
            set 
            { 
                if(value < 0 || value > 1000) throw new ArgumentOutOfRangeException("Invalid Age");
                _age = value; 
            }
        }
        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person(){    }

        public string FullName => $"{FirstName} {LastName}";

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"{FullName}";
        }

        public string Move()
        {
            Distance += 1;
            return $"Moved along 1 step. Distance: {Distance}";
        }

        public string Move(int times)
        {
            Distance += times;
            return $"Moved along {times} steps. Distance: {Distance}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Distance == other.Distance &&
                   _age == other._age &&
                   Age == other.Age &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Distance, _age, Age, FullName);
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);            
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}