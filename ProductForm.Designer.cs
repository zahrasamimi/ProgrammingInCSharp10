namespace ProgrammingInCSharp10
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameTextBox = new TextBox();
            saveButton = new Button();
            brandTextBox = new TextBox();
            label1 = new Label();
            priceTextBox = new TextBox();
            label2 = new Label();
            countTextBox = new TextBox();
            label3 = new Label();
            IsActiveCheckBox = new CheckBox();
            productDataGridView = new DataGridView();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            nameLabel.Click += nameLabel_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(57, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(180, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(523, 58);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(217, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(337, 5);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(180, 23);
            brandTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 8);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Brand Name";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(57, 40);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(180, 23);
            priceTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(337, 39);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(180, 23);
            countTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 44);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Count";
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(571, 7);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(67, 19);
            IsActiveCheckBox.TabIndex = 9;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(12, 107);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowTemplate.Height = 25;
            productDataGridView.Size = new Size(776, 331);
            productDataGridView.TabIndex = 10;
            productDataGridView.CellContentClick += productDataGridView_CellContentClick;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(523, 29);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(217, 23);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear Form";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(productDataGridView);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(countTextBox);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(brandTextBox);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "ProductForm";
            Text = "Product";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Button saveButton;
        private TextBox brandTextBox;
        private Label label1;
        private TextBox priceTextBox;
        private Label label2;
        private TextBox countTextBox;
        private Label label3;
        private CheckBox IsActiveCheckBox;
        private DataGridView productDataGridView;
        private Button clearButton;
    }
}