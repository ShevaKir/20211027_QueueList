using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211027_QueueList
{
    class QueueList
    {
        private Entry _firstData = null;
        private Entry _endData = null;

        public void Put(object data)
        {
            if(_firstData == null && _endData == null)
            {
                _firstData = new Entry(_firstData, data);
                _endData = new Entry(_endData, data);
            }
            else
            {
                _endData = new Entry(_endData, data);
                _firstData.Next = _endData.Next;            
            }
          
        }

        public object GetData()
        {
            if (_firstData == null)
            {
                throw new InvalidOperationException();
            }

            object result = _firstData.Data;
            _endData = _endData.Next;

            return result;
        }

        class Entry
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
}
