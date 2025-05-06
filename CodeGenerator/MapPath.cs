using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class MapPath(string srcRoot)
    {
        public string SourceRoot { get; set; }
        public string ModelNmae { get; set; }
        public string API { get; set; } = srcRoot + "\\Api";
        public string Application { get; set; } = srcRoot + "\\Application";
        public string Domain { get; set; } = srcRoot + "\\Domain";
        public string Infrastructure { get; set; } = srcRoot + "\\Infrastructure";
        public string gRPC { get; set; } = srcRoot + "\\gRPC";
        public string Entity { get; set; } = srcRoot + "\\Entities";
        public string DomainDLL { get; set; } = srcRoot + $@"\Domain\bin\Debug\net8.0\{"HrmBaharu.Onb.Domain.dll"}";
        public string Features { get; set; }= srcRoot + "\\Application\\Features";
        public List<string> Entities { get; set; }=new List<string>();
    }
}
