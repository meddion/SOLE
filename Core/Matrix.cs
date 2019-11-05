using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Matrix
    {
        double[,] data;
        public int Size { get; set; }
        public Matrix(int size)
        {
            Size = size;
            data = new double[size, size];
        }
        public double this[int row, int column]
        {
            get
            {
                if (row < 0 && row >= Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (column < 0 && column >= Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return data[row, column]; 
            }
            set
            {
                if (row < 0 && row >= Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (column < 0 && column >= Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                data[row, column] = value;
                CellChanged?.Invoke(row, column, value);
            }
        }
        public static Matrix GetRandomMatrix(int size, ChangeCellEventHandler changeCellEventHandler = null)
        {
            var r = new Random();
            var res = new Matrix(size);
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    var value = r.NextDouble() * 1000;
                    res[i, j] = value;
                    changeCellEventHandler?.Invoke(i, j, value);
                }
            }
            return res;
        }
        public delegate void ChangeCellEventHandler(int row, int column, double value);
        public event ChangeCellEventHandler CellChanged;
    }
}
