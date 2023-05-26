using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace CombEvenOddSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        string copyFileName1 = "CombSort.txt";
        string copyFileName2 = "EvenSort.txt";
        int swapping = 0; int comprassion = 0; int swapping1 = 0; int comprassion2 = 0;
        public List<double> numb = new List<double>();

        private void DrawTimeSize(double size1,double time1, double time2, GraphPane pane)
        {
            Random rnd = new Random ();
            pane.CurveList.Clear ();
            PointPairList list = new PointPairList ();
            PointPairList list2 = new PointPairList ();
            double ymax = ( time1 + 10 + time2 + 10) / 2;
            // Заполняем список точек
            list.Add (size1, time1);
            list2.Add (size1, time2);

            // Создадим кривую
            pane.AddCurve ("", list, Color.Blue, SymbolType.None);
            pane.AddCurve ("", list2, Color.Red, SymbolType.None);
            
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Cleaning();
            button2.Enabled = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog1.FileName);
                    CheckingAllNumber(openFileDialog1.FileName);
                    button2.Enabled = true;
                    //создание копии файла
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        
                        // Открыть два новых файла для записи
                        using (StreamWriter writer1 = new StreamWriter(copyFileName1))
                        using (StreamWriter writer2 = new StreamWriter(copyFileName2))
                        {
                            // Считывать поочередно каждую строку из исходного файла и записывать ее в оба новых файла
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                writer1.WriteLine(line);
                                writer2.WriteLine(line);
                            }
                        }
                    }
                    textBox1.Text = openFileDialog1.FileName;
                    textBox2.Text = fileContent;
                    
                    
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Ошибка чтения файла: " + ex.Message);
                }
            }
        }
        private bool CheckingAllNumber(string fileName)
        {
            bool isDigitOnly = true;
            using (StreamReader reader = new StreamReader(fileName))
            {
                int nextChar = reader.Read();
                while (nextChar != -1)
                {
                    if (!char.IsDigit((char)nextChar) && nextChar != ' ' && nextChar != '.')
                    {
                        isDigitOnly = false;
                        break;
                    }
                    nextChar = reader.Read();
                }
            }
            if (!isDigitOnly)
            {
                MessageBox.Show("Файл содержит недопустимые символы.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<double> preStart(string FileName)
        {
            //
            string content = File.ReadAllText(copyFileName1).Replace("\r\n", "");
            string[] texfile = content.Split(new string[] { "\n", " ", "\0" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string Line in texfile)
            {
                double[] temp = Line.Split(new char[] { '\n', ' ', '\r' }).Select(double.Parse).ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    numb.Add(temp[i]);
                }
            }

            return numb;
        }

        private void start_Click(object sender, EventArgs e)
        {
            List<double> numb= preStart(copyFileName1);
            
            swapping = 0; comprassion = 0;
            var Start = DateTime.Now;
            List<double> result = сombSort(numb);
            var spendtime = DateTime.Now - Start;
            
            
            textBox3.Text = "";
            foreach (int n in result)
            {
                textBox3.Text += n.ToString() + "\r\n";
            } 
            label5.Text = "Время:   " + spendtime.TotalMilliseconds + " мс";
            label6.Text = "Кол-во перестановок: " + swapping.ToString();;
            label7.Text = "Кол-во сравнений: " + comprassion.ToString();
            var spendTimeForOne = spendtime;
            var size =
   
            numb = preStart(copyFileName2);
            swapping = 0; comprassion = 0;
            Start = DateTime.Now;
            result = OESort(numb);
            spendtime = DateTime.Now - Start;
            textBox4.Text = "";
            foreach (int n in result)
            {
                textBox4.Text += n.ToString() + "\r\n";
            }
            label10.Text = "Время:   " + spendtime.TotalMilliseconds + " мс";
            label9.Text = "Кол-во перестановок: " + swapping.ToString();;
            label8.Text = "Кол-во сравнений: " + comprassion.ToString();
            MasterPane masterPane = zedGraphControl1.MasterPane;
            masterPane.PaneList.Clear ();
            GraphPane pane = new GraphPane ();
            DrawTimeSize((double)result.Count, spendTimeForOne.TotalMilliseconds, spendtime.TotalMilliseconds, pane);
            masterPane.Add (pane);
            zedGraphControl1.AxisChange ();
            zedGraphControl1.Invalidate ();
            
            
        }
        
        private void Cleaning()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            numb.Clear();
            label5.Text = "Время:   ";
            label6.Text = "Кол-во перестановок:";
            label7.Text = "Кол-во сравнений:";
            label10.Text = "Время:   ";
            label9.Text = "Кол-во перестановок:";
            label8.Text = "Кол-во сравнений:";

        }
        public  List<double> сombSort( List<double> array)
        {
            int length = array.Count;
            int gap = length;
            double shrink = 1.3;
            bool sorted = false;

            while (!sorted)
            {
                gap = (int)(gap / shrink);
                if (gap <= 1)
                {
                    comprassion++;
                    gap = 1;
                    sorted = true;
                }

                int i = 0;
                while (i + gap < length)
                {
                    if (array[i] > array[i + gap])
                    {
                        comprassion++;
                        swapping++;
                        double temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        sorted = false;
                    }
                    i++;
                }
            }

            return array;
        }
        
        public List<double> OESort(List<double> array)
        {
            bool sorted = false;

            while (sorted == false)
            {
                sorted = true;

                for (int i = 1; i <= array.Count - 2; i = i + 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        comprassion2++;
                        swapping1++;
                        double temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
                
            }

            return array;
        }
    }
}