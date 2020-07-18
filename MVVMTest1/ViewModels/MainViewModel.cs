using MVVMTest1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTest1.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel selectedViewModel = new HomeViewModel();

        public BaseViewModel SelectedViewModel { 
            get => selectedViewModel; 
            set
            { 
                selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            } 
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
