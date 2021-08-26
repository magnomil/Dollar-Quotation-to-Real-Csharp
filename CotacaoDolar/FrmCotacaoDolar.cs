using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolar
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void FrmCotacaoDolar_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strurl = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=88baf85c";

            using (HttpClient client = new HttpClient())
            {

                try
                {
                    var response = client.GetAsync(strurl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        Market market = JsonConvert.DeserializeObject<Market>(result);
                        lblGetBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblGetSale.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVariationfrequency.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    }
                    else
                    {
                        lblGetBuy.Text = " - ";
                        lblGetSale.Text = " - ";
                        lblVariationfrequency.Text = " - ";
                    }

                }
                catch (Exception ex)
                {
                    lblGetBuy.Text = " - ";
                    lblGetSale.Text = " - ";
                    lblVariationfrequency.Text = " - ";

                    MessageBox.Show(ex.Message);
                }




               
            }
        }
    }
}
