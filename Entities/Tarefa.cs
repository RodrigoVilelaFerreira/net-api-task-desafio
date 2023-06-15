using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioDotNetAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
    }
}