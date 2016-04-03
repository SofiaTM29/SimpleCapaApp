using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleCAPA.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CAPAId { get; set; }

        [ForeignKey("CAPAId")]
        public virtual CAPA Owner { get; set; }

        public string FC { get; set; }

        public string Descripcion { get; set; }

        public Status StatusTask { get; set; }

        public enum Status
        {
            Started,

            Progress,

            Finished
      }
    }
}