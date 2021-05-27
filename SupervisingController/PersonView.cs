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
        private Person person;
        private PersonPresenter presenter;

        public PersonView()
        {
            InitializeComponent();
        }

        public Person MyPerson
        {
            get
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                return person; 
            }

            set
            {
                person = value;
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
            }
        }

        private void BtnLoadPersonInfoClick(object sender, EventArgs e)
        {
            presenter.LoadPersonData();
        }

        private void PersonView_Load(object sender, EventArgs e)
        {
            presenter = new PersonPresenter(this);
        }
    }
}
