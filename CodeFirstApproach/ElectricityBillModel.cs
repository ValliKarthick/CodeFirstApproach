using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach
{
    [Table("EBBillDetails", Schema ="EB")]
    public class ElectricityBillModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [MaxLength(50)]
        public string ContactNumber { get; set; }
        [Column(Order =2)]
        public string Location { get; set; }
        [Required]
        public int UnitConsumed { get; set; }
        public double BillAmount { get; set; }
        //public int billcopy { get; set; }
    }
}
