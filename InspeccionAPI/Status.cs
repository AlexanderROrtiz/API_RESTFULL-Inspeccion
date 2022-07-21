using System.ComponentModel.DataAnnotations;

namespace InspeccionAPI
{
    public class Status
    {
        public int id { get; set; }

        [StringLength(20)]
        public string StatusOption { get; set; } = String.Empty;
    }
}
