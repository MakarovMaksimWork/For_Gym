using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Line
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private const string Progress1Key = "Progress1";
        private const string Progress2Key = "Progress2";
        private const string Progress3Key = "Progress3";
        private const string Progress4Key = "Progress4";
        private const string Progress5Key = "Progress5";
        private const string Progress6Key = "Progress6";
        private const string Progress7Key = "Progress7";
        private const string Progress8Key = "Progress8";
        private const string Progress9Key = "Progress9";
        private const string Progress10Key = "Progress10";
        private const string Progress11Key = "Progress11";
        private const string Progress12Key = "Progress12";
        private const string Progress13Key = "Progress13";
        // Repeat this pattern for each button/progress bar pair

        private double _progress1 = 0;
        private double _progress2 = 0;
        private double _progress3 = 0;
        private double _progress4 = 0;
        private double _progress5 = 0;
        private double _progress6 = 0;
        private double _progress7 = 0;
        private double _progress8 = 0;
        private double _progress9 = 0;
        private double _progress10 = 0;
        private double _progress11 = 0;
        private double _progress12 = 0;
        private double _progress13 = 0;
        // Repeat this pattern for each button/progress bar pair

        public event PropertyChangedEventHandler PropertyChanged;

        public double Progress1
        {
            get { return _progress1; }
            set
            {
                _progress1 = value;
                OnPropertyChanged();
                Preferences.Set(Progress1Key, _progress1);
            }
        }

        public double Progress2
        {
            get { return _progress2; }
            set
            {
                _progress2 = value;
                OnPropertyChanged();
                Preferences.Set(Progress2Key, _progress2);
            }
        }

        public double Progress3
        {
            get { return _progress3; }
            set
            {
                _progress3 = value;
                OnPropertyChanged();
                Preferences.Set(Progress3Key, _progress3);
            }
        }

        public double Progress4
        {
            get { return _progress4; }
            set
            {
                _progress4 = value;
                OnPropertyChanged();
                Preferences.Set(Progress4Key, _progress4);
            }
        }


        public double Progress5
        {
            get { return _progress5; }
            set
            {
                _progress5 = value;
                OnPropertyChanged();
                Preferences.Set(Progress5Key, _progress5);
            }
        }

        public double Progress6
        {
            get { return _progress6; }
            set
            {
                _progress6 = value;
                OnPropertyChanged();
                Preferences.Set(Progress6Key, _progress6);
            }
        }

        public double Progress7
        {
            get { return _progress7; }
            set
            {
                _progress7 = value;
                OnPropertyChanged();
                Preferences.Set(Progress7Key, _progress7);
            }
        }

        public double Progress8
        {
            get { return _progress8; }
            set
            {
                _progress8 = value;
                OnPropertyChanged();
                Preferences.Set(Progress8Key, _progress8);
            }
        }

        public double Progress9
        {
            get { return _progress9; }
            set
            {
                _progress9 = value;
                OnPropertyChanged();
                Preferences.Set(Progress9Key, _progress9);
            }
        }

        public double Progress10
        {
            get { return _progress10; }
            set
            {
                _progress10 = value;
                OnPropertyChanged();
                Preferences.Set(Progress10Key, _progress10);
            }
        }

        public double Progress11
        {
            get { return _progress11; }
            set
            {
                _progress11 = value;
                OnPropertyChanged();
                Preferences.Set(Progress11Key, _progress11);
            }
        }

        public double Progress12
        {
            get { return _progress12; }
            set
            {
                _progress12 = value;
                OnPropertyChanged();
                Preferences.Set(Progress12Key, _progress12);
            }
        }

        public double Progress13
        {
            get { return _progress13; }
            set
            {
                _progress13 = value;
                OnPropertyChanged();
                Preferences.Set(Progress13Key, _progress13);
            }
        }
        // Repeat this pattern for each button/progress bar pair

        public MainPage()
        {
            InitializeComponent();

            if (Preferences.ContainsKey(Progress1Key))
            {
                _progress1 = Preferences.Get(Progress1Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress2Key))
            {
                _progress2 = Preferences.Get(Progress2Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress3Key))
            {
                _progress3 = Preferences.Get(Progress3Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress4Key))
            {
                _progress4 = Preferences.Get(Progress4Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress5Key))
            {
                _progress5 = Preferences.Get(Progress5Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress6Key))
            {
                _progress6 = Preferences.Get(Progress6Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress7Key))
            {
                _progress7 = Preferences.Get(Progress7Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress8Key))
            {
                _progress8 = Preferences.Get(Progress8Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress9Key))
            {
                _progress9 = Preferences.Get(Progress9Key, 0.0);
            }
            if (Preferences.ContainsKey(Progress10Key))
            {
                _progress10 = Preferences.Get(Progress10Key, 0.0);
            }
            if (Preferences.ContainsKey(Progress11Key))
            {
                _progress11 = Preferences.Get(Progress11Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress12Key))
            {
                _progress12 = Preferences.Get(Progress12Key, 0.0);
            }

            if (Preferences.ContainsKey(Progress13Key))
            {
                _progress13 = Preferences.Get(Progress13Key, 0.0);
            }
            // Repeat this pattern for each button/progress bar pair

            BindingContext = this;
        }

        private void OnButton1Clicked(object sender, EventArgs e)
        {
            Progress1 += 0.01;
        }

        private void OnButton2Clicked(object sender, EventArgs e)
        {
            Progress2 += 0.01;
        }

        private void OnButton3Clicked(object sender, EventArgs e)
        {
            Progress3 += 0.01;
        }

        private void OnButton4Clicked(object sender, EventArgs e)
        {
            Progress4 += 0.01;
        }

        private void OnButton5Clicked(object sender, EventArgs e)
        {
            Progress5 += 0.01;
        }

        private void OnButton6Clicked(object sender, EventArgs e)
        {
            Progress6 += 0.01;
        }

        private void OnButton7Clicked(object sender, EventArgs e)
        {
            Progress7 += 0.01;
        }

        private void OnButton8Clicked(object sender, EventArgs e)
        {
            Progress8 += 0.01;
        }

        private void OnButton9Clicked(object sender, EventArgs e)
        {
            Progress9 += 0.01;
        }

        private void OnButton10Clicked(object sender, EventArgs e)
        {
            Progress10 += 0.01;
        }

        private void OnButton11Clicked(object sender, EventArgs e)
        {
            Progress11 += 0.01;
        }

        private void OnButton12Clicked(object sender, EventArgs e)
        {
            Progress12 += 0.01;
        }

        private void OnButton13Clicked(object sender, EventArgs e)
        {
            Progress13 += 0.01;
        }
        // Repeat this pattern for each button/progress bar pair

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}