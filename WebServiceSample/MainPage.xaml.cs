using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebServiceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
             
        }

		private async void BtnCallWS_Click (object sender, EventArgs e)    
        {    
                WSClient client = new WSClient();
                var result = await client.Get<WSResult>("https://jsonplaceholder.typicode.com/posts/1");
                string h = string.Empty;

                if (result != null)
                {
                    lblId.Text    = $"{result.id}";
                    lblTitle.Text = result.title;
                    lblBody.Text  = result.body;
                }
 
        }  

    }
}