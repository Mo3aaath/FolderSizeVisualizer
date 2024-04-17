using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSizeVisualizer.ClassesF
{
    internal class Leaf : Component
    {
        private String extension;
        private float size;

        public Leaf(String name, String extension, float size)
        {
            this.name = name;
            this.extension = extension;
            this.size = size;
        }

        public override Component[] GetChildren()
        {
            throw new NotImplementedException(); 
        }
    }
}
