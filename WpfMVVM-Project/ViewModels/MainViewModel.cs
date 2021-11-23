using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVM_Project.Commands;
using WpfMVVM_Project.Models;

namespace WpfMVVM_Project.ViewModels
{
    class MainViewModel
    {
        public TextModels textmodel { set; get; }

        public HomeViewModel SelectecViewModel { set; get; }

        public ICommand UpdateViewCommand { set; get; }

        public MainViewModel()
        {
            textmodel = new TextModels();
            textmodel.Marca = "Nike";
            textmodel.Referencia = "1234";

            UpdateViewCommand = new UpdateViewCommand();
            SelectecViewModel = new HomeViewModel();
        }
    }
}
