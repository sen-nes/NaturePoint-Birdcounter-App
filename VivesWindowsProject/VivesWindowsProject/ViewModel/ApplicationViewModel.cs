using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using VivesWindowsProject.Commands;

namespace VivesWindowsProject.ViewModel
{
    class ApplicationViewModel : ViewModelBase
    {
        private ICommand _changePageCommand;
        private ViewModelBase _currentPage;
        private List<ViewModelBase> _pages;

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangePage((ViewModelBase)p),
                        p => p is ViewModelBase);
                }

                return _changePageCommand;
            }
        }

        public ViewModelBase CurrentPage
        {
            get
            {
                return _currentPage;
            }

            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    OnPropertyChanged("CurrentPage");
                }
            }
        }

        public List<ViewModelBase> Pages
        {
            get
            {
                if (_pages == null)
                    _pages = new List<ViewModelBase>();

                return _pages;
            }
        }

        public ApplicationViewModel()
        {
            var counter = new BirdCounterViewModel();
            Pages.Add(new IntroductionViewModel());
            Pages.Add(new BirdManagerViewModel(counter));
            Pages.Add(counter);

            CurrentPage = Pages[0];
        }

        private void ChangePage(ViewModelBase page)
        {
            if (!Pages.Contains(page))
            {
                Pages.Add(page);
            }

            if (page is BirdManagerViewModel)
            {
                BirdManagerViewModel.ResetWorkspace();
            }

            CurrentPage = Pages
                .FirstOrDefault(vm => vm == page);
        }        
    }
}
