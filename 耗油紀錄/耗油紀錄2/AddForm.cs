using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 耗油紀錄2.Mondels;

namespace 耗油紀錄2
{
    public partial class AddForm : Form
    {
        List<ContactsTable> list = new List<ContactsTable>();
        public AddForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = (decimal)0.00;
            numericUpDown2.Value = (decimal)0.00;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = Convert.ToDouble(numericUpDown1.Value),
                Kilometer = Convert.ToDouble(numericUpDown2.Value),
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.ContactsTable.Add(data);
                context.SaveChanges();
                list = context.ContactsTable.ToList();
                MessageBox.Show("存檔完成");
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }

        }

    }
}



    
