using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveView
{
    public partial class PersonView : Form, IPersonView
    {
        PersonPresenter perseter;

        public PersonView()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }

            set
            {
                txtFirstName.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }

            set
            {
                txtLastName.Text = value;
            }
        }

        private void BtnLoadPersonInfoClick(object sender, EventArgs e)
        {
            perseter.LoadPersonData();
        }

        private void PersonView_Load(object sender, EventArgs e)
        {
            perseter = new PersonPresenter(this);
        }
    }
}
