using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RTLDemo.ViewModels
{
    class ValidationsDemoVM : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region שם
        private bool showNameError;

        public bool ShowNameError 
        { 
            get => showNameError;
            set
            {
                showNameError = value;
                OnPropertyChanged("ShowNameError");
            }
        }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                ValidateName();
                OnPropertyChanged("Name");
            }
        }

        private string nameError;

        public string NameError
        {
            get => nameError;
            set
            {
                nameError = value;
                OnPropertyChanged("NameError");
            }
        }

        private void ValidateName()
        {
            this.ShowNameError = string.IsNullOrEmpty(Name);
        }
        #endregion
        #region גיל
        private bool showAgeError;

        public bool ShowAgeError
        {
            get => showAgeError;
            set
            {
                showAgeError = value;
                OnPropertyChanged("ShowAgeError");
            }
        }

        private double? age;

        public double? Age
        {
            get => age;
            set
            {
                age = value;
                ValidateAge();
                OnPropertyChanged("Age");
            }
        }

        private string ageError;

        public string AgeError
        {
            get => ageError;
            set
            {
                ageError = value;
                OnPropertyChanged("AgeError");
            }
        }

        private void ValidateAge()
        {
            this.ShowAgeError = !Age.HasValue || Age <= 13;
        }
        #endregion

        public ValidationsDemoVM()
        {
            this.NameError = "זהו שדה חובה";
            this.ShowNameError = false;
            this.AgeError = "הגיל חייב להיות גדול מ 13";
            this.ShowAgeError = false;
        }

    }
}
