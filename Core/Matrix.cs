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
        public void PrintContent()
        {
            Console.Write(Environment.NewLine + "[");
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{");
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(string.Format("{0}, ", data[i, j]));
                }
                Console.Write("}");
                if (i != Size - 1) Console.Write(Environment.NewLine);
            }
            Console.Write("]" + Environment.NewLine);
        }
        public static Matrix GetRandomMatrix(int size, ChangeCellEventHandler changeCellEventHandler = null)
        {
            var randomizer = new Random((int)DateTime.Now.Ticks);
            var res = new Matrix(size);
            int randVal;
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    do
                    {
                        randVal = randomizer.Next(Int32.MinValue, Int32.MaxValue) % 1000;
                    } while (randVal == 0);
                     res[i, j] = randVal;
                     changeCellEventHandler?.Invoke(i, j, randVal); 
                }
            }
            return res;
        }
        public static Matrix FromArray(double[,] array)
        {
            var size = array.GetLength(0);
            var res = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res[j, i] = array[i,j];
                }
            }
            return res;
        }
        public double[,] ToArray()
        {
            return data;
        }

        public Matrix Transpose()
        {
            var size = Size;
            var trans = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    trans[i, j] = this[j, i];
                }
            }
            return trans;
        }
        public static Matrix operator* (Matrix a, Matrix b)
        {
            var size = a.Size;
            var c = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }
        public delegate void ChangeCellEventHandler(int row, int column, double value);
        public event ChangeCellEventHandler CellChanged;
    }
}
