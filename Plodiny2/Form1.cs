namespace Plodiny2
{
    public partial class Form1 : Form
    {
        List<Plodina> plodiny;
        List<PlodinaView> views;
        int bilkovin = 0;
        int dni = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VytvorPlodiny(10);
        }

        private void VytvorPlodiny(int pocet)
        {
            plodiny = new List<Plodina>();
            for (int i = 0; i < pocet; i++)
            {
                if (Plodina.random.Next(0, 2) == 0)
                {
                    plodiny.Add(new Kureci("Èesko"));
                }
                else
                {
                    plodiny.Add(new Hovezi("Portugalsko", 6));
                }
            }

            views = new List<PlodinaView>();
            for (int i = 0; i < plodiny.Count; i++) {
                PlodinaView p = new PlodinaView();
                flowLayoutPanel1.Controls.Add(p);
                views.Add(p);
                p.OnDayEnded += AddDay;
                p.SetPlodina(plodiny[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDay();
        }

        private void AddDay()
        {
            dni++;
            plodiny.ForEach(p => p.Zestarni());
            views.ForEach(v => v.UpdateView());
            daysLabel.Text = $"Poèet dnù: {dni}";
        }

    }
}
