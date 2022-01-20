using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDB
{
    public partial class Loadin : Form
    {
        public Loadin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 599)
            {
                timer1.Stop();
                PainelLogin inicializando = new PainelLogin();
                inicializando.Show();
                this.Visible = false;
            }
        }
    }
}
