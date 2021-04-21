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

namespace AdminInterface
{
    public partial class Form1 : Form
    {
        public RepositoryFactory data;
        readonly IRepository<Employee> employeeRepository;
        readonly IRepository<Customer> customerRepository;
        readonly IRepository<Driver> driverRepository;

        public Form1()
        {
            data = Client.CreateData();
            employeeRepository = data.GetEmpRepository();
            customerRepository = data.GetCustRepository();
            driverRepository = data.GetDrivRepository();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridEmpAdd.DataSource = employeeRepository.Data;
            dataGridEmpEdit.DataSource = employeeRepository.Data;
            dataGridEmpDel.DataSource = employeeRepository.Data;
            dataGridDriverAdd.DataSource = driverRepository.Data;
            dataGridDriverEdit.DataSource = driverRepository.Data;
            dataGridDriverDel.DataSource = driverRepository.Data;
            dataGridCustAdd.DataSource = customerRepository.Data;
            dataGridCustEdit.DataSource = customerRepository.Data;
            dataGridCustDel.DataSource = customerRepository.Data;

        }

       
        private void ButtonAddEmp(object sender, EventArgs e)
        {
            var FirstName = BoxFirstNameAddEmp.Text;
            var SecondName = BoxSecNameAddEmp.Text;
            var Age = BoxAgeAddEmp.Text;
            var Stars = BoxStarsAddEmp.Text;

            BoxFirstNameAddEmp.Clear();
            BoxSecNameAddEmp.Clear();
            BoxAgeAddEmp.Clear();
            BoxStarsAddEmp.Clear();

            employeeRepository.Add(new Employee(FirstName, SecondName, Convert.ToInt16(Age), Convert.ToInt16(Stars)));

            Refresh_All();
        }
        int indexRow;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridEmpEdit.Rows[indexRow];

                textBox5.Text = row.Cells[0].Value.ToString();
                textBox8.Text = row.Cells[1].Value.ToString();
                textBox7.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();
            }
        }
        private void ButtonUpdateEmp(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridEmpEdit.Rows[indexRow];
            newDataRow.Cells[0].Value = textBox5.Text;
            newDataRow.Cells[1].Value = textBox8.Text;
            newDataRow.Cells[2].Value = textBox7.Text;
            newDataRow.Cells[3].Value = textBox6.Text;
        }
        private void Refresh_All()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = employeeRepository.Data;
            dataGridEmpAdd.DataSource = bs;
            dataGridEmpEdit.DataSource = bs;
            dataGridEmpDel.DataSource = bs;
            dataGridEmpAdd.Refresh();
            dataGridEmpEdit.Refresh();
            dataGridEmpDel.Refresh();
        }
        private void ButtonDelEmp(object sender, EventArgs e)
        {

            int rowIndex = dataGridEmpDel.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                employeeRepository.Data.RemoveAt(rowIndex);

                Refresh_All();
            }

        }



        private void Refresh_AllD()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = driverRepository.Data;
            dataGridDriverAdd.DataSource = bs;
            dataGridDriverEdit.DataSource = bs;
            dataGridDriverDel.DataSource = bs;
            dataGridDriverAdd.Refresh();
            dataGridDriverEdit.Refresh();
            dataGridDriverDel.Refresh();
        }
        private void ButtonAddDriver(object sender, EventArgs e)
        {
            var FirstName = textBox12.Text;
            var SecondName = textBox11.Text;
            var Age = textBox10.Text;
            var Stars = textBox9.Text;
            var Car = textBox17.Text;

            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox17.Clear();

            driverRepository.Add(new Driver(FirstName, SecondName, Convert.ToInt16(Age), Convert.ToInt16(Stars),Car));

            Refresh_AllD();
        }
        int indexRowD;
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowD = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridDriverEdit.Rows[indexRowD];

                textBox13.Text = row.Cells[0].Value.ToString();
                textBox14.Text = row.Cells[1].Value.ToString();
                textBox18.Text = row.Cells[2].Value.ToString();
                textBox16.Text = row.Cells[3].Value.ToString();
                textBox15.Text = row.Cells[4].Value.ToString();
            }
        }
        private void ButtonUpdateDriver(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridDriverEdit.Rows[indexRowD];
            newDataRow.Cells[0].Value = textBox13.Text;
            newDataRow.Cells[1].Value = textBox14.Text;
            newDataRow.Cells[2].Value = textBox18.Text;
            newDataRow.Cells[3].Value = textBox16.Text;
            newDataRow.Cells[4].Value = textBox15.Text;
        }
        private void ButtonDelDriver(object sender, EventArgs e)
        {
            int rowIndex = dataGridDriverDel.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                driverRepository.Data.RemoveAt(rowIndex);

                Refresh_AllD();
            }
        }



        private void Refresh_AllC()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = customerRepository.Data;
            dataGridCustAdd.DataSource = bs;
            dataGridCustEdit.DataSource = bs;
            dataGridCustDel.DataSource = bs;
            dataGridCustAdd.Refresh();
            dataGridCustEdit.Refresh();
            dataGridCustDel.Refresh();
        }
        private void ButtonAddCust(object sender, EventArgs e)
        {
            var FirstName = textBox23.Text;
            var SecondName = textBox22.Text;
            var Age = textBox21.Text;
            var City = textBox20.Text;
            var Bonus = textBox19.Text;

            textBox23.Clear();
            textBox22.Clear();
            textBox21.Clear();
            textBox20.Clear();
            textBox19.Clear();

            customerRepository.Add(new Customer(FirstName, SecondName, Convert.ToInt16(Age), City, Convert.ToInt32(Bonus)));

            Refresh_AllC();
        }
        int indexRowC;
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowC = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCustEdit.Rows[indexRowC];

                textBox25.Text = row.Cells[0].Value.ToString();
                textBox24.Text = row.Cells[1].Value.ToString();
                textBox28.Text = row.Cells[2].Value.ToString();
                textBox27.Text = row.Cells[3].Value.ToString();
                textBox26.Text = row.Cells[4].Value.ToString();
            }
        }
        private void ButtonUpdateCust(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridCustEdit.Rows[indexRowC];
            newDataRow.Cells[0].Value = textBox25.Text;
            newDataRow.Cells[1].Value = textBox24.Text;
            newDataRow.Cells[2].Value = textBox28.Text;
            newDataRow.Cells[3].Value = textBox27.Text;
            newDataRow.Cells[4].Value = textBox26.Text;
        }
        private void ButtonDelCust(object sender, EventArgs e)
        {
            int rowIndex = dataGridCustDel.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                customerRepository.Data.RemoveAt(rowIndex);

                Refresh_AllC();
            }
        }

    }
}
