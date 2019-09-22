using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Models {
    public class BusinessEntity {
        public BusinessEntity() {
            this.State = States.New;
        }

        public States State { get; set; }
    

        public enum States {
            Deleted, New, Modified, Unmodified
        }

        
    }
}
