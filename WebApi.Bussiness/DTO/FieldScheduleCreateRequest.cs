﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class FieldScheduleCreateRequest
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int FieldForeignKey { get; set; }

    }
}
