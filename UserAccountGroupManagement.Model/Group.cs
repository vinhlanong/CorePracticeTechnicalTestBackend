using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountGroupManagement.Model
{
    public class Group
    {
        public Group()
        {

        }

        public Group(short id, string name, string desc)
        {
            ID = id;
            Name = name;
            Desc = desc;
        }

        public short ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
