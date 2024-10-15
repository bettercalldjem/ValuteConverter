using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CurrencyConverter
{
    public partial class MainForm : Form
    {
        private Dictionary<string, decimal> exchangeRates;

        public MainForm()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private async void LoadCurrencies()
        {
            exchangeRates = await GetExchangeRates();
            comboBoxFrom.DataSource = new BindingSource(exchangeRates, null);
            comboBoxFrom.DisplayMember = "Key";
            comboBoxFrom.ValueMember = "Value";
            comboBoxTo.DataSource = new BindingSource(exchangeRates, null);
            comboBoxTo.DisplayMember = "Key";
            comboBoxTo.ValueMember = "Value";
        }
        private async Task<Dictionary<string, decimal>> GetExchangeRates()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("https://api.exchangerate-api.com/v4/latest/USD");
                dynamic json = JsonConvert.DeserializeObject(response);
                var rates = json.rates;

                var exchangeRates = new Dictionary<string, decimal>();

                foreach (var rate in rates)
                {
                    
                    string currency = rate.Path.Split('.')[1];
                    decimal value = (decimal)rate.Value; 
                    exchangeRates[currency] = value;
                }

                return exchangeRates;
            }
        }



        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                
                var fromCurrency = ((KeyValuePair<string, decimal>)comboBoxFrom.SelectedItem).Key;
                var toCurrency = ((KeyValuePair<string, decimal>)comboBoxTo.SelectedItem).Key;

                
                if (exchangeRates.TryGetValue(fromCurrency, out decimal fromRate) &&
                    exchangeRates.TryGetValue(toCurrency, out decimal toRate))
                {
                    
                    decimal convertedAmount = (amount / fromRate) * toRate;
                    labelResult.Text = $"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}";
                }
                else
                {
                    MessageBox.Show("Ошибка: выбранные валюты не найдены.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму для конвертации.");
            }
        }

    }
}
