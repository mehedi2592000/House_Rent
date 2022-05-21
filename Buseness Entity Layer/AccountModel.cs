using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buseness_Entity_Layer
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public Nullable<int> Total_cost { get; set; }
        public Nullable<int> Prevous_amount { get; set; }
        public Nullable<int> Total_amount { get; set; }
        public int Cost_id { get; set; }

    }
}
