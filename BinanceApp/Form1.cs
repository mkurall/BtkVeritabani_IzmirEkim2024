using Binance.Net.Clients;

namespace BinanceApp
{
    public partial class Form1 : Form
    {
        public delegate void LabelGuncelle(decimal price);

        BinanceSocketClient socketClient = new BinanceSocketClient();

        decimal oncekiFiyat;

        void LblFiyatGuncelle(decimal price)
        {
            lblFiyat.Text = price.ToString();
            if (oncekiFiyat < price)

                lblFiyat.ForeColor = Color.Green;
            else if (oncekiFiyat > price)
                lblFiyat.ForeColor = Color.Red;

            else
                lblFiyat.ForeColor = Color.Gray;
            oncekiFiyat = price;
        }

        LabelGuncelle delFiyatGuncelle;

        public Form1()
        {
            InitializeComponent();

            delFiyatGuncelle = LblFiyatGuncelle;
        }

        private async void btnBaglan_Click(object sender, EventArgs e)
        {/*
            var restClient = new BinanceRestClient();
            var tickerResult = await restClient.SpotApi.ExchangeData.GetTickerAsync("BTCUSDT");
            var lastPrice = tickerResult.Data.LastPrice;

            lblFiyat.Text = lastPrice.ToString();
            */

            // Subscribe to ETH/USDT ticker updates via the websocket API
            
            var tickerSubscriptionResult = await socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync("BTCUSDT", (update) =>
            {
                var lastPrice = update.Data.LastPrice;
                
               lblFiyat.Invoke(delFiyatGuncelle,  lastPrice);


            });

           
            
        }


    }
}
