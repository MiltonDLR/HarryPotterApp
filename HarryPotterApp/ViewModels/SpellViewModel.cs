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
    public class SpellViewModel : INotifyPropertyChanged
    {

		private string _spell;

		public string Spell
		{
			get { return _spell; }
			set { _spell = value; }
		}
		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}
		private string _effect;

		public string Effect
		{
			get { return _effect; }
			set { _effect = value; }
		}

		private ObservableCollection<Spell> _spells = new ObservableCollection<Spell>();
		public ObservableCollection<Spell> Spells
		{
			get { return _spells; }
			set
			{
				_spells = value;
				OnPropertyChanged();
			}
		}
		public SpellViewModel(Spell spell)
		{
			Spell = spell.spell;
			Type = spell.type;
			Effect = spell.effect;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			var changed = PropertyChanged;
			if (changed == null)
				return;
			changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public SpellViewModel()
		{
			Spells = new ObservableCollection<Spell>();
			LlamarApi();

		}

		public async void LlamarApi()
		{
			ApiResponse response = await ApiCaller.GetSpell();			
			if (response.Successful)
			{
				try
				{
					string strjson = "{\"Lista\":" + response.Response + "}";
					var lst = JsonConvert.DeserializeObject<SpellRoot>(strjson);
					//lst.Lista.ForEach(x => Characters.Add(x));
					Spells = new ObservableCollection<Spell>(lst.Lista);
				}
				catch (Exception ex)
				{

				}
			}
		}

	}
}
