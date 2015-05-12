using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person aPerson1 = new Person();
            aPerson1.FirstName = firstNameTextBox.Text;
            aPerson1.MiddleName = middleNameTextBox.Text;
            aPerson1.LastName = lastNameTextBox.Text;

            string fullName = aPerson1.GetFullName();
            string reverseName = aPerson1.GetReverseFullName();

            fullNameTextBox.Text = fullName;
            reverseNameTextBox.Text = reverseName;
        }
    }
}
