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
    public class CharacterViewModel : INotifyPropertyChanged
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        private string _role;
        public string Role
        {
            get { return _role; }
            set
            {
                _role = value;
                OnPropertyChanged();
            }
        }
        private string _house;

        public string House
        {
            get { return _house; }
            set
            {
                _house = value;
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

        private bool _ministeryOfMagic;

        public bool MinisteryOfMagic
        {
            get { return _ministeryOfMagic; }
            set
            {
                _ministeryOfMagic = value;
                OnPropertyChanged();
            }
        }

        private bool _orderOfThePhoenix;

        public bool OrderOfThePhoenix
        {
            get { return _orderOfThePhoenix; }
            set
            {
                _orderOfThePhoenix = value;
                OnPropertyChanged();
            }
        }

        private bool _dumbledoresArmy;

        public bool DumbledoresArmy
        {
            get { return _dumbledoresArmy; }
            set
            {
                _dumbledoresArmy = value;
                OnPropertyChanged();
            }
        }
        private string _wand;

        public string Wand
        {
            get { return _wand; }
            set
            {
                _wand = value;
                OnPropertyChanged();
            }
        }


        private bool _deathEater;

        public bool DeathEater
        {
            get { return _deathEater; }
            set
            {
                _deathEater = value;
                OnPropertyChanged();
            }
        }

        private string _bloodStatus;

        public string BloodStatus
        {
            get { return _bloodStatus; }
            set
            {
                _bloodStatus = value;
                OnPropertyChanged();
            }
        }

        private string _species;

        public string Species
        {
            get { return _species; }
            set
            {
                _species = value;
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

        private string _alias;
        public string Alias
        {
            get { return _alias; }
            set
            {
                _alias = value;
                OnPropertyChanged();
            }

        }
        private string _patronus;

        public string Patronus
        {
            get { return _patronus; }
            set
            {
                _patronus = value;
                OnPropertyChanged();
            }
        }
        private string _boggart;

        public string Boggart
        {
            get { return _boggart; }
            set
            {
                _boggart = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set
            {
                _characters = value;
                OnPropertyChanged();
            }
        }
        public CharacterViewModel()
        {
            Characters = new ObservableCollection<Character>();
            LlamarApi();

        }

        public CharacterViewModel(Character character)
        {
            Alias = character.alias;
            BloodStatus = character.bloodStatus;
            Name = character.name;
            Role = character.role;
            School = character.school;
            DeathEater = character.deathEater;
            DumbledoresArmy = character.dumbledoresArmy;
            House = character.house;
            MinisteryOfMagic = character.ministryOfMagic;
            OrderOfThePhoenix = character.orderOfThePhoenix;
            Species = character.species;
            Boggart = character.boggart;
            Patronus = character.patronus;
            Wand = character.wand;
        }

        public async void LlamarApi()
        {
            ApiResponse response = await ApiCaller.GetCharacter();
            if (response.Successful)
            {
                try
                {
                    string strjson = "{\"Lista\":" + response.Response + "}";
                    var lst = JsonConvert.DeserializeObject<CharacterRoot>(strjson);
                    //lst.Lista.ForEach(x => Characters.Add(x));
                    Characters = new ObservableCollection<Character>(lst.Lista);
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
