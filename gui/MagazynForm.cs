using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using gui.Models;
using YourNamespace.Models;

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
            LoadSTartedEventsAsync();
            LoadItemShopAsync();
            zamow.Click += zamow_Click;
            wydaj.Click += wydaj_Click;
            przyjmij.Click += przyjmij_Click;
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
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/started");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<EventViewModel> eventTitles = JsonConvert.DeserializeObject<List<EventViewModel>>(json);

                        users1.DataSource = eventTitles; // Ustawienie źródła danych dla ComboBox
                        users1.DisplayMember = "DisplayText"; // Właściwość do wyświetlenia w ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać zakończonych wydarzeń: " + response.ReasonPhrase);
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
        private async void LoadSTartedEventsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/started");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<EventViewModel> eventViewModels = JsonConvert.DeserializeObject<List<EventViewModel>>(json);

                        przyjmpart.DataSource = eventViewModels; // Set data source for ComboBox
                        przyjmpart.DisplayMember = "DisplayText"; // Display property in ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve ended events: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void wydaj_Click(object sender, EventArgs e)
        {
            var selectedPart = (Product)parts1.SelectedItem;
            var selectedEvent = (EventViewModel)users1.SelectedItem;

            if (selectedPart != null && selectedEvent != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Pobierz wydarzenie po tytule i dacie rozpoczęcia
                        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/title/{selectedEvent.Title}");

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            Event existingEvent = JsonConvert.DeserializeObject<Event>(json);

                            if (existingEvent.StartDate == selectedEvent.StartDate)
                            {
                                if (existingEvent.Part != null && existingEvent.Part != "default_value")
                                {
                                    MessageBox.Show("Wydarzenie ma już przypisaną część.");
                                    return;
                                }

                                // Wykonaj aktualizację w bazie danych, przypisując część do wydarzenia
                                existingEvent.Part = selectedPart.name;

                                HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                                if (updateResponse.IsSuccessStatusCode)
                                {
                                    // Wywołaj API do zmniejszenia ilości w magazynie
                                    HttpResponseMessage decreaseStockResponse = await client.PutAsync($"{BaseUrl}/api/products/decrease-stock/{selectedPart.name}", null);

                                    if (decreaseStockResponse.IsSuccessStatusCode)
                                    {
                                        MessageBox.Show("Wydarzenie zaktualizowane pomyślnie.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nie udało się zaktualizować ilości w magazynie: " + decreaseStockResponse.ReasonPhrase);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nie udało się zaktualizować wydarzenia: " + updateResponse.ReasonPhrase);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nie znaleziono wydarzenia z podaną datą rozpoczęcia.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nie udało się pobrać wydarzenia: " + response.ReasonPhrase);
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
                MessageBox.Show("Proszę wybrać zarówno część, jak i wydarzenie.");
            }
        }
        private async void przyjmij_Click(object sender, EventArgs e)
        {
            var selectedPart = (Product)parts1.SelectedItem;
            var selectedEvent = (EventViewModel)przyjmpart.SelectedItem; // Używamy przyjmpart zamiast users1

            if (selectedPart == null || selectedEvent == null)
            {
                MessageBox.Show("Proszę wybrać zarówno część, jak i wydarzenie.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/title/{selectedEvent.Title}");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Event existingEvent = JsonConvert.DeserializeObject<Event>(json);

                        if (existingEvent.StartDate != selectedEvent.StartDate)
                        {
                            MessageBox.Show("Nie znaleziono wydarzenia z podaną datą rozpoczęcia.");
                            return;
                        }

                        if (existingEvent.Part == "default_value")
                        {
                            MessageBox.Show("Wydarzenie ma już przypisaną część.");
                            return;
                        }

                        existingEvent.Part = "default_value";

                        HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                        if (updateResponse.IsSuccessStatusCode)
                        {
                            HttpResponseMessage increaseStockResponse = await client.PutAsync($"{BaseUrl}/api/products/increase-stock/{selectedPart.name}", null);

                            if (increaseStockResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Wydarzenie przyjęte pomyślnie. Stockquantity zwiekszony o 1.");
                            }
                            else
                            {
                                MessageBox.Show($"Nie udało się zmniejszyć ilości w magazynie: {increaseStockResponse.ReasonPhrase}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Nie udało się zaktualizować wydarzenia: {updateResponse.ReasonPhrase}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Nie udało się pobrać wydarzenia: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
                // Log exception details
                Console.WriteLine($"Exception: {ex}");
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

