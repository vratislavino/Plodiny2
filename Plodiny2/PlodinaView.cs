using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plodiny2
{
    public partial class PlodinaView : UserControl
    {
        public event Action OnDayEnded;

        private Plodina plodina;

        public PlodinaView()
        {
            InitializeComponent();
        }

        public void SetPlodina(Plodina plodina)
        {
            this.plodina = plodina;
            UpdateView();
        }

        public void UpdateView()
        {
            label1.Text = plodina.Name;
            label2.Text = plodina.puvod;
            label3.Text = $"{plodina.uroven}";
            label4.Text = plodina.pocetBilkovin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { // zalít
            plodina.Zalit();
            OnDayEnded?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        { // sklidit
            plodina.Sklidit();
            OnDayEnded?.Invoke();
        }
    }
}
