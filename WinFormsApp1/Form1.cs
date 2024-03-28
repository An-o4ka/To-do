using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            TaskDelButton.Enabled = false; // ������ ������ �������� ���������� ��� �������

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TaskDelButton_Click(object sender, EventArgs e)
        {
            if (cpicok.SelectedItem != null)
            {
                string selectedTask = cpicok.SelectedItem.ToString();
                cpicok.Items.Remove(cpicok.SelectedItem);

                // �������� ��������� ������ �� �����
                RemoveTaskFromFile("file.txt", selectedTask);
            }

        }
        private void RemoveTaskFromFile(string filePath, string taskToRemove)
        {
            List<string> tasks = new List<string>(File.ReadAllLines(filePath));
            tasks.Remove(taskToRemove);

            File.WriteAllLines(filePath, tasks.ToArray());
        }
       


        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e) //��������� ������ �� file.txt � ��� �� �����������
        {
           
            string filePath = "file.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (!cpicok.Items.Contains(line))
                    {
                        cpicok.Items.Add(line);
                    }
                }
            }
            else
            {
                MessageBox.Show("���� �� ������.");
            }

        }

        private void cpicok_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool allChecked = true;
            for (int i = 0; i < cpicok.Items.Count; i++)
            {
                if (!cpicok.GetItemChecked(i))
                {
                    allChecked = false;
                    break;
                }
            }

            if (allChecked)
            {
                MessageBox.Show("�� ��������� ��� ������, ����������� � ��� �� ����!", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TaskDelButton.Enabled = true; // ��������� ������ �������� ��� ������ ��������
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cpicok.Items.Clear();
        }

        private void button2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e) //��� �� ��������� ������� ��� enter � ������ ����� � file.txt
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ��������� ����� �� TextBox � ListBox
                cpicok.Items.Add(textBox1.Text);
                // ��������� ����� � ���� file.txt
                SaveUniqueTextToFile("file.txt", textBox1.Text);
                textBox1.Clear(); // ������� TextBox
            }
        }
        private void SaveUniqueTextToFile(string filePath, string text) //��� �������� ����� � file.txt �� ����������� ���������� ������
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                string existingText = File.ReadAllText(filePath);
                if (!existingText.Contains(text))
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(text);
                    }
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text[0] == ' ')
            {
                MessageBox.Show("����� �� ������ ���������� � �������!");
                textBox1.Text = textBox1.Text.TrimStart(); //������� ������ � ������ ������
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
