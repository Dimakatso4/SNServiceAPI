using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNServiceAPI.Models
{
    public class GradeVerificationModel
    {
        public int GradeId { get; set; }
        public string Grade { get; set; }
        public int NoLearners { get; set; }
        public int VerificationId { get; set; }
    }
}
