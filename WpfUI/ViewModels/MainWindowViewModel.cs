using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace WpfUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            run = new RelayCommand(x => {
                A = new double[2,2];
            });
        }
        int size;
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
                A = new double[value, value];
                B = new double[1, value];
                OnPropertyChanged(nameof(Size));
            }
        }
        double[,] a = new double[2,2];
        public double[,] A { 
            get { 
                return a; 
            }
            
            set {
                a = value;
                OnPropertyChanged(nameof(A));
            } 
        }
        double[,] b = new double[1, 2];
        public double[,]  B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                OnPropertyChanged(nameof(B));
            }
        }
        RelayCommand run;
        public RelayCommand Run { 
            get {
                return run;
            }
            set {
                run = value;
                OnPropertyChanged(nameof(Run));
            } 
        }
    }
}