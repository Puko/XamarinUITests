using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinUITests
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            ClickCommand = new Command(() =>
            {
                Click++;
                RaisePropertyChanged(nameof(Click));
            });
        }

        public ICommand ClickCommand { get; set; }
        public int Click { get; set; }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
