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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gui
{
    public partial class KlientForm : Form
    {
        private const string BaseUrl = "http://localhost:5157";
        public KlientForm()
        {
            InitializeComponent();
            LoadEventDataAsync();
            btnAddEvent.Click += btnAddEvent_Click;

        }
        private async void KlientForm_Load(object sender, EventArgs e)
        {
            LoadEventDataAsync();

        }


        private async Task LoadEventDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("/api/Event");
                    response.EnsureSuccessStatusCode(); // Upewnij się, że odpowiedź jest udana

                    string json = await response.Content.ReadAsStringAsync();
                    List<EventViewModel> events = JsonConvert.DeserializeObject<List<EventViewModel>>(json);

                    // Wyczyść istniejące wiersze i kolumny
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    // Dodaj kolumny do DataGridView
                    dataGridView1.Columns.Add("TitleColumn", "Title");
                    dataGridView1.Columns.Add("StatusColumn", "Status");

                    // Wypełnij DataGridView danymi
                    foreach (var @event in events)
                    {
                        dataGridView1.Rows.Add(@event.Title, @event.Status);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd: {ex.Message}");
                }
            }


        }
        private async void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Przygotowanie danych wydarzenia z kontrolek formularza
                var newEvent = new EventKl
                {
                    Title = usluga.Text,
                    StartDate = date.Value.ToUniversalTime(),  // Konwersja na czas uniwersalny UTC
                    Part = "default_value",  // Ustawienie pola Part na "default_value"
                    Serwisant = "default_value",  // Ustawienie pola Serwisant na "default_value"
                    Status = "started"  // Ustawienie pola Status na "started"
                };

                // Serializacja danych wydarzenia do JSON
                string json = JsonConvert.SerializeObject(newEvent, new JsonSerializerSettings
                {
                    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ",
                    DateTimeZoneHandling = DateTimeZoneHandling.Utc  // Ustawienie strefy czasowej na UTC
                });

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Wysłanie żądania POST do API w celu dodania wydarzenia
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BaseUrl);

                    HttpResponseMessage response = await client.PostAsync("api/Event/CreateEvent", content);
                    response.EnsureSuccessStatusCode(); // Upewnij się, że kod statusu jest udany

                    // Opcjonalnie, poinformuj użytkownika o sukcesie
                    MessageBox.Show("Wydarzenie dodane pomyślnie!");

                    // Odśwież DataGridView lub inne aktualizacje, jeśli są potrzebne
                    LoadEventDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }











        public class EventViewModel
        {
            public string Title { get; set; }
            public string Status { get; set; }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            // Pobierz aktualny ClientId użytkownika

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
