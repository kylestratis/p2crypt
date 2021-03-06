﻿using System.Windows;

namespace UiTest.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		#region Constructors

		public MainWindow()
		{
			this.InitializeComponent();
			this.Loaded += this.OnLoaded;
		}

		#endregion Constructors

		#region Methods

		private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
		{
			this.NewMessage.Focus();
		}

		#endregion Methods
	}
}