using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomarovMA.Sprint7.V15.Lib;
namespace Tyuiu.KomarovMA.Sprint7.V15
{
    public partial class FormAboutPeople : Form
    {
        public FormAboutPeople()
        {
            InitializeComponent();
        }
        public string[,] valueArray;
        int FIO;
        DataService ds = new DataService();
        private void labelAvgTime_SIA_Click(object sender, EventArgs e)
        {

        }
       
        

        private void chartDohod_KMA_Click(object sender, EventArgs e)
        {

        }

        private void FormAboutPeople_Load(object sender, EventArgs e)
        {
            textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(valueArray));
            textBoxMinDohod_KMA.Text = Convert.ToString(ds.MinDohod(valueArray));
            textBoxMaxDohod_KMA.Text = Convert.ToString(ds.MaxDohod(valueArray));
            textBoxSummDohod_KMA.Text = Convert.ToString(ds.SummDohod(valueArray));
            for (int i = 0; i < valueArray.GetLength(0); i++)
            {
                try
                {

                    chartDohod_KMA.Series[0].Points.AddXY(valueArray[i, 1], Convert.ToInt32(valueArray[i, 5]));

                }
                catch { chartDohod_KMA.Series[0].Points.AddXY(valueArray[i, 1], 0); }

            }

        }
    }
    }

