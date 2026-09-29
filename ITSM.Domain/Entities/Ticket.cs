using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSM.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }= string.Empty;
        public string Description { get; set; }= string.Empty;
        public string Priority { get; set; }= string.Empty;
        public string Status { get; set; }= string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; }= null!;
        public DateTime CreatedAt { get; set; }

    }
}
