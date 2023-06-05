using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using APPMAUI44.Core.Model;
using System.Collections.ObjectModel;
using APPMAUI44.Core.Interface;

namespace APPMAUI44.Core.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Persons = new ObservableCollection<PersonViewModel>();
        Persons.Add(new PersonViewModel(new Person { Id = 1, FirstName = "Dan", LastName = "Ardelean",IsTrainer=true }));
        Persons.Add(new PersonViewModel(new Person { Id = 2, FirstName = "Sveto", LastName = "Compri" }));
        Persons.Add(new PersonViewModel(new Person { Id = 3, FirstName = "Matteo", LastName = "Devigili" }));
        Persons.Add(new PersonViewModel(new Person { Id = 4, FirstName = "Massimo", LastName = "Donini" }));

    }
    [RelayCommand]
    public void ChangeValue()
    {
        Persons[0].FirstName = "Danny";
        Persons[3].IsTrainer = true;

    }



    [ObservableProperty]
    ObservableCollection<PersonViewModel> _persons;

}

