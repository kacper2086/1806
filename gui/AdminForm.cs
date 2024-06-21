using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class AdminForm : Form
    {
        private const string BaseUrl = "http://localhost:5157";
        public AdminForm()
        {
            InitializeComponent();
            btnAddUser.Click += btnAddUser_Click;
            LoadUsers();
            btnRefresh.Click += btnRefresh_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5157");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var userData = new { username = login, password = password, role = role };
                    string json = JsonConvert.SerializeObject(userData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("/users", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User added successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Failed to add user. " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async void LoadUsers()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BaseUrl);

                    HttpResponseMessage response = await client.GetAsync("/Users/all");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        List<UserDto> users = JsonConvert.DeserializeObject<List<UserDto>>(jsonResponse);

                        dataGridViewUsers.DataSource = users; // Bind data to DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się pobrać listy użytkowników", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView()
        {
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Dodawanie kolumn
            dataGridViewUsers.Columns.Add("IdColumn", "ID");
            dataGridViewUsers.Columns.Add("UsernameColumn", "Username");
            dataGridViewUsers.Columns.Add("PasswordColumn", "Password"); // W rzeczywistej aplikacji nie zaleca się wyświetlania hasła w ten sposób
            dataGridViewUsers.Columns.Add("RoleColumn", "Role");

            // Dostosowanie kolumn (opcjonalne)
            dataGridViewUsers.Columns["IdColumn"].Visible = false; // Ukrycie kolumny ID, jeśli nie ma być widoczna dla użytkownika
            dataGridViewUsers.Columns["PasswordColumn"].Visible = false; // Ukrycie hasła

            // Możesz również dostosować inne właściwości kolumn, takie jak ReadOnly, Width, DefaultCellStyle itp.
        }
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Powrót do formularza logowania
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Ukrycie bieżącego formularza
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            LoadUsers();
            MessageBox.Show("Odświeżono dane");
        }
        private void utworz_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
