

using BaseBackend.ProgrammingInCSharp10.Common;
using BaseBackend.ProgrammingInCSharp10.Models;
using BaseBackend.ProgrammingInCSharp10.Repositories;
using BaseBackend.ProgrammingInCSharp10.Enums;

namespace ProgrammingInCSharp10
{
    public partial class CustomerForm : Form
    {
        Customer selectedCustomer = null;
        // Define a delegate for refreshing data
        public delegate void RefreshDataDelegate();

        // Define an event of the delegate type
        public event RefreshDataDelegate RefreshDataEvent;

        public CustomerForm()
        {
            InitializeComponent();


            // Subscribe to the RefreshDataEvent to refresh data after form load
            RefreshDataEvent += LoadFormData;

            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));

            RefreshDataEvent?.Invoke();
        }

        private void LoadFormData()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            List<Customer> customers = customerRepository.GetAll();
            customerDataGridView.DataSource = null;
            customerDataGridView.DataSource = customers;
            customerDataGridView.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isValidForm = true;
            bool isValidEmail = General.CheckEmailValidation(emailTextBox.Text);
            if (!isValidEmail)
            {
                isValidForm = false;
            }
            bool isValidMobilenumber = General.CheckMobileValidation(phoneNumberTextBox.Text);
            if (!isValidMobilenumber)
            {
                isValidForm = false;
            }

            if (isValidForm)
            {
                Customer customer = new Customer(firstName: nameTextBox.Text,
                    lastName: lastNameTextBox.Text,
                    email: emailTextBox.Text,
                    phoneNumber: phoneNumberTextBox.Text,
                    gender: (Gender)genderComboBox.SelectedItem,
                    username: userNameTextBox.Text,
                    password: passwordTextBox.Text
                    );
                CustomerRepository customerRepository = new CustomerRepository();
                customerRepository.AddItem(item: customer);
                RefreshDataEvent?.Invoke();
                ResetForm();
            }
            else
            {
                string isValidEmailMessage = !isValidEmail ? "Please Enter Valid Email" : "";
                string isValidmobileNumberMessage = !isValidMobilenumber ? "Please Enter Valid MobileNumber" : "";
                string message = $"InValid Data: {isValidEmailMessage} {isValidmobileNumberMessage}";

                MessageBox.Show(message);
            }
        }

        private void DeleteButtom_Click(object sender, EventArgs e)
        {
            if (selectedCustomer is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
                
            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.DeleteItem(id: selectedCustomer.Id);
            RefreshDataEvent?.Invoke();
            ResetForm();

        }

        private void ResetForm()
        {
            nameTextBox.Text = default;
            lastNameTextBox.Text = default;
            emailTextBox.Text = default;
            phoneNumberTextBox.Text = default;
            userNameTextBox.Text = default;
            passwordTextBox.Text = default;
            selectedCustomer = null;
            genderComboBox.SelectedItem = default;
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = customerDataGridView.SelectedCells[0].RowIndex;
                var row = customerDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());

                CustomerRepository customerRepository = new CustomerRepository();
                Customer customer = customerRepository.GetById(id);
                nameTextBox.Text = customer.FirstName;
                lastNameTextBox.Text = customer.LastName;
                emailTextBox.Text = customer.Email;
                phoneNumberTextBox.Text = customer.PhoneNumber;
                userNameTextBox.Text = customer.Username;
                passwordTextBox.Text = customer.Password;
                selectedCustomer = customer;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedCustomer is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }

            CustomerRepository customerRepository = new CustomerRepository();
            selectedCustomer.Email = emailTextBox.Text;
            selectedCustomer.FirstName = nameTextBox.Text;
            selectedCustomer.LastName = lastNameTextBox.Text;
            selectedCustomer.PhoneNumber = phoneNumberTextBox.Text;
            selectedCustomer.Gender = (Gender)genderComboBox.SelectedItem;
            selectedCustomer.Username = userNameTextBox.Text;
            customerRepository.UpdateItem(selectedCustomer);
            RefreshDataEvent?.Invoke();
            ResetForm();

        }
    }
}
