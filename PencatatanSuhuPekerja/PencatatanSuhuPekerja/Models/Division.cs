﻿using PencatatanSuhuPekerjaAPI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PencatatanSuhuPekerjaAPI.Models
{
    [Table("tb_m_division")]
    public class Division :BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public bool? IsDelete { get; set; }

        public string DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        
    }
}
