using System.ComponentModel;

namespace VivesWindowsProject.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public string PageName { get; protected set; }
        public int Column { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
