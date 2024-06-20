using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            btnOpenInvoice.Click += btnOpenInvoice_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnPobierzFakture.Click += btnPobierzFakture_Click;
            // Zmiana na CellClick
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Upewnij się, że kliknięcie jest w rzeczywistym wierszu danych
            {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                var selectedEvent = (EventViewModel)selectedRow.DataBoundItem;
                MessageBox.Show($"Wybrano wydarzenie: {selectedEvent.Title}");
                if (selectedEvent != null)
                {
                    MessageBox.Show($"Wybrano wydarzenie: {selectedEvent.Title}");
                }
            }
        }



        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Powrót do formularza logowania
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Ukrycie bieżącego formularza
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
                    dataGridView1.Columns.Add("CostColumn", "Cost");
                    dataGridView1.Columns.Add("StartDateColumn", "StartDate");


                    // Wypełnij DataGridView danymi
                    foreach (var @event in events)
                    {
                        dataGridView1.Rows.Add(@event.Title, @event.Status, @event.Cost, @event.StartDate);
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
                    Status = "started",  // Ustawienie pola Status na "started"
                    Cost = 0
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
            public int Id { get; set; }
            public string Title { get; set; }
            public string Status { get; set; }
            public string Cost { get; set; }
            public DateTime StartDate { get; set; }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            // Pobierz aktualny ClientId użytkownika

        }
        private async void btnOpenInvoice_Click(object sender, EventArgs e)
        {
            var selectedEvent = (EventViewModel)dataGridView1.CurrentRow.DataBoundItem;

            if (selectedEvent != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/api/Event/{selectedEvent.Id}/invoice");

                        if (response.IsSuccessStatusCode)
                        {
                            byte[] invoiceBytes = await response.Content.ReadAsByteArrayAsync();

                            // Zapisz pobraną fakturę do pliku tymczasowego
                            string tempFilePath = Path.GetTempFileName();
                            File.WriteAllBytes(tempFilePath, invoiceBytes);

                            // Otwórz fakturę za pomocą domyślnej aplikacji systemowej
                            Process.Start(tempFilePath);
                        }
                        else
                        {
                            MessageBox.Show("Nie udało się pobrać faktury: " + response.ReasonPhrase);
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
                MessageBox.Show("Proszę wybrać wydarzenie z DataGridView.");
            }
        }
        private async void btnPobierzFakture_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony wiersz
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pobierz dane z poszczególnych komórek wybranego wiersza
                string title = selectedRow.Cells["TitleColumn"].Value.ToString();
                string status = selectedRow.Cells["StatusColumn"].Value.ToString();
                decimal cost = Convert.ToDecimal(selectedRow.Cells["CostColumn"].Value);
                DateTime startDate = Convert.ToDateTime(selectedRow.Cells["StartDateColumn"].Value);

                // Tworzenie zawartości faktury w formacie CSV (lub innym, według potrzeb)
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Title,Status,StartDate,Cost");
                sb.AppendLine($"{title},{status},{startDate},{cost}");

                // Utworzenie i skonfigurowanie okna dialogowego do zapisu pliku
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.Title = "Save Invoice As";
                saveDialog.FileName = "invoice.txt"; // Domyślna nazwa pliku
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Początkowy katalog

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Zapisanie faktury do wybranego pliku
                        File.WriteAllText(saveDialog.FileName, sb.ToString());

                        // Informacja o zapisaniu pliku
                        MessageBox.Show($"Plik faktury został zapisany jako:\n{saveDialog.FileName}", "Zapisano fakturę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas zapisywania faktury: {ex.Message}", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz zawierający fakturę do pobrania.", "Brak zaznaczenia");
            }
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                MessageBox.Show("Proszę wybrać wydarzenie z DataGridView."); // Możesz tut MessageBox.Show("Proszę wybrać wydarzenie z DataGridView.");aj podjąć działania na wybranym wierszu
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KlientForm_Load_1(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
