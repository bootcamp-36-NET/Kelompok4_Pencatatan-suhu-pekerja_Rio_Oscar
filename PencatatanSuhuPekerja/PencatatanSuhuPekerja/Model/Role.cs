﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PencatatanSuhuPekerjaAPI.Model
{
    [Table("tb_m_role")]
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
