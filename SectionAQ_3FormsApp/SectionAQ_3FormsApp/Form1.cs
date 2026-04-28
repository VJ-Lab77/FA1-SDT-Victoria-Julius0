using System;
using System.Windows.Forms;

namespace SectionAQ_3FormsApp
{
    public partial class Form1 : Form
    {
        private ListBox listLanguages;
        private TextBox textLanguage;
        private Label label2;
        private Timer timer1;

        public Form1()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "My Favourite Programming Languages";
            this.Size = new System.Drawing.Size(450, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            
            listLanguages = new ListBox
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(400, 200)
            };

            
            Label lblEnter = new Label
            {
                Text = "Enter Programming Language:",
                Location = new System.Drawing.Point(20, 240),
                Size = new System.Drawing.Size(180, 20)
            };

            
            textLanguage = new TextBox
            {
                Location = new System.Drawing.Point(20, 265),
                Size = new System.Drawing.Size(400, 20)
            };

            
            Button buttonAdd = new Button
            {
                Text = "Add Language",
                Location = new System.Drawing.Point(20, 300),
                Size = new System.Drawing.Size(190, 35),
                BackColor = System.Drawing.Color.LightBlue,
                FlatStyle = FlatStyle.Flat
            };
            buttonAdd.Click += ButtonAdd_Click;

            
            Button buttonRemove = new Button
            {
                Text = "Remove Selected",
                Location = new System.Drawing.Point(230, 300),
                Size = new System.Drawing.Size(190, 35),
                BackColor = System.Drawing.Color.LightCoral,
                FlatStyle = FlatStyle.Flat
            };
            buttonRemove.Click += ButtonRemove_Click;

            // Create Date/Time Label 
            label2 = new Label
            {
                Location = new System.Drawing.Point(20, 360),
                Size = new System.Drawing.Size(400, 60),
                Font = new System.Drawing.Font("Arial", 10),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            //Controls
            this.Controls.Add(listLanguages);
            this.Controls.Add(lblEnter);
            this.Controls.Add(textLanguage);
            this.Controls.Add(buttonAdd);
            this.Controls.Add(buttonRemove);
            this.Controls.Add(label2);

            // languages
            listLanguages.Items.Add("C#");
            listLanguages.Items.Add("Java");
            listLanguages.Items.Add("Python");
            listLanguages.Items.Add("JavaScript");
            listLanguages.Items.Add("Go");  

            // Timer
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            // Set date/time
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            label2.Text = $"Date: {DateTime.Now:yyyy-MM-dd}\nTime: {DateTime.Now:HH:mm:ss}";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string newLanguage = textLanguage.Text.Trim();

            if (string.IsNullOrEmpty(newLanguage))
            {
                MessageBox.Show("Please provide a language!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listLanguages.Items.Contains(newLanguage))
            {
                MessageBox.Show($"'{newLanguage}' already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listLanguages.Items.Add(newLanguage);
            textLanguage.Clear();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listLanguages.Items.Remove(listLanguages.SelectedItem);
        }

        

        
    }
}