using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    [Serializable]
    class Model
    {
        public string Label { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Label + ": " +
                Phone1 + ", " +
                Phone2 + ", " +
                Phone3 + ", " +
                Phone4 + ", ";
        }
    }
}
