using System.Windows.Input;
using VivesWindowsProject.Commands;
using VivesWindowsProject.Model;

namespace VivesWindowsProject.ViewModel
{
    class EditBirdViewModel : ViewModelBase
    {
        private IEditListener _listener;
        private ICommand _saveCommand;
        private ICommand _cancelCommand;
        private Bird _bird;
        
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(
                        param => _Save(),
                        param => true
                        );
                }

                return _saveCommand;
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(
                        param => _Cancel(),
                        param => true
                        );
                }

                return _cancelCommand;
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


        // BIRD PUBLICITY

        //public long Id
        //{
        //    get
        //    {
        //        return _bird.Id;
        //    }

        //    set
        //    {
        //        if (value == _bird.Id)
        //        {
        //            return;
        //        }

        //        _bird.Id = value;

        //        base.OnPropertyChanged("Id");
        //    }
        //}


        //public string Name
        //{
        //    get
        //    {
        //        return _bird.Name;
        //    }

        //    set
        //    {
        //        if (value == _bird.Name)
        //        {
        //            return;
        //        }

        //        _bird.Name = value;

        //        base.OnPropertyChanged("Name");
        //    }
        //}

        //public string BirdType
        //{
        //    get
        //    {
        //        return _bird.BirdType;
        //    }

        //    set
        //    {
        //        if (value == _bird.BirdType)
        //        {
        //            return;
        //        }

        //        _bird.BirdType = value;

        //        base.OnPropertyChanged("BirdType");
        //    }
        //}

        //public double Length
        //{
        //    get
        //    {
        //        return _bird.Length;
        //    }

        //    set
        //    {
        //        if (value == _bird.Length)
        //        {
        //            return;
        //        }

        //        _bird.Length = value;

        //        base.OnPropertyChanged("Length");
        //    }
        //}

        //public string Description
        //{
        //    get
        //    {
        //        return _bird.Description;
        //    }

        //    set
        //    {
        //        if (value == _bird.Description)
        //        {
        //            return;
        //        }

        //        _bird.Description = value;

        //        base.OnPropertyChanged("Description");
        //    }
        //}

        //public string BaseColor
        //{
        //    get
        //    {
        //        return _bird.BaseColor;
        //    }

        //    set
        //    {
        //        if (value == _bird.BaseColor)
        //        {
        //            return;
        //        }

        //        _bird.BaseColor = value;

        //        base.OnPropertyChanged("BaseColor");
        //    }
        //}

        //public string ImageUrl
        //{
        //    get
        //    {
        //        return _bird.ImageUrl;
        //    }

        //    set
        //    {
        //        if (value == _bird.ImageUrl)
        //        {
        //            return;
        //        }

        //        _bird.ImageUrl = value;

        //        base.OnPropertyChanged("ImageUrl");
        //    }
        //}

        // Constructors

        public EditBirdViewModel(IEditListener listener, Bird bird)
        {
            _listener = listener;
            _bird = bird;
        }

        // Metods

        private void _Save()
        {
            _listener.Save(_bird);
        }

        private void _Cancel()
        {
            _listener.Cancel();
        }

        //Interfaces

        public interface IEditListener
        {
            void Save(Bird bird);
            void Cancel();
        }
    }
}
