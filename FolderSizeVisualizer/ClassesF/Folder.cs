using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSizeVisualizer.ClassesF
{
    internal class Folder : Component
    {
        private Component[] children;

        public Folder(String name) 
        {
            this.name = name;
        }

        public override Component[] GetChildren() 
        {
            return children;
        }

        public void AddChild(Component comp) 
        {
            children.Append(comp);
        }

        public override string ToString()
        {
            return "Name: " + name;
        }
    }
}
