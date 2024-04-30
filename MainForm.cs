namespace ProgrammingInCSharp10;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        string logoImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content", "Images", "channelcsharp.png");
        logoPictureBox.ImageLocation = logoImagePath;
        logoPictureBox.SizeMode = PictureBoxSizeMode.Normal;
    }

    private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new CustomerForm();
        customerForm.Show();
    }

    private void createProductToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void productListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new ProductForm();
        productForm.Show();
    }
    private void productManagmentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }


}
