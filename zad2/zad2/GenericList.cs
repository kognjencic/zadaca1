using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage = new X[4];
        private int brElemenata = 0;
        private int curentSize = 4;


        public int Count
        {
            get
            {
                return brElemenata;
            }
        }

        public void Add(X item)
        {
            if (_internalStorage.Length == brElemenata)
            {
                X[] _internalStorage2 = _internalStorage;
                curentSize = curentSize * 2;
                _internalStorage = new X[curentSize];
                Array.Copy(_internalStorage2, _internalStorage, _internalStorage2.Length);
            }
            _internalStorage[brElemenata] = item;
            brElemenata++;
        }

        public bool Remove(X item)
        {
            if (IndexOf(item) >= 0)
            {
                return RemoveAt(IndexOf(item));
            }
            else return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= brElemenata)
            {
                return false;
            }
            else
            {
                for (int i = index; i < brElemenata - 1; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                _internalStorage[brElemenata - 1] = default(X);
                brElemenata--;
                return true;
            }
        }

        public X GetElement(int index)
        {
            if (index <= brElemenata)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i <= brElemenata; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            _internalStorage = new X[4];
            brElemenata = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i <= brElemenata; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
