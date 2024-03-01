using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatAsService.APIService
{
    internal class CatImage
    {
        public string url { get; set; }
        public CatModel[] breeds { get; set; }
    }
}
