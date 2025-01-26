using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class FileSystemElement
    {
        protected FileSystemElement(string name)
        {
   
            Name = name; 
        }
        public string Name { get; }

        public abstract int GetCount();
    }

    public class DirectoryElement : FileSystemElement
    {
        private List<FileSystemElement> _elements  = new();
        public IEnumerable<FileSystemElement> Elements => _elements;
        public DirectoryElement(string name) 
            : base(name)
        {
        }


        public void AddElement(FileSystemElement element)
        {
            _elements.Add(element);
        }

        public void RemoveElement(string name)
        {
            _elements.RemoveAll(e => e.Name.Equals(name));
        }
        public override int GetCount() => Elements.Sum(x=>x.GetCount());

    }

    public class FileElement : FileSystemElement
    {
        public FileElement(string name) 
            : base(name)
        {
        }

        public override int GetCount()
        {
            return 1;
        }
    }
}
