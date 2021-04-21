using CafeLib.Models;
using CafeLib.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public RepositoryFactory data;
        readonly IRepository<Employee> employeeRepository;
        readonly IRepository<Driver> driverRepository;

        public Form1()
        {
            data = Client.CreateData();
            employeeRepository = data.GetEmpRepository();
            driverRepository = data.GetDrivRepository();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeRepository.Data;
            dataGridView2.DataSource = driverRepository.Data;

        }
        private void Refresh_All()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = employeeRepository.Data;
            dataGridView1.DataSource = bs;
            BindingSource bss = new BindingSource();
            bss.DataSource = driverRepository.Data;
            dataGridView2.DataSource = bss;
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void RefreshEmp()
        {
            employeeRepository.Data.Clear();
            employeeRepository.ReadFromStorage();
            Refresh_All();
        }

        private void RefreshDr()
        {
            driverRepository.Data.Clear();
            driverRepository.ReadFromStorage();
            Refresh_All();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = employeeRepository.Data[0].stars;
            int index = 0;
            for (int i = 0; i < employeeRepository.Data.Count; i++)
            {
                if (employeeRepository.Data[i].stars > max)
                {
                    max = employeeRepository.Data[i].stars;
                    index = i;
                }
            }

    
            MessageBox.Show(employeeRepository.Data[index].ToString(), "Top Employee");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((1 + employeeRepository.Data[rowIndex].stars) / 2);

                employeeRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((5 + employeeRepository.Data[rowIndex].stars) / 2);

                employeeRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((4 + employeeRepository.Data[rowIndex].stars) / 2);

                employeeRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((3 + employeeRepository.Data[rowIndex].stars) / 2);

                employeeRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((2 + employeeRepository.Data[rowIndex].stars) / 2);

                employeeRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int max = driverRepository.Data[0].stars;
            int index = 0;
            for (int i = 0; i < driverRepository.Data.Count; i++)
            {
                if (driverRepository.Data[i].stars > max)
                {
                    max = driverRepository.Data[i].stars;
                    index = i;
                }
            }


            MessageBox.Show(driverRepository.Data[index].ToString(), "Top Driver");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((1 + driverRepository.Data[rowIndex].stars) / 2);

                driverRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((2 + driverRepository.Data[rowIndex].stars) / 2);

                driverRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((3 + driverRepository.Data[rowIndex].stars) / 2);

                driverRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((4 + driverRepository.Data[rowIndex].stars) / 2);

                driverRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                short NewRating = Convert.ToInt16((5 + driverRepository.Data[rowIndex].stars) / 2);

                driverRepository.Data[rowIndex].stars = NewRating;

                Refresh_All();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
                RefreshEmp();
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
                RefreshDr();

        }
    }
}



   
