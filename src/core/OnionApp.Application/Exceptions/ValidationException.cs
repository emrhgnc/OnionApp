using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException():this("Validation Error")
        {

        }
        public ValidationException(string Messsage):base(Messsage)
        {

        }

        public ValidationException(Exception ex):this(ex.Message)
        {

        }
    }
}
