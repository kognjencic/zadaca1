using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zad2
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        private IGenericList<T> _collection;
        private int brItracije = 0;

        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
        }
        public bool MoveNext()
        {
            // Zove se prije svake iteracije.
            // Vratite true ako treba ući u iteraciju, false ako ne
            // Hint: čuvajte neko globalno stanje po kojem pratite gdje se
            // nalazimo u kolekciji
            if (brItracije < _collection.Count)
            {
                return true;
            }
            else
                return false;
            
        }
        public T Current
        {
            get
            {
                if (MoveNext())
                {
                    brItracije++;
                    return _collection.GetElement(brItracije - 1);
                }
                    
                else
                    return default(T);
                // Zove se na svakom ulasku u iteraciju
                // Hint: Koristite stanje postavljeno u MoveNext() dijelu
                // kako bi odredili što se zapravo vraća u ovom koraku
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public void Dispose()
        {
            // Ignorirajte
        }
        public void Reset()
        {
            // Ignorirajte
        }
    }
}
