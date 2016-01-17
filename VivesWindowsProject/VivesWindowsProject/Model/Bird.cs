using System;
using System.ComponentModel;
using System.Windows.Input;
using VivesWindowsProject.Commands;

namespace VivesWindowsProject.Model
{
    public class Bird : INotifyPropertyChanged, ICloneable
    {
        // Properties
        private string _name;
        private string _birdType;
        private string _length;
        private string _description;
        private string _baseColor;
        private string _imageUrl;
        private int _count;
        
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
        
        public string BirdType
        {
            get { return _birdType; }
            set
            {
                _birdType = value;
                RaisePropertyChanged("Name");
            }
        }
        
        public string Length
        {
            get { return _length; }
            set
            {
                _length = value;
                RaisePropertyChanged("Length");
            }
        }
        
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged("Description");
            }
        }
        
        public string BaseColor
        {
            get { return _baseColor; }
            set
            {
                _baseColor = value;
                RaisePropertyChanged("BaseColor");
            }
        }
        
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                RaisePropertyChanged("ImageUrl");
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                RaisePropertyChanged("Count");
            }
        }

        // Constructors

        public Bird() { }

        public Bird(string Name, string BirdType, string Length, string Description, string BaseColor, string ImageUrl, int Count)
        {
            this._name = Name;
            this._birdType = BirdType;
            this._length = Length;
            this._description = Description;
            this._baseColor = BaseColor;
            this._imageUrl = ImageUrl;
            this._count = Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Bird && (((Bird)obj).Name.ToUpper().Equals(Name.ToUpper()));
        }

        public static bool operator ==(Bird a, Bird b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a.Name.ToUpper() == b.Name.ToUpper();
        }

        public static bool operator !=(Bird a, Bird b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public object Clone()
        {
            return new Bird(Name, BirdType, Length, Description, BaseColor, ImageUrl, Count);
        }



        private ICommand _increaseCommand;
        public ICommand IncreaseCommand
        {
            get
            {
                if (_increaseCommand == null)
                {
                    _increaseCommand = new RelayCommand(
                        p => _Increase(),
                        null
                        );
                }

                return _increaseCommand;
            }
        }

        private void _Increase()
        {
            Count++;
        }

        private ICommand _decreaseCommand;

        public ICommand DecreaseCommand
        {
            get
            {
                if (_decreaseCommand == null)
                {
                    _decreaseCommand = new RelayCommand(
                        p => _Decrease(),
                        p => (Count > 0)
                        );
                }

                return _decreaseCommand;
            }
        }

        private void _Decrease()
        {
            Count--;
        }
    }
}
