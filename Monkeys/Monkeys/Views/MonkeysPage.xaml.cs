using System;
using System.Collections.Generic;
using Monkeys.ViewModels;
using Xamarin.Forms;
using Monkeys.Models;

namespace Monkeys.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage()
        {
			System.Diagnostics.Debug.WriteLine(String.Format("Created MonkeyPage, Memory: {0}", GC.GetTotalMemory(true)));
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey == null)
                return;


        }

		~MonkeysPage()
		{
			System.Diagnostics.Debug.WriteLine(String.Format("Destroyed MonkeyPage, Memory: {0}", GC.GetTotalMemory(true)));
		}
    }
}

