using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace LIstViewEditedDU
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname"));
            }
        }
        
        private DateTime _dob = new DateTime(2000, 01, 01);

        public DateTime Dob
        {
            get => _dob;
            set
            {
                _dob = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dob"));
            }
        }
        public static ObservableCollection<Person> AllPersons { get; set; } = new ObservableCollection<Person>();
        public static void InitPersons()
        {
            AllPersons.Add(new Person
            {
                Name = "Andrej",
                Surname = "Zlatý",
                Dob = new DateTime(2001, 05, 06)

            });
            AllPersons.Add(new Person
            {
                Name = "Nikita",
                Surname = "Blatný",
                Dob = new DateTime(1998, 05, 13)
            });
            AllPersons.Add(new Person
            {
                Name = "Jan",
                Surname = "Novák",
                Dob = new DateTime(2002, 03, 04)
            });
        }
    }
}
