namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Водитель
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Middlename { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PassportSerial { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PassportNumber { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Postcode { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string AddressLife { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Jobname { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
