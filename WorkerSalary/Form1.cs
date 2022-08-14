using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace WorkerSalary
{
    public partial class Form1 : Form
    {
        int row = 0;
        string id, name, lastName, email, phoneNumber, address, salary;
        double tax;
        List<WorkersDetailes> w = new List<WorkersDetailes>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_addWorkers_Click(object sender, EventArgs e)
        {
            int len = w.Count();
            for (int i = len; i < len+10000; i++)
            {
                WorkersDetailes newWorker = new WorkersDetailes();
                w.Add(newWorker);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = w[i].getSalary();
                dataGridView1.Rows[row].Cells[2].Value = w[i].getName();
                dataGridView1.Rows[row].Cells[1].Value = w[i].getID();
                row++;

            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("ID must be a number");
            }
        }

        private void tb_salary_TextChanged(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, System.EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string salary = w[r].getSalary();
            double tax_amount = tax_count(salary);
            label10.Text = tax_amount.ToString();

        }

        public double tax_count(string salary)
        {
            

            if (double.Parse(salary) <= 6450)
                tax = 0.1;
            if (double.Parse(salary) > 6450 && double.Parse(salary) <= 9240)
                tax = 0.14;
            if (double.Parse(salary) > 9240 && double.Parse(salary) <= 14840)
                tax = 0.2;
            if (double.Parse(salary) > 14840 && double.Parse(salary) <= 20620)
                tax = 0.31;
            if (double.Parse(salary) > 20620 && double.Parse(salary) <= 42910)
                tax = 0.35;
            if (double.Parse(salary) > 42910)
                tax = 0.47;
            double tax_amount = tax * double.Parse(salary);
            tax_amount = Math.Round(tax_amount, 3);
            return tax_amount;
        }

        public void button5_Click(WorkersDetailes w1)
        {
            throw new NotImplementedException();
        }

        public void bt_sort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            long result = 0;
            int len= w.Count();
            stopwatch.Reset();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200)
            {
               Quick_sort(w, 0,len-1);
                //List<WorkersDetailes> wTmp = bubbleSrt(w);
            }
            stopwatch.Stop();
            
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            row = 0;
            for (int i = 0; i < w.Count(); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = w[i].getSalary();
                dataGridView1.Rows[row].Cells[2].Value = w[i].getName();
                dataGridView1.Rows[row].Cells[1].Value = w[i].getID();
                row++;
            }
            long milliseconds = stopwatch.ElapsedMilliseconds;
            label12.Text = milliseconds.ToString()+ "  mS";


        }
        /*static List<WorkersDetailes> bubbleSrt(List<WorkersDetailes> w)
        {
            int num = w.Count();
            for (int i = 0; i < num - 1; i++)
                for (int j = 0; j < num - i - 1; j++)
                    if (double.Parse(w[j].getSalary()) > double.Parse(w[j + 1].getSalary()))
                    {
                        WorkersDetailes tmp = w[j];
                        w[j] = w[j + 1];
                        w[j + 1] = tmp;

                    }
            return w;
        }*/

        public void Quick_sort(List<WorkersDetailes> arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_sort(arr, pivot + 1, right);
                }
            }
        }
       
        public static int Partition(List<WorkersDetailes> arr, int left, int right)
        {
            int pivot = int.Parse(arr[left].getSalary());
            while (true)
            {

                while (int.Parse(arr[left].getSalary()) < pivot)
                {
                    left++;
                }

                while (int.Parse(arr[right].getSalary()) > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left].getSalary() == arr[right].getSalary()) return right;

                    WorkersDetailes temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        
      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = w.Count();
            id = tb_id.Text;
            name = tb_name.Text;
            lastName = tb_fName.Text;
            email = tb_Email.Text;
            phoneNumber = tb_phone.Text;
            address = tb_address.Text;

            //WorkersDetailes newWorker = new WorkersDetailes(id, name, salary);
            if (double.Parse(tb_salary.Text) >= 3000 && double.Parse(tb_salary.Text) <= 50000)
            {
                salary = tb_salary.Text;
                w.Add(new WorkersDetailes(id, name, salary));
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = tb_salary.Text;
                dataGridView1.Rows[row].Cells[1].Value = tb_id.Text;
                dataGridView1.Rows[row].Cells[2].Value = tb_name.Text;
                row++;
            }
            else
            {
                MessageBox.Show("The salary should be between 3000 to 50000!");
            }
            

        }

        

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        
    }
}