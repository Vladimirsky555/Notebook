using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    [Serializable]
    class Model
    {
        public string Label { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }
}
