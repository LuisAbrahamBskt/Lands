﻿namespace Lands.ViewsModels
{
    using GalaSoft.MvvmLight.Command;
    using Models;
    using System;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    public class LandItemViewModel : Land
    {
        #region Command
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        private async void SelectLand()
        {
            MainViewModel.GetInstance().Land = new LandViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new LandPage());
        }
        #endregion
    }
}
