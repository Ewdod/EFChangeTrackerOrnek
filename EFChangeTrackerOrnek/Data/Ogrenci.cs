using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChangeTrackerOrnek.Data
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime BirthDate { get; set; }
    }
}
