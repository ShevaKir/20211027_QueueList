using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211027_QueueList
{
    class QueueListEnumerator : IEnumerator
    {
        Entry _firstData = null;
        Entry _currentData = null;
        

        public QueueListEnumerator(object firstData)
        {
            _firstData = (Entry)firstData;
        }

        public object Current
        {
            get
            {
                //if (position == -1 || position >= _points.Length)
                //    throw new InvalidOperationException();

                return _currentData;
            }
        }

        public bool MoveNext()
        {
            bool result = true;

            if(_currentData == null)
            {
                _currentData = _firstData;
            }
            else
            {
                if (_currentData.Next == null)
                {
                    result = false;
                }
                _currentData = _currentData.Next;
            }

            

            
            return result;
        }

        public void Reset()
        {
            
        }

    }
}
