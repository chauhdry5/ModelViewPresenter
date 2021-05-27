using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveView
{
    public class PersonPresenter
    {
        private readonly IPersonView myPersonView;

        public PersonPresenter(IPersonView personView)
        {
            myPersonView = personView;
        }

        public void LoadPersonData()
        {
            myPersonView.FirstName = "Mudasser";
            myPersonView.LastName = "Hameed";

        }

    }
}
