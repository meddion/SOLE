using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Core;

namespace WpfUI.ViewModels
{
    public class SettingsWindowViewModel : ViewModelBase
    {
        public SettingsWindowViewModel(Window window)
        {
            Eps = Settings.Eps.ToString();
            Omega = Settings.Omega.ToString();
            MaxCountIter = Settings.Max.ToString();
            Save = new RelayCommand(x =>
            {
                double epsD;
                double omegaD;
                int maxI;
                if(!double.TryParse(Eps, out epsD))
                {
                    MessageBox.Show("Введіть коректну точність!");
                    return; 
                }
                if (!double.TryParse(Omega, out omegaD))
                {
                    MessageBox.Show("Введіть коректно параметр Омега!");
                    return;
                }
                if (!int.TryParse(MaxCountIter, out maxI))
                {
                    MessageBox.Show("Введіть коректно максимальну кількість ітерацій!");
                    return;
                }
                Settings.Eps = epsD;
                Settings.Max = maxI;
                Settings.Omega = omegaD;
                Settings.Save();
                window.Close();
            });
            Cancel = new RelayCommand(x =>
            {
                window.Close();
            });
        }
        RelayCommand save;
        public RelayCommand Save
        {
            get
            {
                return save;
            }
            set
            {
                save = value;
                OnPropertyChanged(nameof(Save));
            }
        }
        RelayCommand cancel;
        public RelayCommand Cancel
        {
            get
            {
                return cancel;
            }
            set
            {
                cancel = value;
                OnPropertyChanged(nameof(Cancel));
            }
        }
        string eps;
        public string Eps
        {
            get
            {
                return eps;
            }
            set
            {
                eps = value;
                OnPropertyChanged(nameof(Eps));
            }
        }
        string omega;
        public string Omega
        {
            get
            {
                return omega;
            }
            set
            {
                omega = value;
                OnPropertyChanged(nameof(Omega));
            }
        }
        string maxCountIter;
        public string MaxCountIter
        {
            get
            {
                return maxCountIter;
            }
            set
            {
                maxCountIter = value;
                OnPropertyChanged(nameof(MaxCountIter));
            }
        }
    }
}
