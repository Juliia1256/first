using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CW14
{
    class ErrorList : IDisposable, IEnumerable<string>
    {
        public string Category { get; }
        public List<string> Errors { get; private set; }

        public ErrorList(string category)
        {
            Category = category;
        }

        public void Add(string errorMessage)
        {
            Errors = new List<string> { errorMessage };
        }
        public virtual void Dispose()
        {
            Errors.Clear();

            Errors = new List<string>();
        }

        public IEnumerator<string> GetEnumerator()
        {
            var iitem = Errors.GetEnumerator();
            return iitem;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
