using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGameVerse
{
    internal class ApiResponse<T>
    {
        public string status { get; set; }
        public T[] data { get; set; }
    }
}
