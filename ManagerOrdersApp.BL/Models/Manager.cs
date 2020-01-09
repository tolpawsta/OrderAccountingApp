using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.BLL.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public int LastName { get; set; }
        public int RecordId { get; set; }
        public virtual ICollection<Report> Records { get; set; }
        public Manager()
        {
            Records = new HashSet<Report>();
        }
    }
}
