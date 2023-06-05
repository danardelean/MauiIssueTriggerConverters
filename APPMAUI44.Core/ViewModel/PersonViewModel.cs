using System;
using System.ComponentModel;
using System.Drawing;
using APPMAUI44.Core.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace APPMAUI44.Core.ViewModel
{
	public partial class PersonViewModel:ObservableObject
	{
		Person _person;
		public PersonViewModel(Person person)
		{
			_person = person;
			FirstName = _person?.FirstName;
			LastName = _person?.LastName;
			IsTrainer = _person?.IsTrainer??false;
		}

		public int? Id { get => _person?.Id; }


        [ObservableProperty]
		[NotifyPropertyChangedFor(nameof(FullName))]
		string _firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string _lastName;

		//[ObservableProperty]
		bool _isTrainer;
		public bool IsTrainer
		{
			get => _isTrainer;
			set => SetProperty(ref _isTrainer, value);
		}

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
			switch(e.PropertyName)
			{
				case nameof(FirstName):
					_person.FirstName = FirstName;
					break;
                case nameof(LastName):
                    _person.LastName = LastName;
                    break;
                case nameof(IsTrainer):
                    _person.IsTrainer = IsTrainer;
                    break;
            }
        }

		public string FullName { get => $"{FirstName} {LastName}"; }

	
    }
}

