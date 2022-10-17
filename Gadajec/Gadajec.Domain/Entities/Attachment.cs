using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Domain.Entities
{
    public class Attachment
    {
        public Guid ID { get; set; }
        public Guid MessageID { get; set; }
        public string Name { get; set; }
        public byte[] AttachmentContent { get; set; }

        public virtual Message Message { get; set; }
    }
}
