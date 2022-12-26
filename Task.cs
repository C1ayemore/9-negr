using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _9_negrow
{
    internal class Task
    {
        public string name;
        public long memory;
        public int id;

        public Task(string Name, int Id, long Memory)
        {
            name = Name;
            memory = Memory;
            id = Id;
        }
    }
}
