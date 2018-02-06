﻿using System.Windows;

namespace AirlinesManagerGame.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Content = new AirplanesStatusView();
        }
    }
}
