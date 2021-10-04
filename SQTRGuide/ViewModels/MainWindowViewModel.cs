using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using SQTRGuide.Models;

namespace SQTRGuide.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public double ButtonOpacity => 0.5;

        private double stationPaneOpacity = 0;
        public double StationPaneOpacity
        {
            get => stationPaneOpacity;
            set => this.RaiseAndSetIfChanged(ref stationPaneOpacity, value);
        }

        public bool IsStationPaneVisible
        {
            get => stationPaneOpacity == 1 ? true : false;
            set => StationPaneOpacity = value ? 1 : 0;
        }

        private string stationName = "who knows!";
        public string StationName { get => stationName; set => this.RaiseAndSetIfChanged(ref stationName, value); }

        private Station station;
        public Station Station
        {
            get => station;
            set => this.RaiseAndSetIfChanged(ref station, value);
        }

        public void OpenStationPaneCommand(string shortCode)
        {
            Station = Station.GetStationFromShortCode(shortCode);
            IsStationPaneVisible = true;
        }
    }
}
