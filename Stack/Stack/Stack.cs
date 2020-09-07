using System;
using System.Collections.Generic;

namespace Stack
{
    class Stack
    {
        private List<object> _stackList = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new NullReferenceException("obj", new Exception("Passed object can't be null!"));
            _stackList.Add(obj);
        }

        public object Pop()
        {
            var objToRemove = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return objToRemove;
        }

        public void Clear()
        {
            _stackList.Clear();
        }
    }
}
