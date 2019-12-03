using Core;
using Core.Methods;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        Logger logger;
        public MainWindowViewModel()
        {
            logger = new Logger();
            logger.Write += Logger_Write;
            run = new RelayCommand(x => {
                IMethod method = null;
                var a = Matrix.FromArray(A);
                var b = Vector.FromArray(B);
                switch(methodIndex)
                {
                    case 0:
                        method = new Cholesky();
                        break;
                    case 1:
                        method = new gauss_seidel();
                        break;
                    case 2:
                        method = new successive_overrelaxation();
                        break;
                    case 3:
                        method = new LUmet();
                        break;
                    default:
                        logger.NewMsg("Такого методу немає");
                        break;
                }
                if (method != null)
                {
                    method.Log = logger;
                    X = method.Run(a, b).ToArray();
                }
            });
            random = new RelayCommand(x =>
            {
                A = Matrix.GetRandomMatrix(Size).ToArray();
                var randB = new double[1, Size];
                var r = new Random();
                for (int i = 0; i < Size; ++i)
                {
                    
                    randB[0, i] = r.Next(-1000, 1000);
                }
                B = randB;
            });
            close = new RelayCommand(x =>
            {
                App.Current.Shutdown();
            });
            clearLog = new RelayCommand(x =>
            {
                Log = "";
            });
        }

        private void Logger_Write(string msg)
        {
            Log += msg + "\n";
        }

        int size = 2;
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
                A = new double[value, value];
                B = new double[1, value];
                X = new double[1, value];
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
        public double[,] B
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
        double[,] x = new double[1, 2];
        public double [,] X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                OnPropertyChanged(nameof(X));
            }
        }
        RelayCommand close;
        public RelayCommand AppClose
        {
            get
            {
                return close;
            }
            set
            {
                close = value;
                OnPropertyChanged(nameof(AppClose));
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
        RelayCommand random;
        public RelayCommand Random
        {
            get
            {
                return random;
            }
            set
            {
                random = value;
                OnPropertyChanged(nameof(Random));
            }
        }
        RelayCommand clearLog;
        public RelayCommand ClearLog
        {
            get
            {
                return clearLog;
            }
            set
            {
                clearLog = value;
                OnPropertyChanged(nameof(ClearLog));
            }
        }
        string log;
        public string Log
        {
            get
            {
                return log;
            }
            set
            {
                log = value;
                OnPropertyChanged(nameof(Log));
            }
        }
        int methodIndex = 0;
        public int MethodIndex
        {
            get
            {
                return methodIndex;
            }
            set
            {
                methodIndex = value;
                OnPropertyChanged(nameof(MethodIndex));
            }
        }
    }
}