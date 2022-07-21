using System.ComponentModel.DataAnnotations;

namespace InspeccionAPI
{
    public class Inspection
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = String.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = String.Empty;
        public int InspectionTypeId { get; set; }
        public InspectionType? InspectionType { get; set; }


    }
}
