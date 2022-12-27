using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Shared.Rooms.Queries
{
    public class RoomForListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int StatusId { get; set; } = 1;

        public virtual List<ApiUserVm> Users { get; set; } = new List<ApiUserVm>();
    }
}
