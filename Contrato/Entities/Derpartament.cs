using System;
namespace Contrato.Entities
{
    public class Derpartament
    {

        public int Name { get; set; }

        public Derpartament(string deptname)
        {
        }

        public Derpartament(int name)
        {
            Name = name;
        }
    }
}
