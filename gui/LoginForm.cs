using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using gui.Models;

namespace gui
{
    public partial class LoginForm : Form
    {
        private string baseApiUrl = "http://localhost:5157";

        public LoginForm()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private async Task<UserDto> LoginAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseApiUrl);

                var loginRequest = new AuthenticateRequest
                {
                    Username = username,
                    Password = password
                };

                var jsonRequest = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("users/authenticate", content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    UserDto user = JsonConvert.DeserializeObject<UserDto>(jsonResponse);
                    return user;
                }
                else
                {
                    // Obsługa błędów logowania
                    return null;
                }
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Proszę wprowadzić nazwę użytkownika i hasło.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserDto loggedInUser = await LoginAsync(Username, Password);

                if (loggedInUser != null)
                {
                    OpenRoleWindow(loggedInUser.Role.ToLower()); // Przekształć rolę na małe litery
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy login lub hasło", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas logowania: {ex.Message}", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenRoleWindow(string role)
        {
            switch (role)
            {
                case "admin":
                    var adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                case "klient":
                    var KlientForm = new KlientForm();
                    KlientForm.Show();
                    break;
                case "magazyn":
                    var MagazynForm = new MagazynForm();
                    MagazynForm.Show();
                    break;
                case "serwis":
                    var SerwisForm = new SerwisForm();
                    SerwisForm.Show();
                    break;
                default:
                    MessageBox.Show($"Nieznana rola: {role}", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            this.Hide();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
