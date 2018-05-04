using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     BTree- Each node has 2 child
     - all left decendents <=n <all right decencents
         */

   public class TreeExample
    {

    }

    public class TreeNode
    {
        public string Name { get; set; }
        public TreeNode[] Children { get; set; }
    }
}
