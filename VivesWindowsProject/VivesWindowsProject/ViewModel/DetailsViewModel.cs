using System;
using System.Windows.Input;
using VivesWindowsProject.Commands;
using VivesWindowsProject.Data;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.ViewModel
{
    class DetailsViewModel : ViewModelBase
    {
        private IDetailsListener _listener;
        private readonly Bird _bird;
        private ICommand _editCommand;
        private ICommand _deleteCommand;

        public ICommand EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new RelayCommand(
                        param => _Edit(),
                        null
                        );
                }

                return _editCommand;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand(
                        p => _listener.Delete(),
                        null
                    );
                }

                return _deleteCommand;
            }
        }

        public Bird Bird
        {
            get { return _bird; }
        }

        // Constructors

        public DetailsViewModel(IDetailsListener listener, Bird bird)
        {
            if (bird != null)
            {
                _bird = bird;
            }

            _listener = listener;
        }


        // Methods

        private void _Edit()
        {
            _listener.Edit();
        }

        // Interfaces 

        public interface IDetailsListener
        {
            void Edit();
            void Delete();
        }
    }
}
