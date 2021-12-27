using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nypproje1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            DataCek data = new DataCek(Uygulama.Markets);
            data.marketEklke();
            foreach(var market in Uygulama.Markets)
            {
                MessageBox.Show(market.Market_id.ToString());
            }
        }

        
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
