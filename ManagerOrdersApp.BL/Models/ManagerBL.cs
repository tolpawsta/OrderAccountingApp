using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.BLL.Models
{
    public class ManagerBL
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public int RecordId { get; set; }
        public virtual ICollection<ReportBL> Records { get; set; }
        public ManagerBL()
        {
            Records = new HashSet<ReportBL>();
        }
    }
}
