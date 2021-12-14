using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlistnoClass
{
    public class Nodes
    {
        public object NodeContent;
        public Nodes Next;

        public Nodes(object Content)
        {
            this.NodeContent = Content;
        }
    }
}
