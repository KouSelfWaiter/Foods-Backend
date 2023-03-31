using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime SetKind(this DateTime DT, DateTimeKind DTKind)
        {
            return DateTime.SpecifyKind(DT, DTKind);
        }
    }
}
