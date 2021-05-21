using System;
using System.Collections.Generic;
using System.Text;

namespace testedeapi.Business.Abstractions.DTO {
    public class Paginacao<T> {
        public IEnumerable<T> Values { get; set; }
        public int? Count { get; set; }
    }
}
