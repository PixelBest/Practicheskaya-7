using Practicheskaya_7.DataBase;
using Practicheskaya_7.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practicheskaya_7.Model
{
    internal class AnimalsViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<AnimalsTable> OCAnimals;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropetryChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private AnimalsTable _animalsTable;

        public AnimalsTable AnimalsTable
        {
            get { return _animalsTable; }
            set
            {
                _animalsTable = value;
                OnPropetryChanged(nameof(AnimalsTable));
            }
        }

        private ObservableCollection<AnimalsTable> _listAnimalsTable;

        public ObservableCollection<AnimalsTable> ListAnimalsTable
        {
            get { return _listAnimalsTable; }
            set
            {
                _listAnimalsTable = value;
                OnPropetryChanged(nameof(ListAnimalsTable));
            }
        }
        private AnimalsTable selectedAnimal;

        public AnimalsTable SelectedAnimal
        {
            get { return selectedAnimal; }
            set 
            { 
                selectedAnimal = value;
                OnPropetryChanged(nameof(SelectedAnimal));
            }
        }

        private AnimalsTable addAnimalTable = new AnimalsTable();

        public AnimalsTable AddAnimalTable
        {
            get { return addAnimalTable; }
            set 
            {
                addAnimalTable = value;
                OnPropetryChanged(nameof(AddAnimalTable));
            }
        }

        AnimalsEntities3 animalsEntities3;
        public AnimalsViewModel()
        {
            animalsEntities3 = new AnimalsEntities3();
            LoadAnimals();
            DeleteCommand = new Command((s) => true, Delete);
            UpdateCommand = new Command((s) => true, Update);
            UpdateAnimalsCommand = new Command((s) => true, UpdateAnimal);
            AddAnimalsCommand = new Command((s) => true, AddAnimal);
        }

        private void AddAnimal(object obj)
        {
            AddAnimalTable.Id = Convert.ToString(animalsEntities3.AnimalsTable.Count() + 1);
            ListAnimalsTable.Add(AddAnimalTable);
            OCAnimals.Add(AddAnimalTable);
            animalsEntities3.AnimalsTable.Add(AddAnimalTable);
            animalsEntities3.SaveChanges();
            AddAnimalTable = new AnimalsTable();
        }

        private void UpdateAnimal(object obj)
        {
            animalsEntities3.SaveChanges();
            SelectedAnimal = new AnimalsTable();
        }

        private void Update(object obj)
        {
            SelectedAnimal = obj as AnimalsTable;
        }

        private void Delete(object obj)
        {
            var anim = obj as AnimalsTable;
            animalsEntities3.AnimalsTable.Remove(anim);
            animalsEntities3.SaveChanges();
            ListAnimalsTable.Remove(anim);
            OCAnimals.Remove(anim);
        }

        private void LoadAnimals()
        {
            ListAnimalsTable = new ObservableCollection<AnimalsTable>(animalsEntities3.AnimalsTable);
            OCAnimals = new ObservableCollection<AnimalsTable>(animalsEntities3.AnimalsTable);
        }

        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateAnimalsCommand { get; set; }
        public ICommand AddAnimalsCommand { get; set; }

    }

    class Command : ICommand
    {
        public Command(Func<object, bool> methodCanExecute, Action<object> methodExecute)
        {
            MethodCanExecute = methodCanExecute;
            MethodExecute = methodExecute;
        }
        Action<object> MethodExecute;
        Func<object, bool> MethodCanExecute;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return MethodExecute != null && MethodCanExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            MethodExecute(parameter);
        }
    }
}
