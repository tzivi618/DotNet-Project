
namespace UI
{
    public partial class ThankYouForm : Form
    {
        public ThankYouForm()
        {
            InitializeComponent();
            this.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private Label thankYouLabel;

        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(619, 106);
            label1.TabIndex = 0;
            label1.Text = "תודה ולהתראות";
            // 
            // ThankYouForm
            // 
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.יפה_נוף;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(801, 462);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ThankYouForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
    }
}

