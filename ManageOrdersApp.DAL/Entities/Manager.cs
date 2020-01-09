using ManageOrdersApp.Core.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.DAL.Entities
{
    public partial class Manager:Entity
    {
        public int LastName { get; set; }
        public int RecordId { get; set; }
        public virtual ICollection<Report> Records { get; set; }
        public Manager()
        {
            Records = new HashSet<Report>();
        }
    }
}
