using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.Models
{
    public class PersonModel:INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        //30 dakikada kaldım
        void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
