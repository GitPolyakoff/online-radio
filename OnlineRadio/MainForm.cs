using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace OnlineRadio
{
    public partial class MainForm : Form
    {
        private List<RadioStation> radioStations = new List<RadioStation>();
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFile;

        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            pictureBox1.Image = Properties.Resources.Z23b;
            pictureBox1.Visible = false;

            radioStations = LoadRadioStations();

            codeeloComboBox1.DataSource = radioStations;
            codeeloComboBox1.DisplayMember = "Name";
            codeeloComboBox1.ValueMember = "StreamUrl";

            waveOutDevice = new WaveOut();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Dispose();
            }

            waveOutDevice.Dispose();

            SaveRadioStations(radioStations);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            int volume = trackBarVolume.Value;
            float volumeLevel = (float)volume / 100f;

            if (waveOutDevice != null && audioFile != null)
            {
                waveOutDevice.Volume = volumeLevel;
            }
            codeeloCircularProgressBar1.Value = trackBarVolume.Value;

            if (trackBarVolume.Value == 0 && codeeloToggleButton1.Checked)
                pictureBox1.Visible = false;
            if (trackBarVolume.Value > 0 && codeeloToggleButton1.Checked)
                pictureBox1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            waveOutDevice = new WaveOut();

            if (waveOutDevice != null)
            {
                trackBarVolume.Value = (int)(waveOutDevice.Volume * 100);
            }
            codeeloCircularProgressBar1.Value = trackBarVolume.Value;
        }

        private void SaveRadioStations(List<RadioStation> stations)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("stations.txt"))
                {
                    foreach (RadioStation station in stations)
                    {
                        sw.WriteLine(station.Name + "," + station.StreamUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private List<RadioStation> LoadRadioStations()
        {
            List<RadioStation> stations = new List<RadioStation>();
            try
            {
                using (StreamReader sr = new StreamReader("stations.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            RadioStation station = new RadioStation
                            {
                                Name = parts[0],
                                StreamUrl = parts[1]
                            };
                            stations.Add(station);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return stations;
        }

        private void codeeloToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (codeeloToggleButton1.Checked)
            {
                pictureBox1.Visible = true;

                if (codeeloComboBox1.SelectedIndex != -1)
                {
                    if (audioFile != null)
                    {
                        audioFile.Dispose();
                    }

                    RadioStation selectedStation = (RadioStation)codeeloComboBox1.SelectedItem;

                    audioFile = new AudioFileReader(selectedStation.StreamUrl);

                    waveOutDevice.Init(audioFile);
                    waveOutDevice.Play();
                }
                else
                {
                    MessageBox.Show("Выберите радиостанцию для воспроизведения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pictureBox1.Visible = false;

                if (codeeloComboBox1.SelectedIndex != -1)
                {
                    waveOutDevice.Pause();
                }
                else
                {
                    MessageBox.Show("Выберите радиостанцию для приостановки воспроизведения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RadioStation newStation = new RadioStation
                {
                    Name = addForm.StationName,
                    StreamUrl = addForm.StreamUrl
                };
                radioStations.Add(newStation);

                codeeloComboBox1.DataSource = null;
                codeeloComboBox1.DataSource = radioStations;
                codeeloComboBox1.DisplayMember = "Name";
                codeeloComboBox1.ValueMember = "StreamUrl";
            }
        }
    }
}