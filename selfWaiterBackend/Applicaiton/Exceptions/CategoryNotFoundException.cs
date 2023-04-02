using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Exceptions
{
    public class CategoryNotFoundException: Exception
    {

        public static string Message { get; } = "İlgili Kategori Bulunamadı";
        public CategoryNotFoundException(): base(Message)
        {

        }

        public CategoryNotFoundException(string? message) : base(message)
        {
        }

        public CategoryNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
