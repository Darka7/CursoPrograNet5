using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class IResult<T> :DBEntity
    {
        public IResult(IEnumerable<T> data)
        {
            Data = data;
        }

        public IResult()
        {
            Data = new List<T>();
        }

        public IEnumerable<T> Data { get; set; }
    }
}
