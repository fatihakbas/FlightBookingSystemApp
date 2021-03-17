using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class TicketModel
    {
        public string TicketNumber { get; set; }
        public float Price { get; set; }
        public string ConfirmationNumber { get; set; }
    }
}
