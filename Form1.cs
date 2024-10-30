using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace digitalPersonaApp
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        public Form1()
        {
            InitializeComponent();
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Action(delegate ()
            {
                StatusText.Text = message;
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (Capturer != null)
                {
                    Capturer.EventHandler = this;
                    MakeReport("Press start capture to start scanning.");

                    // Set SizeMode to CenterImage
                    fImage.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    MakeReport("Cannot initiate capture operation.");
                }

            }
            catch
            {
                MessageBox.Show("Cant take this feeling anymore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger reader was touch.");
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            Process(Sample);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {
                MakeReport("The quality of the fingerprint sample is good");
            }
            else
            {
                MakeReport("The quality of the fingerprint sample is poor");
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);

            return bitmap;
        }

        private void DrawPicture(Bitmap bitmap)
        {
            fImage.Image = new Bitmap(bitmap, fImage.Size);
            //fImage.Image = bitmap;
        }

        private void SaveFingerprint(Bitmap bitmap)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PNG Image|*.png";
                    saveDialog.Title = "Save Fingerprint Image";
                    saveDialog.DefaultExt = "png";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MakeReport("Fingerprint image saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MakeReport($"Error saving image: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fImage.Image != null)
            {
                SaveFingerprint((Bitmap)fImage.Image);
            }
            else
            {
                MakeReport("No fingerprint image to save.");
            }
        }




        private void fImage_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Using the fingerprint reader, scan your fingerprint");
                }
                catch {
                    MakeReport("Cant initiate capture");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
    }
