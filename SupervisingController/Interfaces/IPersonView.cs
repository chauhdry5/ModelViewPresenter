using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisingController
{
    public interface IPersonView
    {
        Person MyPerson { get; set; }
    }
}
