using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPoubellesToilttesPubliques2.DAL.Entities
{
    public class MakeshiftShelter
    {
        public int MakeshiftSchelter_Id { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
    }
}
