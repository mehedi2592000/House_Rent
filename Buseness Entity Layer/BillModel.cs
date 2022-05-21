using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buseness_Entity_Layer
{
    public class BillModel
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public Nullable<int> Home_rent { get; set; }
        public Nullable<int> Water_bill { get; set; }
        public Nullable<int> Dirty_bill { get; set; }
        public Nullable<int> Service_charge { get; set; }
        public Nullable<int> Gass_bill { get; set; }
        public Nullable<int> Other_bill { get; set; }
        public Nullable<int> Previous_bill { get; set; }
        public Nullable<int> Total_bill { get; set; }
        public Nullable<int> Submission { get; set; }
        public Nullable<int> Rest_of_bill { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Tanat_id { get; set; }

    }
}
