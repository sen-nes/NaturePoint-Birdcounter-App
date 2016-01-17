using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using VivesWindowsProject.Commands;
using VivesWindowsProject.Data;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.ViewModel
{
    class BirdManagerViewModel : ViewModelBase, DetailsViewModel.IDetailsListener, EditBirdViewModel.IEditListener, AddBirdViewModel.IAddListener
    {
        // Fields
        private IManagerListener _listener;
        private static ViewModelBase _currentWorkspace;
        private Bird _currentBird;
        private ICommand _addCommand;
        private ICommand _saveNewCommand;
        private ICommand _detailsCommand;

        public ObservableCollection<Bird> Birds { get; set; }

        public ViewModelBase CurrentWorkspace
        {
            get { return _currentWorkspace; }
            set
            {
                _currentWorkspace = value;
                OnPropertyChanged("CurrentWorkspace");
            }
        }

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

        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        p => _AddBird(),
                        null
                        );
                }

                return _addCommand;
            }
        }

        public ICommand SaveNewCommand
        {
            get
            {
                if (_saveNewCommand == null)
                {
                    _saveNewCommand = new RelayCommand(
                        p => _AddBird(),
                        null
                        );
                }

                return _saveNewCommand;
            }
        }

        private bool CanShowDetails
        {
            get
            {
                return _currentBird != null;
            }
        }

        public ICommand DetailsCommand
        {
            get
            {
                if (_detailsCommand == null)
                {
                    _detailsCommand = new RelayCommand(
                        p => _ShowDetails(),
                        p => CanShowDetails
                        );
                }

                return _detailsCommand;
            }
        }

        // Constructors
        public BirdManagerViewModel(IManagerListener listener)
        {
            this.PageName = "Manager";
            this.Column = 1;
            _listener = listener;
            CurrentWorkspace = null;
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

        private void _ShowDetails()
        {
            CurrentWorkspace = new DetailsViewModel(this, (Bird)CurrentBird.Clone());
        }

        private void _AddBird()
        {
            CurrentWorkspace = new AddBirdViewModel(this, new Bird());
        }

        public void Edit()
        {
            CurrentWorkspace = new EditBirdViewModel(this, (Bird)CurrentBird.Clone());
        }

        public void Save(Bird bird)
        {
            if (Birds.Contains(bird))
            {
                if (bird.BirdType == "")
                {
                    bird.BirdType = "Unknown";
                }

                if (bird.Length == "")
                {
                    bird.Length = "Unknown";
                }

                if (bird.Description == "")
                {
                    bird.Description = "Add some description.";
                }

                if (bird.BaseColor == "")
                {
                    bird.BaseColor = "Unknown";
                }

                BirdDB.Update(bird);
                Birds[Birds.IndexOf(bird)] = bird;
                _listener.NotifyDataChanged();
                CurrentBird = bird;
                CurrentWorkspace = new DetailsViewModel(this, (Bird)CurrentBird.Clone());
            }
        }

        public void SaveNew(Bird bird)
        {
            if (bird.Name != null)
            {
                if (BirdDB.Add(bird))
                {
                    if (bird.BirdType == null)
                    {
                        bird.BirdType = "Unknown";
                    }

                    if (bird.Length == null)
                    {
                        bird.Length = "Unknown";
                    }

                    if (bird.Description == null)
                    {
                        bird.Description = "Add some description.";
                    }

                    if (bird.BaseColor == null)
                    {
                        bird.BaseColor = "Unknown";
                    }

                    if (bird.ImageUrl == null)
                    {
                        bird.ImageUrl = "http://images.clipartpanda.com/bird-clipart-Twitter-Bird-Clip-Art.png";
                    }

                    BirdDB.Update(bird);
                    Birds.Add(bird);
                    _listener.NotifyDataChanged();
                    CurrentBird = bird;
                    CurrentWorkspace = new DetailsViewModel(this, (Bird)CurrentBird.Clone());
                }
                else
                {
                    MessageBox.Show("You already have this bird in your list!");
                }
            }
            else
            {
                MessageBox.Show("You cannot create a nameless bird!");
            }
        }

        public void Delete()
        {
            BirdDB.Delete(CurrentBird);
            Birds.Remove(CurrentBird);
            var sth = BirdDB.GetBirds();
            _listener.NotifyDataChanged();
            CurrentBird = null;
            CurrentWorkspace = null;
        }
        public static void ResetWorkspace()
        {
            _currentWorkspace = null;
        }

        public void Cancel()
        {
            CurrentWorkspace = new DetailsViewModel(this, (Bird)CurrentBird.Clone());
        }

        public void CancelNew()
        {
            CurrentWorkspace = null;
        }

        // Interfaces
        public interface IManagerListener
        {
            void NotifyDataChanged();
        }
    }
}