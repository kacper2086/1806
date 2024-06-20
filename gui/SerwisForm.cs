using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using gui.Models;
using YourNamespace.Models;
using System.Diagnostics;
using System.Text;
namespace gui
{
    public partial class SerwisForm : Form
    {
        private const string BaseUrl = "http://localhost:5157"; // Zmień na adres URL swojego API
        public SerwisForm()
        {
            InitializeComponent();
            LoadProductsAsync();
            LoadUsersAsync();
            LoadEventsAsync();
            LoadServisUsersAsync();
            wydaj.Click += wydaj_Click;
            editserv.Click += editserv_Click;
            refreshButton.Click += RefreshButton_Click;
            deny.Click += deny_Click;
            endserv.Click += endserv_Click;
        }

        private void SerwisForm_Load(object sender, EventArgs e)
        {

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
        private async void LoadServisUsersAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/users/servis");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<UserViewModel> servisUsers = JsonConvert.DeserializeObject<List<UserViewModel>>(json);


                        ser.DataSource = servisUsers;
                        ser.DisplayMember = "Username"; // Wyświetlaj nazwy użytkowników
                        ser.ValueMember = "Id"; // 
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
        private async void wydaj_Click(object sender, EventArgs e)
        {
            var selectedPart = (Product)parts1.SelectedItem;
            var selectedEvent = (EventViewModel)users1.SelectedItem;

            if (selectedPart != null && selectedEvent != null)
            {
                try
                {
                    // Parse hours from textBoxHour
                    if (!int.TryParse(hour.Text, out int hours))
                    {
                        MessageBox.Show("Wprowadź prawidłową liczbę godzin.");
                        return;
                    }

                    using (HttpClient client = new HttpClient())
                    {
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

                                // Calculate cost based on product price and additional charge for hours
                                decimal additionalCost = hours * 120; // Assuming 120 is the rate per hour
                                existingEvent.Cost = selectedPart.price + additionalCost; // Update the Cost property

                                // Update the Part details
                                existingEvent.Part = selectedPart.name;

                                // Send PUT request to update event and cost
                                HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                                if (updateResponse.IsSuccessStatusCode)
                                {
                                    // Proceed with updating cost directly in the UI
                                    try
                                    {
                                        // Send PUT request to update cost directly in the controller
                                        HttpResponseMessage updateCostResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/update-cost/{existingEvent.Id}", existingEvent.Cost);

                                        if (updateCostResponse.IsSuccessStatusCode)
                                        {
                                            MessageBox.Show("Koszt wydarzenia zaktualizowany pomyślnie.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nie udało się zaktualizować kosztu wydarzenia: " + updateCostResponse.ReasonPhrase);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Błąd przy aktualizacji kosztu: " + ex.Message);
                                    }

                                    // Proceed with other operations (e.g., decreasing stock)
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




        private async void LoadEventsAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/details");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        List<EventDetailsViewModel> eventTitles = JsonConvert.DeserializeObject<List<EventDetailsViewModel>>(json);

                        eventTitles = eventTitles.Where(e => e.Status != "rejected" && e.Status != "finished").ToList();
                        eve.DataSource = eventTitles; // Ustawienie źródła danych dla ComboBox
                        eve.DisplayMember = "DisplayText"; // Właściwość do wyświetlenia w ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać zdarzeń: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
        private async void editserv_Click(object sender, EventArgs e)
        {
            var selectedEvent = (EventDetailsViewModel)eve.SelectedItem;
            var selectedUser = (UserViewModel)ser.SelectedItem;

            if (selectedEvent != null && selectedUser != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Pobierz wydarzenie po ID
                        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/{selectedEvent.Id}");

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            Event existingEvent = JsonConvert.DeserializeObject<Event>(json);

                            // Aktualizuj pole Serwisant
                            existingEvent.Serwisant = selectedUser.Username;
                            existingEvent.Status = "in progress";

                            // Wyślij żądanie PUT, aby zaktualizować wydarzenie
                            HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                            if (updateResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Serwisant zaktualizowany pomyślnie.");
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się zaktualizować serwisanta: " + updateResponse.ReasonPhrase);
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
                MessageBox.Show("Proszę wybrać zarówno wydarzenie, jak i serwisanta.");
            }
        }
        private async void deny_Click(object sender, EventArgs e)
        {
            var selectedEvent = (EventDetailsViewModel)eve.SelectedItem;

            if (selectedEvent != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Pobierz wydarzenie po ID
                        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/{selectedEvent.Id}");

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            Event existingEvent = JsonConvert.DeserializeObject<Event>(json);

                            // Aktualizuj pole Status na "rejected"
                            existingEvent.Status = "rejected";

                            // Wyślij żądanie PUT, aby zaktualizować wydarzenie
                            HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                            if (updateResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Status wydarzenia zmieniony na 'rejected' pomyślnie.");
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się zmienić statusu wydarzenia: " + updateResponse.ReasonPhrase);
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
                MessageBox.Show("Proszę wybrać wydarzenie.");
            }
        }
        private async void endserv_Click(object sender, EventArgs e)
        {
            var selectedEvent = (EventDetailsViewModel)eve.SelectedItem;

            if (selectedEvent != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Pobierz wydarzenie po ID
                        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/{selectedEvent.Id}");

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            Event existingEvent = JsonConvert.DeserializeObject<Event>(json);

                            // Aktualizuj pole Status na "finished"
                            existingEvent.Status = "finished";

                            // Ustaw EndDate na bieżącą datę
                            existingEvent.EndDate = DateTime.UtcNow;
                            //   MessageBox.Show(existingEvent.UtcNow.ToString());

                            // Wyślij żądanie PUT, aby zaktualizować wydarzenie
                            HttpResponseMessage updateResponse = await client.PutAsJsonAsync($"{BaseUrl}/api/Event/{existingEvent.Id}", existingEvent);

                            if (updateResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Status wydarzenia zmieniony na 'finished' pomyślnie.");
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się zmienić statusu wydarzenia: " + updateResponse.ReasonPhrase);
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
                MessageBox.Show("Proszę wybrać wydarzenie.");
            }
        }













        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadProductsAsync();
            LoadUsersAsync();
            LoadEventsAsync();
            LoadServisUsersAsync();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SerwisForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
