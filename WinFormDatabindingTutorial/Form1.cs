using System;
using System.Windows.Forms;

namespace WinFormDatabindingTutorial
{
    public partial class Form1 : Form
    {
        public TestClass testClass { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testClass = new TestClass
            {
                Message = "Altay naber?"
            };
            

            txt1.DataBindings.Add("Text", testClass, "Message", true, DataSourceUpdateMode.OnPropertyChanged);
            txt2.DataBindings.Add("Text", testClass, "Message", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl1.DataBindings.Add("Text", testClass, "Message", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(testClass.Message);
        }
    }

    public class TestClass
    {
        public string Message { get; set; }
    }
}
