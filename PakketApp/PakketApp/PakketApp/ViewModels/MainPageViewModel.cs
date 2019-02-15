using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PakketApp.Models;
using PakketApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PakketApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IPacketService packetService;

        public MainPageViewModel(IPacketService packetService)
        {
            this.packetService = packetService;
        }

        public List<Country> Countries
        {
            get
            {
                return this.packetService.GetCountries();
            }
        }

        public List<Courier> Couriers
        {
            get
            {
                return this.packetService.GetCouriers();
            }
        }

        private decimal selectedWeight;
        public decimal SelectedWeight
        {
            get
            {
                return selectedWeight;
            }
            set
            {
                selectedWeight = value;
                RaisePropertyChanged(() => SelectedWeight);
            }
        }

        private Courier selectedCourier;
        public Courier SelectedCourier
        {
            get
            {
                return selectedCourier;
            }
            set
            {
                selectedCourier = value;
                RaisePropertyChanged(() => SelectedCourier);
            }
        }

        private Country selectedCountry;
        public Country SelectedCountry
        {
            get
            {
                return selectedCountry;
            }
            set
            {
                selectedCountry = value;
                RaisePropertyChanged(() => SelectedCountry);
            }
        }

        public RelayCommand CalculateCommand
        {
            get
            {
                return new RelayCommand(Calculate);
            }
        }

        private decimal calculatedPrice;
        public decimal CalculatedPrice
        {
            get
            {
                return calculatedPrice;
            }
            set
            {
                calculatedPrice = value;
                RaisePropertyChanged(() => CalculatedPrice);
            }
        }

        private string errorText;
        public string ErrorText
        {
            get
            {
                return errorText;
            }
            set
            {
                errorText = value;
                RaisePropertyChanged(() => ErrorText);
            }
        }

        private void Calculate()
        {
            if (SelectedWeight <= 0 || SelectedCountry == null || SelectedCourier == null)
            {
                //Throw error
                ErrorText = "Gelieve alle velden in te vullen";
                return;
            }
            CalculatedPrice = packetService.CalculatePrice(SelectedWeight, SelectedCountry, SelectedCourier);
            ErrorText = string.Empty;
        }
    }
}
