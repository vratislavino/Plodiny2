namespace Plodiny2
{
    public partial class Form1 : Form
    {
        List<Plodina> plodiny;
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

            for(int i = 0; i < plodiny.Count; i++) { 
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDay();
        }

        private void AddDay()
        {
            dni++;
            daysLabel.Text = $"Poèet dnù: {dni}";
        }

    }
}
