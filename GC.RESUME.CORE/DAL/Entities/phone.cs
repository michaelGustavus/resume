﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Phone
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string Phone1 { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
