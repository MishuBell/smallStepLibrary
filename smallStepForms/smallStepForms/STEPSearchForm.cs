using smallStepLibrary;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smallStep
{
    public partial class STEPSearchForm : Form
    {
        private SqlConnection sqlConnection;
        public STEPSearchForm()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["mySmallStep"].ConnectionString;
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);
        }
        private void SearchPersonButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Person WHERE FirstName = @FirstName AND LastName = @LastName AND DateOfBirth = @DateOfBirth";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameValueTextbox.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", LastNameValueTextbox.Text);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", DateOfBirthValueTextbox.Text);

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            searchResultListbox.DataSource = dataTable;
            searchResultListbox.DisplayMember = "FirstName + ' ' + LastName + ' ' + DateOfBirth + ' ' + id";

            searchResultListbox.ValueMember = "id";
        }

        private void CreateNewPersonButton_Click(object sender, System.EventArgs e)
        {
            string GenerateRandomUniqueIdentityNumber()
            {
                Guid guid = Guid.NewGuid();
                return guid.ToString("N");
            }

            if (!ValidateMinimumRequirements())
            {
                MessageBox.Show("Please enter valid credentials");
            }
            else
            {
                PersonModel personModel = new PersonModel( FirstNameValueTextbox.Text,
                                                           LastNameValueTextbox.Text,
                                                           DateOfBirthValueTextbox.Text,
                                                           AddressValueTextbox.Text,
                                                           GenerateRandomUniqueIdentityNumber(),
                                                           PhoneNumberValueTextbox.Text,
                                                           EmailValueTextbox.Text);

                SqlConnector sql = new SqlConnector();
                sql.CreatePerson(personModel);

            }

        }

        // TODO - Add counter. One minimum requirement search has to be made, before an extended search is allowed
        private bool ValidateMinimumRequirements()
        {
            if (string.IsNullOrEmpty(FirstNameValueTextbox.Text))
            {
                MessageBox.Show("Please enter a first name.");
                return false;
            }

            if (string.IsNullOrEmpty(LastNameValueTextbox.Text))
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }

            if (string.IsNullOrEmpty(DateOfBirthValueTextbox.Text))
            {
                MessageBox.Show("Please enter a date of birth.");
                return false;
            }

            return true;
        }

        private bool ValidateExtendedSearch()
        {
            if (string.IsNullOrEmpty(AddressValueTextbox.Text))
            {
                MessageBox.Show("Please enter an address.");
                return false;
            }

            //if (string.IsNullOrEmpty(UniqueIdentityNumberValueTextbox.Text))
            //{
            //    MessageBox.Show("Please enter a unique identity number.");
            //    return false;
            //}

            if (string.IsNullOrEmpty(PhoneNumberValueTextbox.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return false;
            }

            if (string.IsNullOrEmpty(EmailValueTextbox.Text))
            {
                MessageBox.Show("Please enter an email address.");
                return false;
            }

            return true;
        }

        private void searchResultListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
