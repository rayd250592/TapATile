﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace TapATile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public int timestart = 0;
        public int timeend = 60;
        public int timetemp = 0;

        public MainPage()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            mainrec.Visibility = System.Windows.Visibility.Collapsed; //hide title rectangle

            //load score textboxes and game rectangles
            t1.Visibility = System.Windows.Visibility.Visible;
            t2.Visibility = System.Windows.Visibility.Visible;
            time.Visibility = System.Windows.Visibility.Visible;
            score.Visibility = System.Windows.Visibility.Visible;
            gamerec.Visibility = System.Windows.Visibility.Visible;


            //create timer objects


            DispatcherTimer gamethread = new DispatcherTimer();
            gamethread.Interval = TimeSpan.FromSeconds(1);
            gamethread.Tick += gamethread_Tick;
            gamethread.Start();
            int timetemp = 0;

        }

        void gamethread_Tick(object sender, EventArgs e)
        {
           
            throw new NotImplementedException();
            timetemp = timetemp + 1;


        }
    }
}