namespace ImageClassifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null)
            {
                var modelInput = new ImageClassifier.ModelInput()
                {
                    ImageSource = File.ReadAllBytes(pictureBox1.ImageLocation)
                };
                var sortedPredictions = ImageClassifier.PredictAllLabels(modelInput);
                var result = sortedPredictions.First();
                var percentage = Math.Truncate(sortedPredictions.First().Value * 10000 )/ 100;
                var text = result.Key.ToLower().ToCharArray();
                text[0] = text[0].ToString().ToUpper().ToCharArray()[0];
                var outputText = $"Guess: {new string(text)}, Accuracy: {percentage}%";
                textBox1.Text = outputText;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
