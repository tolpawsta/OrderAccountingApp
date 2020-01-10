using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.BLL.Models
{
    public class ReportBL
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public ManagerBL Manager { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
