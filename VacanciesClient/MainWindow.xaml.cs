using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Text.Json;
using System.IO;

namespace VacanciesClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            message.Content = "";
            listView.Items.Clear();

            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var response = await client.GetAsync("http://localhost:5000/api/Vacancies");
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        Stream stream = response.Content.ReadAsStream();
                        StreamReader re = new StreamReader(stream);
                        string json = re.ReadToEnd();
                        List<ActiveVacancy> AVList = System.Text.Json.JsonSerializer.Deserialize<List<ActiveVacancy>>(json);
                        
                        foreach( ActiveVacancy av in AVList)
                        {
                            listView.Items.Add(av);
                        }
                    }
                    else
                    {
                        message.Content = $"Server Error Code {response.StatusCode}";
                    }
                }
            }
            catch( Exception E )
            {
               message.Content=E.Message;
            }
        }
    }
}
