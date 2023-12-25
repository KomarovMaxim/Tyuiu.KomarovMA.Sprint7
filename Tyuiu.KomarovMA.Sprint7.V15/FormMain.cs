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
using System.IO;
namespace Tyuiu.KomarovMA.Sprint7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows = 0;
        static int columns = 8;
        static string openFilePath = "";
        static string[,] arrayValues = new string[rows, columns];
        static int newID = 0;
        static bool wasTrue = false;
        static string[] filters = new string[7];
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string filePath)
        {
            try
            {
                string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));
                fileData = fileData.Replace("\n", "\r");
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    rows = lines.Length;
                    columns = lines[0].Split(';').Length;

                    arrayValues = new string[rows, columns];

                    for (int r = 0; r < rows; r++)
                    {
                        string[] line_r = lines[r].Split(';');
                        for (int c = 0; c < columns; c++)
                        {
                            arrayValues[r, c] = line_r[c];
                        }
                    }
                }
                catch
                {
                    rows = 0;
                    columns = 8;
                    arrayValues = new string[rows, columns];
                }
            }
            catch { }

            return arrayValues;
        }
        private void UpdateTable()
        {
            dataGridViewTable_KMA.Rows.Clear();
            for (int r = 0; r < rows; r++)
            {
                dataGridViewTable_KMA.Rows.Add();
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewTable_KMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }
        
        private void Filter()
        {
            dataGridViewTable_KMA.Rows.Clear();
            for (int i = 0; i < rows; i++)
            {

                try
                {
                    if ((Convert.ToInt32(arrayValues[i, 5]) >= Convert.ToInt32(filters[0]) || string.IsNullOrWhiteSpace(filters[0]) || Convert.ToInt32(filters[0]) == 0) && (Convert.ToInt32(arrayValues[i, 5]) <= Convert.ToInt32(filters[1]) || string.IsNullOrWhiteSpace(filters[1]) || Convert.ToInt32(filters[1]) == 0) && (arrayValues[i, 4] == filters[3] || string.IsNullOrWhiteSpace(filters[3])))
                    {



                        dataGridViewTable_KMA.Rows.Add(arrayValues[i, 0]);
                        for (int k = 1; k < columns; k++)
                        {
                            dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                        }




                    }
                }

                catch
                {
                    dataGridViewTable_KMA.Rows.Add(arrayValues[i, 0]);
                    for (int k = 1; k < columns; k++)
                    {
                        dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                    }
                }
                
            }
        }

        private void buttonAdd_KMA_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KMA.Rows.Add();
            buttonAboutPeople_KMA.Enabled = true;
            buttonDelete_KMA.Enabled = true;
            wasTrue = true;
            rows++;

            for (int i = 1; i < columns; i++)
            {
                dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[i].Value = "";
            }

            for (int i = 0; i < rows - 1; i++)
            {
                newID = Math.Max(Convert.ToInt32(arrayValues[i, 0]), newID);
            }
            newID++;
            dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[0].Value = Convert.ToString(newID);
            string[,] tempValues = arrayValues;
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = tempValues[r, c];
                }
            }
            for (int с = 0; с < columns; с++)
                arrayValues[rows - 1, с] = Convert.ToString(dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[с].Value);
            textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(arrayValues));
        }

        private void groupBoxFilters_SIA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDelete_KMA_Click(object sender, EventArgs e)
        {
            string[] tempArray = new string[dataGridViewTable_KMA.SelectedRows.Count];
            int cnt = 0;
            foreach (DataGridViewRow item in this.dataGridViewTable_KMA.SelectedRows)
            {
                tempArray[cnt] = Convert.ToString(dataGridViewTable_KMA.Rows[item.Index].Cells[0].Value);
                dataGridViewTable_KMA.Rows.RemoveAt(item.Index);
                cnt++;
            }
            UpdateTable();

                for (int i = rows - 1; i >= 0; i--)
                {
                    for (int j = 0; j < tempArray.GetLength(0); j++)
                    {
                        try
                        {
                            if (Convert.ToString(dataGridViewTable_KMA.Rows[i].Cells[0].Value) == tempArray[j])
                            {
                                dataGridViewTable_KMA.Rows.RemoveAt(i);
                                rows--;
                            }
                        }
                        catch
                        {
                            if (Convert.ToString(dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[0].Value) == tempArray[j])
                            {
                                dataGridViewTable_KMA.Rows.RemoveAt(dataGridViewTable_KMA.Rows.Count - 1);
                                rows--;
                            }
                        }
                    }

                }
                arrayValues = new string[rows, columns];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                    arrayValues[r, c] = Convert.ToString(dataGridViewTable_KMA.Rows[r].Cells[c].Value);

                    }
                }
                newID = 0;
                textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(arrayValues));
                textBoxMinDohod_KMA.Text = Convert.ToString(ds.MinDohod(arrayValues));
                textBoxMaxDohod_KMA.Text = Convert.ToString(ds.MaxDohod(arrayValues));
                textBoxSummDohod_KMA.Text = Convert.ToString(ds.SummDohod(arrayValues));
            Filter();
        }

        private void ToolStripMenuItemNewTable_KMA_Click(object sender, EventArgs e)
        {
            
                
                
                    rows = 0;
                    columns = 8;
                    openFilePath = "";
                    arrayValues = new string[rows, columns];
                    newID = 0;
                    dataGridViewTable_KMA.Rows.Clear();
                    buttonAboutPeople_KMA.Enabled = false;
                    buttonDelete_KMA.Enabled = false;
                    wasTrue = false;
                    comboBoxPos_KMA.Text = string.Empty;
                    filters = new string[7];
                    textBoxAmountPeople_KMA.Text = null;
                    textBoxMinDohod_KMA.Text = null;
                    textBoxMaxDohod_KMA.Text = null;
                    textBoxSummDohod_KMA.Text = null;
                
            
            
            }

        private void buttonAboutPeople_KMA_Click(object sender, EventArgs e)
        {
            FormAboutPeople formRoute = new FormAboutPeople();
            foreach (DataGridViewRow item in this.dataGridViewTable_KMA.SelectedRows)
            {
                try
                {
                    formRoute.Text = Convert.ToString(dataGridViewTable_KMA.Rows[item.Index].Cells[2].Value);
                }
                catch { }
            }
            formRoute.valueArray = arrayValues;
            formRoute.Show();
        }

        private void buttonAddVehicle_SIA_Click(object sender, EventArgs e)
        {
            dataGridViewTable_KMA.Rows.Add();
            buttonAboutPeople_KMA.Enabled = true;
            buttonDelete_KMA.Enabled = true;
            wasTrue = true;
            rows++;

            for (int i = 1; i < columns; i++)
            {
                dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[i].Value = "";
            }

            for (int i = 0; i < rows - 1; i++)
            {
                newID = Math.Max(Convert.ToInt32(arrayValues[i, 0]), newID);
            }
            newID++;
            dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[0].Value = Convert.ToString(newID);
            string[,] tempValues = arrayValues;
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = tempValues[r, c];
                }
            }
            for (int с = 0; с < columns; с++)
                arrayValues[rows - 1, с] = Convert.ToString(dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.Rows.Count - 1].Cells[с].Value);
            textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(arrayValues));
        }

        private void textBoxSearch_KMA_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTable_KMA.Rows.Clear();
            string text = textBoxSearch_KMA.Text;
            if (text != "")
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (arrayValues[i, j].Contains(text))
                        {
                            foreach (DataGridViewRow row in dataGridViewTable_KMA.Rows)
                            {
                                if (row.Cells[0].Value.ToString().Contains(arrayValues[i, 0]))
                                {
                                    dataGridViewTable_KMA.Rows.Remove(row);
                                }
                            }
                            dataGridViewTable_KMA.Rows.Add(arrayValues[i, 0]);
                            for (int k = 1; k < columns; k++)
                            {
                                dataGridViewTable_KMA.Rows[dataGridViewTable_KMA.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                            }
                        }
                    }
                }
            }
            else
            {
                UpdateTable();
            }

        }

        private void ToolStripMenuItemOpen_KMA_Click(object sender, EventArgs e)
        {

            openFileDialogTable_KMA.ShowDialog();
            openFilePath = openFileDialogTable_KMA.FileName;

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewTable_KMA.ColumnCount = columns;
            dataGridViewTable_KMA.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewTable_KMA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            if (rows > 0)
            {
                buttonAboutPeople_KMA.Enabled = true;
                buttonDelete_KMA.Enabled = true;
                wasTrue = true;
                textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(arrayValues));
                textBoxMinDohod_KMA.Text = Convert.ToString(ds.MinDohod(arrayValues));
                textBoxMaxDohod_KMA.Text = Convert.ToString(ds.MaxDohod(arrayValues));
                textBoxSummDohod_KMA.Text = Convert.ToString(ds.SummDohod(arrayValues));
            }

        }

        

        private void ToolStripMenuItemSaveAs_KMA_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveTo_KMA.FileName = "База Данных Работников.csv";
            saveFileDialogSaveTo_KMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogSaveTo_KMA.ShowDialog();

            openFilePath = saveFileDialogSaveTo_KMA.FileName;
            FileInfo fileInfo = new FileInfo(openFilePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(openFilePath);
            }
            string str = "";
            dataGridViewTable_KMA.Sort(dataGridViewTable_KMA.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTable_KMA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewTable_KMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(openFilePath, str + Environment.NewLine, Encoding.GetEncoding(1251)); // букафки русские
                str = "";
            }
            Filter();
        }

        private void labelMaxDohod_KMA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSummDohod_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTable_KMA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < dataGridViewTable_KMA.Rows.Count; j++)
                {
                    if (Convert.ToString(dataGridViewTable_KMA.Rows[j].Cells[0].Value) == arrayValues[i, 0])
                    {
                        
                        for (int k = 1; k < columns; k++)
                        {
                            arrayValues[i, k] = Convert.ToString(dataGridViewTable_KMA.Rows[j].Cells[k].Value);
                        }
                    }
                    if (!comboBoxPos_KMA.Items.Contains(Convert.ToString(dataGridViewTable_KMA.Rows[j].Cells[4].Value)) && !(string.IsNullOrWhiteSpace(Convert.ToString(dataGridViewTable_KMA.Rows[j].Cells[4].Value))))
                    {
                        comboBoxPos_KMA.Items.Add(Convert.ToString(dataGridViewTable_KMA.Rows[j].Cells[4].Value));
                    }    
                }
            textBoxAmountPeople_KMA.Text = Convert.ToString(ds.People(arrayValues));
            textBoxMinDohod_KMA.Text = Convert.ToString(ds.MinDohod(arrayValues));
            textBoxMaxDohod_KMA.Text = Convert.ToString(ds.MaxDohod(arrayValues));
            textBoxSummDohod_KMA.Text = Convert.ToString(ds.SummDohod(arrayValues));
            
        }

        private void ToolStripMenuItemUserGuide_KMA_Click(object sender, EventArgs e)
        {
            FormManual_KMA formManual = new FormManual_KMA();
            formManual.Show();
        }

        private void ToolStripMenuItemAbout_KMA_Click(object sender, EventArgs e)
        {
            FormAboutProgramm formAbout = new FormAboutProgramm();
            formAbout.Show();
        }

        private void comboBoxPos_KMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters[3] = Convert.ToString(comboBoxPos_KMA.Text);
            Filter();

        }

        private void buttonResetFilters_KMA_Click(object sender, EventArgs e)
        {
            comboBoxPos_KMA.Text = string.Empty;
            numericUpDownMinDohod_KMA.Value = 0;
            numericUpDownMaxDohod_KMA.Value = 0;
            UpdateTable();
        }




        private void numericUpDownMinDohod_KMA_ValueChanged(object sender, EventArgs e)
        {
            filters[0] = Convert.ToString(numericUpDownMinDohod_KMA.Value);
            Filter();
        }

        private void numericUpDownMaxDohod_KMA_ValueChanged(object sender, EventArgs e)
        {
            filters[1] = Convert.ToString(numericUpDownMaxDohod_KMA.Value);
            Filter();
        }
    }


}
