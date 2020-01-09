using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageOrdersApp.BLL.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
