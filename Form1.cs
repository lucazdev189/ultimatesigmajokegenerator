using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace jokeGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class JsonObject
        {
            public string setup { get; set; }
            public string punchline { get; set; }

        }

        private async void genButton_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jokeAPI = "https://official-joke-api.appspot.com/jokes/random";
                    HttpResponseMessage response = await client.GetAsync(jokeAPI);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var choppedBody = JsonSerializer.Deserialize<JsonObject>(responseBody);
                        string actualJoke = choppedBody.setup;
                        string actualAnswer = choppedBody.punchline;

                        jokeBox.Text = actualJoke + ", " + actualAnswer;
                    }
                    else
                    {
                        Console.WriteLine("Error: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(jokeBox.Text);
            MessageBox.Show("Copied to clipboard.");
        }
    }
}
