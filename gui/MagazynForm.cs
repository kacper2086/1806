using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace gui
{
    public partial class MagazynForm : Form
    {
        private const string BaseUrl = "http://localhost:5157"; // Zmień na adres URL swojego API
        public MagazynForm()
        {
            InitializeComponent();
            LoadProductsAsync();
            LoadUsersAsync();
            LoadProductsAsync1();
        }

        private async void LoadProductsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:5157/api/products");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

                        parts1.DisplayMember = "Name"; // Właściwość produktu do wyświetlenia w ComboBox
                        parts1.ValueMember = "Id"; // Właściwość produktu jako wartość wybierana

                        parts1.DataSource = products; // Ustawienie źródła danych dla ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać produktów: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }


        // Opcjonalnie: Obsługa zmiany wyboru w ComboBox
        private void parts1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Przykład obsługi zmiany wyboru
            var selectedProduct = (Product)parts1.SelectedItem;
            if (selectedProduct != null)
            {
                MessageBox.Show($"Wybrany produkt: {selectedProduct.name}, ID: {selectedProduct.id}");
            }
        }
        private async void LoadUsersAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/userR/role/serwis");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<string> usernames = JsonConvert.DeserializeObject<List<string>>(json);

                        users1.DataSource = usernames; // Ustawienie źródła danych dla ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać użytkowników: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        // Opcjonalnie: Obsługa zmiany wyboru w ComboBox
        private void users1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Przykład obsługi zmiany wyboru
            var selectedUsername = users1.SelectedItem as string;
            if (selectedUsername != null)
            {
                MessageBox.Show($"Wybrany użytkownik: {selectedUsername}");
            }
        }

        private void shopname_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Przykład obsługi zmiany wyboru
            var selectedProduct = (ItemShop)shopname.SelectedItem;
            if (selectedProduct != null)
            {
                MessageBox.Show($"Wybrany produkt: {selectedProduct.Name}, Cena: {selectedProduct.Price:C}");
            }
        }
        private async void LoadProductsAsync1()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/itemshop");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<ItemShop> products = JsonConvert.DeserializeObject<List<ItemShop>>(json);

                        shopname.DataSource = products; // Ustawienie źródła danych dla ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać produktów: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
    public class ItemShop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:C}"; // Formatowanie do wyświetlenia nazwy i ceny
        }
    }
    public class User
    {
        public string Username { get; set; }
    }
}
    

