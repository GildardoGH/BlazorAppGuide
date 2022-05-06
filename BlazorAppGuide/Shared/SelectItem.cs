using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppGuide.Shared
{
    public class SelectItem<T>
    {
        public T Value { get; set; }
        public string Text { get; set; }
        public bool IsSelected { get; set; }
    }

}
