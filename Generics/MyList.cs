using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyList<T>
    {
        T[] items;
        // constructor -- new dediğin anda ilk burası çalışır. items ilk burada oluşturuldu yani bellekte aslında yer verilmiş oldu ve size ı 0 yapıldı
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {

        }
    }
}
