using BtkTodo.Db;
using BtkTodo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkTodo
{
    public partial class FrmEditDay : Form
    {
        TodoDbContext context;
        BindingList<DbTodoEntry> bList;
        DateTime date;
        public FrmEditDay(DateTime dt, TodoDbContext context)
        {
            InitializeComponent();
            
            this.context = context;

            date = dt;
            lblDay.Text = date.ToString("dd MMMM yyyy\ndddd");
            lblDay.Height = 100;

            var list = context.Entries.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.Date.Day == date.Day).ToList();
            bList = new BindingList<DbTodoEntry>(list);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bList;

            colColor.DataSource = TodoColors.ColorList;
            colColor.DisplayMember = "Color";
            colColor.ValueMember = "Id";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (DbTodoEntry entry in bList)
            {
                if (entry.Id == 0)
                {
                    entry.Date = date;
                    context.Entries.Add(entry);
                }
            }

            context.SaveChanges();

            Close();
        }
    }
}
