using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace studentApp {
    public partial class studentForm : Form
    {
        public StudentDatabase _student;

        public studentForm()
        {
            InitializeComponent();

            _student = new StudentDatabase();
            _student.Initialize();

            Studentdate.DataSource = _student.Atest.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            List<Atest> _Find = _student.Atest.Where(x => x.Name.ToLower().Contains(textBox1.Text.ToLower()) ).ToList();
            Studentdate.DataSource = _Find;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e) {
            
            string a = comboBox1.Text;
                List<Atest> _MeasureUnits = _student.Atest.Where(x => x.Atesst.ToString() ==a ).ToList(); ;
                Studentdate.DataSource = _MeasureUnits;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
         Studentdate.DataSource = _student.Atest.ToList();
            textBox1.Text = "";
            comboBox1.Text = "";
            //ААА
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            List<Atest> _Temp = _student.Atest.OrderByDescending(x => x.Semester ).ToList();
         Studentdate.DataSource = _Temp;
        }

        
        private void button4_Click(object sender, System.EventArgs e)
        {
            List<Atest> _Temp = _student.Atest.OrderBy(x => x.Semester).ToList();
            Studentdate.DataSource = _Temp;
        }
    }
    
}