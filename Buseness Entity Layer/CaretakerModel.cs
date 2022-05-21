using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buseness_Entity_Layer
{
    public class CaretakerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Nid { get; set; }
        public int Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Nid_picture { get; set; }
        public int Owner_id { get; set; }

    }
}
