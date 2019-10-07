using System;
using System.Collections.Generic;
using System.Text;

namespace Reflexion_Generic
{
    public class History
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifyOn { get; set; }
        public int? ModifyBy { get; set; }
    }
}
