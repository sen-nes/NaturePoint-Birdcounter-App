using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VivesWindowsProject.Commands;
using VivesWindowsProject.Data;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.ViewModel
{
    class BirdCounterViewModel : ViewModelBase, BirdManagerViewModel.IManagerListener
    {
        // Properties
        private Bird _currentBird;

        public ObservableCollection<Bird> Birds { get; set; }

        public Bird CurrentBird
        {
            get { return _currentBird; }
            set
            {
                _currentBird = value;
                OnPropertyChanged("CurrentBird");
                OnPropertyChanged("CanDelete");
            }
        }

        // Constructors
        public BirdCounterViewModel()
        {
            this.PageName = "Counter";
            this.Column = 2;

            Birds = new ObservableCollection<Bird>();
            _PopulateBirds(BirdDB.GetBirds());
        }

        // Methods
        private void _PopulateBirds(List<Bird> birds)
        {
            Birds.Clear();
            foreach (var bird in birds)
            {
                Birds.Add(bird);
            }
        }

        public void NotifyDataChanged()
        {
            _PopulateBirds(BirdDB.GetBirds());
        }
    }
}
