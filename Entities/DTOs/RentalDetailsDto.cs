using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailsDto : IDto
    {
        public int RentalId { get; set; }
        public string CarBrandName { get; set; }
        public string CarColorName { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
