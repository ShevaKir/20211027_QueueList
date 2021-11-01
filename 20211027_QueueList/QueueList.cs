using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211027_QueueList
{
    class QueueList : IEnumerable
    {
        private Entry _firstData = null;
        private Entry _endData = null;

        public void Put(object data)
        {
            Entry item = new Entry(null, data);

            if(_firstData == null)
            {
                _firstData = item;
                _endData = item;
            }
            else
            {
                _endData.Next = item;
                _endData = item;
            }
        }

        public object GetData()
        {
            if (_firstData == null)
            {
                throw new InvalidOperationException();
            }

            object result = _firstData.Data;
            _firstData = _firstData.Next;

            return result;
        }


        public IEnumerator GetEnumerator()
        {
            return new QueueListEnumerator(_firstData);
        }
    }

    public class Entry
    {
        private Entry _next;
        private object _data;

        public Entry(Entry next, object data)
        {
            _next = next;
            _data = data;
        }

        public object Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public Entry Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
    }
}
