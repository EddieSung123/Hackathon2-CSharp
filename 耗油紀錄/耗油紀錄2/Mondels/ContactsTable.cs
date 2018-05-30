namespace 耗油紀錄2.Mondels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        public int Id { get; set; }

        public DateTime RefuelingDate { get; set; }

        public double Liter { get; set; }

        public double Kilometer { get; set; }
    }
}
