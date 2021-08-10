using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroDB.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Heroname { get; set; }
        public Comic Comic { get; set; }
    }
}
