using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    public class myCls
    {
        private static string _guess;

        public string guess
        {
            get { return _guess; }
            set { _guess = value; }
        }
    }
}
