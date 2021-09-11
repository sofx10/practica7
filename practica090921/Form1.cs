using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica090921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstname", "NOMBRE");
            dgData.Columns.Add("lastname", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("nacionalidad", "NACIONALIDAD");

            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName,
                student.age, student.nacionalidad);

            }

        }
        private List<Student> selectAllData()
        {
            List<Student> result = (
                from student in Student.GetStudents()
                select new Student()
                {
                    idStudent = student.idStudent,
                    firstName = student.firstName,
                    lastName = student.lastName,
                    age = student.age,
                    nacionalidad = student.nacionalidad
                }
                ).ToList();

            return result;

        }

    }
}
        