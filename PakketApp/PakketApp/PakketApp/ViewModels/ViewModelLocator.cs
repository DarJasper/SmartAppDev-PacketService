using GalaSoft.MvvmLight.Ioc;
using PakketApp.Repositories;
using PakketApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PakketApp.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ICourierRepository, CourierRepository>();
            SimpleIoc.Default.Register<ICountryRepository, CountryRepository>();
            SimpleIoc.Default.Register<IPacketService, PacketService>();

            SimpleIoc.Default.Register<MainPageViewModel>();
        }

        public MainPageViewModel MainPageViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainPageViewModel>();
            }
        }

    }
}
