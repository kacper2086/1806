using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadItemShopAsync();
            zamow.Click += zamow_Click;
        }

        private async void LoadProductsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/products");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

                        parts1.DataSource = products; // Ustawienie źródła danych dla ComboBox
                        parts1.DisplayMember = "DisplayText"; // Właściwość do wyświetlenia w ComboBox
                        parts1.ValueMember = "id"; // Właściwość produktu jako wartość wybierana
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

        private async void LoadItemShopAsync()
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

                        shopname.DisplayMember = "DisplayText"; // Właściwość do wyświetlenia w ComboBox
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

        private async void zamow_Click(object sender, EventArgs e)
        {
            var selectedProduct = (ItemShop)shopname.SelectedItem;
            if (selectedProduct != null)
            {
                if (int.TryParse(ilosczam.Text, out int quantityToAdd))
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            // Sprawdzenie czy przedmiot już istnieje w tabeli Products
                            HttpResponseMessage checkResponse = await client.GetAsync($"{BaseUrl}/api/products/name/{selectedProduct.Name}");

                            if (checkResponse.IsSuccessStatusCode)
                            {
                                // Przedmiot istnieje - zwiększ stockquantity o wartość z textbox1
                                string json = await checkResponse.Content.ReadAsStringAsync();
                                Product existingProduct = JsonConvert.DeserializeObject<Product>(json);

                                existingProduct.stockquantity += quantityToAdd; // Zwiększenie ilości o wartość z textbox1

                                // Aktualizacja istniejącego przedmiotu w tabeli Products
                                HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/products/{existingProduct.id}", existingProduct);

                                if (updateResponse.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Przedmiot zaktualizowany pomyślnie.");
                                    // Opcjonalnie: Odświeżenie listy przedmiotów po aktualizacji
                                    LoadProductsAsync();
                                }
                                else
                                {
                                    MessageBox.Show("Nie udało się zaktualizować przedmiotu w tabeli Products.");
                                }
                            }
                            else if (checkResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                            {
                                // Przedmiot nie istnieje - dodaj nowy przedmiot do tabeli Products
                                Product newProduct = new Product
                                {
                                    name = selectedProduct.Name,
                                    price = selectedProduct.Price * 1.4m, // Zwiększenie ceny o 40%
                                    stockquantity = quantityToAdd // Ustawienie ilości na wartość z textbox1
                                };

                                // Dodanie nowego przedmiotu do tabeli Products
                                HttpResponseMessage addResponse = await client.PostAsJsonAsync($"{BaseUrl}/api/products", newProduct);

                                if (addResponse.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Przedmiot dodany pomyślnie.");
                                    // Opcjonalnie: Odświeżenie listy przedmiotów po dodaniu
                                    LoadProductsAsync();
                                }
                                else
                                {
                                    MessageBox.Show("Nie udało się dodać nowego przedmiotu do tabeli Products.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się sprawdzić przedmiotu w tabeli Products.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wpisać prawidłową liczbę w polu ilości.");
                }
            }
        }
    }

    public class ItemShop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Dodana właściwość tylko do wyświetlania w ComboBox
        public string DisplayText => $"{Name} - Cena: {Price:C}";
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int stockquantity { get; set; }
        public decimal price { get; set; }

        // Dodana właściwość tylko do wyświetlania w ComboBox
        public string DisplayText => $"{name} - Sztuk: {stockquantity} - Cena: {price:C}";
    }

    public class User
    {
        public string Username { get; set; }
    }
}
