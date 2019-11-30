using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Vector : IEnumerable
    {
        double[] data;
        public int Size { get; set; }
        public Vector(int size)
        {
            Size = size;
            data = new double[size];
        }
        public double this[int index]
        {
            get
            {
                if(index<0 || index>Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return data[index];
            }
            set
            {
                if (index < 0 || index > Size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                data[index] = value;
            }
        }

        public static Vector operator*(Matrix a, Vector b)
        {
            if (a.Size != b.Size)
                throw new ArgumentException("Matrix and vector must be the same size");
            int dimension = b.Size;
            Vector c = new Vector(dimension);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    c[i] = c[i] + a[i, j] * b[j];
                }
            }

            return c;
        }

        public static bool operator==(Vector vec1, Vector vec2)
        {
            if (vec1.Size != vec2.Size)
                return false;
            for(int i = 0; i < vec1.Size; i++)
            {
                if (double.IsNaN(vec1[i]) || double.IsNaN(vec2[i]))
                    return false;
                if (Math.Abs(vec1[i] - vec2[i]) > Settings.Eps)
                    return false;
            }
            return true;
        }
        public static bool operator!=(Vector vec1, Vector vec2)
        {
            return !(vec1 == vec2);
        }

        public static Vector FromArray(double [,] array)
        {
            int size = array.GetLength(1);
            var res = new Vector(size);
            for(int i = 0; i < size; i++)
            {
                res[i] = array[0, i];
            }
            return res;
        }
        public double[,] ToArray()
        {
            var array = new double[1, Size];
            for(int i = 0; i < Size; i++)
            {
                array[0, i] = data[i];
            }
            return array;
        }
        public IEnumerator GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
