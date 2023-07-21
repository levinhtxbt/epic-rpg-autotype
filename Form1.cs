using AutoTyper.Domain;
using AutoTyper.Utils;
using Microsoft.Extensions.Logging;

namespace AutoTyper
{
    public partial class Form1 : Form
    {
        private bool _start = true;
        private readonly ILogger<Form1> _logger;

        public Form1(ILogger<Form1> logger)
        {
            InitializeComponent();
            _logger = logger;
            Program.LoggerSink.NewLogHandler += LogHandler;
        }

        private void LogHandler(object? sender, EventArgs e)
        {
            var log = ((LogEventArgs)e).Log;
            txtLogs.Text = $"{log.Timestamp.DateTime.ToString("HH:mm:ss")}: {log.MessageTemplate}\n{this.txtLogs.Text}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _logger.LogInformation("Application start");
            //cbxCommand1.Items.AddRange(CommandList.GetListCommands().ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {


            // Get the auto-typing text from the TextBox
            string autoTypeText = commandText1.Text;

            // Check if the user has entered text to auto-type
            if (string.IsNullOrEmpty(autoTypeText))
            {
                MessageBox.Show("Please enter the text to auto-type.");
                return;
            }

            _start = !_start;


            if (_start)
            {
                button1.Text = "Running";

                // Start the timer
                // Set the timer interval (in milliseconds) - 1000 ms = 1 second
                timerAutoType.Interval = 1000;
                timerAutoType.Start();

            }
            else
            {
                button1.Text = "Start";
                timerAutoType.Stop();
            }

        }



        private void timerAutoType_Tick_1(object sender, EventArgs e)
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Set the desired time to trigger the auto-typing (e.g., 2:00 PM)
            DateTime triggerTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 14, 0, 0);
            if (!_start)
            {
                timerAutoType.Stop();
                MessageBox.Show("Auto-typing completed.");
                return;
            }

            string autoTypeText = commandText1.Text;
            // Simulate keyboard input to auto-type the text
            SendKeys.SendWait(autoTypeText);

            // Check if the current time matches the trigger time
            //if (currentTime >= triggerTime)
            //{
            //    // Get the auto-typing text from the TextBox


            //    // Show a message to indicate that the auto-typing is complete
            //    MessageBox.Show("Auto-typing completed.");
            //}
        }



    }
}