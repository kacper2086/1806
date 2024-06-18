using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class MagazynForm : Form
    {
        private const string BaseUrl = "http://localhost:5157"; // Replace with your API base URL
        public MagazynForm()
        {
            InitializeComponent();
            LoadProductsAsync();
        }
        private async void LoadProductsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(BaseUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

                        // Assuming comboBox is named parts1
                        parts1.DisplayMember = "Name"; // Replace with your product property to display
                        parts1.ValueMember = "Id"; // Replace with your product property for value

                        parts1.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve products: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Optional: Handle comboBox selection change if needed
        private void parts1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example of handling selection change
            var selectedProduct = (Product)parts1.SelectedItem;
            if (selectedProduct != null)
            {
                MessageBox.Show($"Selected Product: {selectedProduct.name}, ID: {selectedProduct.id}");
            }
        }
    }
}
