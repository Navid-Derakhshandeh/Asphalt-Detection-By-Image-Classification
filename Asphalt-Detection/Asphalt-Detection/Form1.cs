using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Asphalt_DetectionML.Model;


namespace Asphalt_Detection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.ShowDialog();
            if(File.FileName != null)
            {
                pic.ImageLocation = File.FileName;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            MLContext mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load("MLModel.zip", out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Add input data
            var input = new ModelInput();

            input.ImageSource = pic.ImageLocation;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            string b = (result.Prediction);
            txtRes.Text = b;

        }
    }
}
