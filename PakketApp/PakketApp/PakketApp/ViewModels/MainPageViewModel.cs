using GalaSoft.MvvmLight;
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
    }
}
