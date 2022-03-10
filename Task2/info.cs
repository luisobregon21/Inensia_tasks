using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inesia
{
    [Serializable]
    public class Taxinfo
    {
        public string? Name { get; set; }
        public int? Salary { get; set; }
        public double? taxDeductions { get; set; }
        public int? netSalary { get; set; }

    }
}