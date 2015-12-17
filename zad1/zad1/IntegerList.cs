using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zad1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int curentSize;
        private int brElemenata = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];
            curentSize = 4;
            brElemenata = 0;
        }
        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
            curentSize = initialSize;
            brElemenata = 0;
        }

        public int Count
        {
            get
            {
                return brElemenata;
            }
        }

        public void Add(int item)
        {
            if (_internalStorage.Length == brElemenata)
            {
                int[] _internalStorage2 = _internalStorage;
                curentSize = curentSize * 2;
                _internalStorage = new int[curentSize];
                Array.Copy(_internalStorage2, _internalStorage, _internalStorage2.Length);
            }
            _internalStorage[brElemenata] = item;
            brElemenata++;
        }

        public void Clear()
        {
            _internalStorage = new int[4];
            brElemenata = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i <= brElemenata; i++)
            {
                if (_internalStorage[i]==item)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            for (int i = 0; i <= brElemenata; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(int item)
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
                for (int i = index; i < brElemenata-1; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                _internalStorage[brElemenata-1] = 0;
                brElemenata--;
                return true;
            }
        }
    }
}
