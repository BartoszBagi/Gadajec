using Gadajec.Application.Common.Models;
using Gadajec.Shared.Rooms.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Shared.Rooms.Commands
{
    public class AddRoomVm
    {
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public string Description { get; set; }
        public virtual List<ApiUserVm> Users { get; set; } = new List<ApiUserVm>();
    }
}
