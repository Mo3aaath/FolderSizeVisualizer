using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSizeVisualizer.ClassesF
{
    internal abstract class Component
    {
        protected String name;
        public abstract Component[] GetChildren();
    }
}
