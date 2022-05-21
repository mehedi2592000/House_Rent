using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buseness_Entity_Layer
{
    public class TanantModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Father_name { get; set; }
        public string Mother_name { get; set; }
        public string Company_name { get; set; }
        public Nullable<int> Nid_number { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Starting_month { get; set; }
        public string Nid_pic { get; set; }
        public string Picture { get; set; }
        public int Care_id { get; set; }
        public int Owner_id { get; set; }

    }
}
