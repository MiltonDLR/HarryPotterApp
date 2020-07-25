using HarryPotterApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HarryPotterApp.ViewModels
{
    public class HouseViewModel : INotifyPropertyChanged
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _mascot;

        public string Mascot
        {
            get { return _mascot; }
            set
            {
                _mascot = value;
                OnPropertyChanged();
            }
        }

        private string _headOfHouse;

        public string HeadOfHouse
        {
            get { return _headOfHouse; }
            set
            {
                _headOfHouse = value;
                OnPropertyChanged();
            }
        }

        private string _houseGhost;

        public string HouseGhost
        {
            get { return _houseGhost; }
            set
            {
                _houseGhost = value;
                OnPropertyChanged();
            }
        }

        private string _founder;

        public string Founder
        {
            get { return _founder; }
            set
            {
                _founder = value;
                OnPropertyChanged();
            }
        }

        private int _v;

        public int V
        {
            get { return _v; }
            set
            {
                _v = value;
                OnPropertyChanged();
            }
        }

        private string _school;

        public string School
        {
            get { return _school; }
            set
            {
                _school = value;
                OnPropertyChanged();
            }
        }

        private IList<string> _members;

        public IList<string> Members
        {
            get { return _members; }
            set
            {
                _members = value;
                OnPropertyChanged();
            }
        }

        private IList<string> _values;

        public IList<string> Values
        {
            get { return _values; }
            set
            {
                _values = value;
                OnPropertyChanged();
            }
        }

        private IList<string> _colors;

        public IList<string> Colors
        {
            get { return _colors; }
            set
            {
                _colors = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<House> _houses = new ObservableCollection<House>();
        public ObservableCollection<House> Houses
        {
            get { return _houses; }
            set
            {
                _houses = value;
                OnPropertyChanged();
            }
        }
        public HouseViewModel()
        {
            Houses = new ObservableCollection<House>();
            LlamarApi();

        }

        public HouseViewModel(House house)
        {
            Name = house.name;
            Mascot = house.mascot;
            HeadOfHouse = house.headOfHouse;
            HouseGhost = house.houseGhost;
            Founder = house.founder;
            School = house.school;
            Values = house.values;
            Colors = house.colors;
        }

        public async void LlamarApi()
        {
            ApiResponse response = await ApiCaller.GetHouse();
            if (response.Successful)
            {
                try
                {
                    string strjson = "{\"Lista\":" + response.Response + "}";
                    var lst = JsonConvert.DeserializeObject<HouseRoot>(strjson);
                    //lst.Lista.ForEach(x => Characters.Add(x));
                    Houses = new ObservableCollection<House>(lst.Lista);
                }
                catch (Exception ex)
                {

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
