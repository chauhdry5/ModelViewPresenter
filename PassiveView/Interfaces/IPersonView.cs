using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveView
{
    public interface IPersonView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
