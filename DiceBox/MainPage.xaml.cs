using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DiceBox.Resources;
using System.ComponentModel;

namespace DiceBox
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class data : INotifyPropertyChanged
    {
        public IEnumerable <string> diceSizes { get; private set; }

        public data()
        {
            diceSizes = "D2 D3 D4 D5 D6 D8 D10 D20 D100".Split();
        }

        private void InvokePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}