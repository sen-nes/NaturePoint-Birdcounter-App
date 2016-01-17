using System.Windows.Input;
using VivesWindowsProject.Commands;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.ViewModel
{
    class AddBirdViewModel : ViewModelBase
    {
        private IAddListener _listener;
        private ICommand _saveNewCommand;
        private ICommand _cancelNewCommand;
        private Bird _bird;

        public ICommand SaveNewCommand
        {
            get
            {
                if (_saveNewCommand == null)
                {
                    _saveNewCommand = new RelayCommand(
                        param => _Save(),
                        param => true
                        );
                }

                return _saveNewCommand;
            }
        }

        public ICommand CancelNewCommand
        {
            get
            {
                if (_cancelNewCommand == null)
                {
                    _cancelNewCommand = new RelayCommand(
                        param => _Cancel(),
                        param => true
                        );
                }

                return _cancelNewCommand;
            }
        }

        public Bird Bird
        {
            get { return _bird; }
            set
            {
                _bird = value;
                OnPropertyChanged("CurrentBird");
                OnPropertyChanged("CanDelete");
            }
        }

        // Constructors

        public AddBirdViewModel(IAddListener listener, Bird bird)
        {
            _listener = listener;
            _bird = bird;
        }

        // Metods

        private void _Save()
        {
            _listener.SaveNew(_bird);
        }

        private void _Cancel()
        {
            _listener.CancelNew();
        }

        //Interfaces

        public interface IAddListener
        {
            void SaveNew(Bird bird);
            void CancelNew();
        }
    }
}
