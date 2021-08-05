using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Day3Ex1._1
{
    public partial class Form1 : Form
    {
        List<Employee> empList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empList = new List<Employee>();
            empList.Add(new Employee { ID = 1, FirstName = "Hung", LastName = "Le" });
            empList.Add(new Employee { ID = 2, FirstName = "Yoda", LastName = "Le" });
            empList.Add(new Employee { ID = 3, FirstName = "Froda", LastName = "Le" });
            empList.Add(new Employee { ID = 4, FirstName = "Hodor", LastName = "Le" });
            empList.Add(new Employee { ID = 5, FirstName = "Yogurt", LastName = "Le" });
            
            gridEmpList.DataSource = empList;
            
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty && txtFN.Text != string.Empty && txtLN.Text != string.Empty)
            {
                Employee newEmp = new Employee();
                newEmp.ID = Int32.Parse(txtID.Text);
                newEmp.FirstName = txtFN.Text;
                newEmp.LastName = txtLN.Text;
                empList.Add(newEmp);
            }
            gridEmpList.DataSource = null;
            gridEmpList.DataSource = empList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelID.Text != string.Empty)
            {
                Employee deleteEmp = empList.FirstOrDefault(d => d.ID == Int32.Parse(txtDelID.Text));
                empList.Remove(deleteEmp);
            }
            RefreshDelete();
            gridEmpList.DataSource = null;
            gridEmpList.DataSource = empList;
        }

        private void RefreshDelete()
        {
            txtDelID.Clear();
            gridEmpList.DataSource = null;
            gridEmpList.DataSource = empList;
        }

    }
}
