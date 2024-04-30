
using BaseBackend.ProgrammingInCSharp10.Models;
using BaseBackend.ProgrammingInCSharp10.Repositories;


namespace ProgrammingInCSharp10
{
    public partial class ProductForm : Form
    {
        // Define a delegate for refreshing data
        public delegate void RefreshDataDelegate();

        // Define an event of the delegate type
        public event RefreshDataDelegate RefreshDataEvent;

        public ProductForm()
        {
            InitializeComponent();

            // Subscribe to the RefreshDataEvent to refresh data after form load
            RefreshDataEvent += LoadFormData;

            RefreshDataEvent?.Invoke();
        }


        private void LoadFormData()
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> products = productRepository.GetAll();
            productDataGridView.DataSource = null;
            productDataGridView.DataSource = products;
            productDataGridView.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(countTextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("please enter valid inputs");
                    return;
                }
                Product product = new Product(name: nameTextBox.Text, brandName: brandTextBox.Text, price: decimal.Parse(priceTextBox.Text), count: int.Parse(countTextBox.Text));
                ProductRepository productRepository = new ProductRepository();
                productRepository.AddItem(product);

                // Raise the event to refresh data after insert
                RefreshDataEvent?.Invoke();

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            countTextBox.Text = default;
            priceTextBox.Text = default;
            nameTextBox.Text = default;
            brandTextBox.Text = default;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
