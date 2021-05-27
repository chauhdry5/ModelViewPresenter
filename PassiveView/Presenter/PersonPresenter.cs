using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveView
{
    public class PersonPresenter
    {
        public Person GetPerson()
        {
            return new Person()
            {
                FirstName = "Mudasser",
                LastName = "Hameed"
            };

        }

    }
}
