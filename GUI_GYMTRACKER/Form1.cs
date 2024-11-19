namespace GUI_GYMTRACKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            
            panel3.Height = button1.Height;

          
            this.homepanel.Controls.Clear();
            HomeDashboard homeDashboard = new HomeDashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.homepanel.Controls.Add(homeDashboard);
            homeDashboard.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;

            // Clear and add HomeDashboard
            this.homepanel.Controls.Clear();
            HomeDashboard homeDashboard = new HomeDashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.homepanel.Controls.Add(homeDashboard);
            homeDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;

            
            this.homepanel.Controls.Clear();
            Trackerdashboard trackerDashbboard = new Trackerdashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.homepanel.Controls.Add(trackerDashbboard);
            trackerDashbboard.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            this.homepanel.Controls.Clear();

           infodashboard Infodashboard = new infodashboard
           {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.homepanel.Controls.Add(Infodashboard);
            Infodashboard.Show();
        }
    }
}
