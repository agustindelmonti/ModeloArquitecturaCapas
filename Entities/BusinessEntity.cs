﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class BusinessEntity {
        public BusinessEntity() {
            this.State = States.New;
        }

        [Required, EnumDataType(typeof(States))]
        public States State { get; set; }
    

        public enum States {
            Deleted, New, Modified, Unmodified
        }

        
    }
}
