using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBClassLib;

namespace E_JuiceDatabase
{
    public partial class Form1 : Form
    {
        List<Juice> listJuice;
        List<Flavor> listFlav;

        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            //List<> flavors = new List<>();
        }
        // save flavorings to list button
        private void SaveBtnFL_Click(object sender, EventArgs e)
        {
            const string delimit = ";";
            Flavor flavor = new Flavor();

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    if (FName.Text != "" && FAmount.Text != "")
                    {
                        flavor.Name = Convert.ToString(FName.Text);
                        flavor.Amount = Convert.ToDouble(FAmount.Text);
                        writer.WriteLine(flavor.Name + delimit + flavor.Amount);
                    }
                }
                FName.Text = string.Empty;
                FAmount.Text = string.Empty;
            }
        }
        // save juices to list button
        private void SaveBtnJ_Click(object sender, EventArgs e)
        {
            if (JNameBox.Text != "" && JAmountBox.Text != "" && Jconcentration.Text != "")
            {
                this.listJuice.Add(new Juice(this.JNameBox.Text, this.JAmountBox.Text, this.Jconcentration.Text));
            }
            JNameBox.Text = string.Empty;
            JAmountBox.Text = string.Empty;
            Jconcentration.Text = string.Empty;
        }

    }
}

 

            // Saving juice text file

            //const string delimit = ";";
            //Juice juice = new Juice(JNameBox.Text, JAmountBox.Text, Jconcentration.Text);

            //SaveFileDialog dialog = new SaveFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    using (StreamWriter writer = new StreamWriter(dialog.FileName))
            //    {
            //        if (JNameBox.Text != "" && JAmountBox.Text != "")
            //        {
            //            juice.Name = Convert.ToString(JNameBox.Text);
            //            juice.Amount = Convert.ToDouble(JAmountBox.Text);
            //            juice.Concentration = Convert.ToString(Jconcentration.Text);
            //            writer.WriteLine(juice.Name + delimit + juice.Amount + delimit + juice.Concentration);
            //        }

            //    }
            //    JNameBox.Text = string.Empty;
            //    JAmountBox.Text = string.Empty;
            //    Jconcentration.Text = string.Empty;