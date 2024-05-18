using SendTimeCalculator.Logic;
using System.Globalization;


namespace SendTimeCalculator
{
    public partial class MainForm : Form
    {
        public string TextboxContent => (string)importTextBox.Text;
        private System.Windows.Forms.Timer timer;
        private bool hasBeeped = false; // Add this line

        public MainForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            (string sendTime, string arrivalTime) = ToxicDonutSnipe.calculateSendTime();
            outputBox.Text = sendTime;
            outputArrivalText.Text = arrivalTime; // Display the arrival time
            timer.Start();
            hasBeeped = false; // Reset the flag when a new send time is calculated
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime sendTime;
            if (DateTime.TryParseExact(outputBox.Text, "yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture, DateTimeStyles.None, out sendTime))
            {
                TimeSpan remainingTime = sendTime - DateTime.Now;

                if (remainingTime <= TimeSpan.Zero)
                {
                    timer.Stop();
                    remainingTimeLabel.Text = "00:00:00.000";

                    // Calculate the next send time
                    calculateButton_Click(sender, e);
                }
                else
                {
                    remainingTimeLabel.Text = remainingTime.ToString(@"hh\:mm\:ss\.fff");

                    if (remainingTime.TotalSeconds <= 10 && !hasBeeped)
                    {
                        Console.Beep();
                        hasBeeped = true; // Set the flag to true after the beep sound is made
                    }
                }
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
