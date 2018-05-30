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
    public partial class Queryform : Form
    {
        public Queryform()
        {
            InitializeComponent();
            BindData();
        }

        public void BindData()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }

        public void DomaimList()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            var Time1 = dateTimePicker1.Value;
            var Time2 = dateTimePicker2.Value;
            List<ContactsTable> list2 = new List<ContactsTable>();
            var Domain = list.Where((x) => Time1 <= x.RefuelingDate && x.RefuelingDate <= Time2);
            foreach (var item in Domain)
            {
                list2.Add(item);
            }
            dataGridView1.DataSource = list2;

            var K =list2.Sum((x) => x.Kilometer);
            var L =list2.Sum((x) => x.Liter);
            label4.Text =Math.Round(( K / L),2).ToString();
                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DomaimList();
        }

    }
}
