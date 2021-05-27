using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisingController
{
    public partial class PersonView : Form, IPersonView
    {
        private Person _person;

        public PersonView()
        {
            InitializeComponent();
        }

        public Person MyPerson
        {
            get
            {
                _person.FirstName = txtFirstName.Text;
                _person.LastName = txtLastName.Text;
                return _person; 
            }

            set
            {
                _person = value;
                txtFirstName.Text = _person.FirstName;
                txtLastName.Text = _person.LastName;
            }
        }
    }
}
