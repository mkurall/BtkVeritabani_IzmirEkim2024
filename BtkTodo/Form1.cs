using BtkTodo.Db;
using BtkTodo.Models;
using BtkTodo.Win32;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Text;

namespace BtkTodo
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Now;
        Font fntYear = new Font("Arial", 22);
        Font fntMonth = new Font("Arial", 18);
        Font fntDay = new Font("Arial", 14);
        Font fntCaption = new Font("Arial", 11);

        StringFormat sfCenter = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
        };

        Rectangle rectDays;
        Rectangle rectCloseButton;


        int hoverDay = 0;
        bool hoverClose = false;

        List<DbTodoEntry> entries;
        TodoDbContext context = new TodoDbContext();

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);


            RefreshEntries();
        }


        private int uCallBack;
        Win32Api.ABEdge edge;
        bool isAppBarRegistered = false;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == uCallBack)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)Win32Api.ABNotify.ABN_POSCHANGED:
                        Win32Api.ABSetPos(this.Handle, edge, 100);
                        break;
                }
            }

            base.WndProc(ref m);
        }

        protected override void OnLoad(EventArgs e)
        {
            uCallBack = Win32Api.RegisterAppBar(this.Handle);
            edge = Win32Api.ABEdge.ABE_RIGHT;

            Win32Api.ABSetPos(this.Handle, edge, 100);
            isAppBarRegistered = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Win32Api.UnregisterAppBar(this.Handle);
        }

        void RefreshEntries()
        {
            entries = context.Entries.ToList();
            Invalidate();
        }
        /*

        DbTodoEntry[] TestItems =
        {
            new DbTodoEntry(){Id = 1, Date = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Info = "Elekrik Faturasýný öde",ColorIndex = 1},
            new DbTodoEntry(){Id = 1, Date = DateTime.Now, Info = "Btk Eðitime Git",ColorIndex = 2},
            new DbTodoEntry(){Id = 1, Date = DateTime.Now.AddDays(7), Info = "Düðün var",ColorIndex = 3},

        };
        */

        protected override void OnShown(EventArgs e)
        {
            Bounds = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - 2, 0,
                                100, Screen.PrimaryScreen.WorkingArea.Height);

            TopMost = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rectCaption = new Rectangle(1, 1, Bounds.Width - 2, 25);
            Rectangle rectYear = new Rectangle(1, rectCaption.Bottom, Bounds.Width - 2, (int)fntYear.GetHeight(e.Graphics));
            Rectangle rectMonth = new Rectangle(1, rectYear.Bottom - 3, Bounds.Width - 2, (int)fntYear.GetHeight(e.Graphics));
            rectDays = new Rectangle(1, rectMonth.Bottom + 1, Bounds.Width - 2, Bounds.Height - rectMonth.Bottom);


            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            e.Graphics.FillRectangle(new SolidBrush(BackColor), Bounds);
            e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(0, 0, Bounds.Width - 1, Bounds.Height - 1));



            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(236, 112, 99)), new Rectangle(1, 1, Bounds.Width - 2, 25));
            e.Graphics.DrawImage(Properties.Resources.calendar, new Rectangle(2, 2, 21, 21), new Rectangle(0, 0, 24, 24), GraphicsUnit.Pixel);

            e.Graphics.DrawString("ToDo", fntCaption, Brushes.White, new Rectangle(1, 1, Bounds.Width - 2, 25), sfCenter);

            rectCloseButton = new Rectangle(Bounds.Width - 20, 4, 20, 20);

            e.Graphics.DrawImage(Properties.Resources.closeIt, rectCloseButton, new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);
            
            if(hoverClose)
                e.Graphics.DrawRectangle(Pens.White, rectCloseButton);

            e.Graphics.FillRectangle(Brushes.Tomato, rectYear);
            e.Graphics.FillRectangle(Brushes.Tomato, rectMonth);

            e.Graphics.FillRectangle(Brushes.WhiteSmoke, rectDays);



            e.Graphics.DrawString(dt.ToString("yyyy"), fntYear, Brushes.White, rectYear, sfCenter);
            e.Graphics.DrawString(dt.ToString("MMMM"), fntMonth, Brushes.White, rectMonth, sfCenter);

            int totalDays = DateTime.DaysInMonth(dt.Year, dt.Month);
            int daysRectHeight = rectDays.Height / totalDays;

            for (int d = 1; d <= totalDays; d++)
            {
                Rectangle rectDay =
                    new Rectangle(1, rectDays.Top + (d - 1) * daysRectHeight, Bounds.Width - 1, daysRectHeight);


                if (hoverDay == d)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(250, 219, 216)), rectDay);
                }

                if (d == DateTime.Now.Day)

                    e.Graphics.DrawString(d.ToString(), new Font(fntDay, FontStyle.Bold),
                        Brushes.Tomato,
                        rectDay, sfCenter);
                else
                    e.Graphics.DrawString(d.ToString(), fntDay,
                        Brushes.Black,
                        rectDay, sfCenter);

                if (d != totalDays)
                    e.Graphics.DrawLine(Pens.Gray, rectDay.Left + 3, rectDay.Bottom, rectDay.Right - 3, rectDay.Bottom);


                List<DbTodoEntry> list = entries.Where(x => x.Date.Year == dt.Year && x.Date.Month == dt.Month && x.Date.Day == d).ToList();

                if (list.Count > 0)
                {
                    DbTodoEntry first = list[0];
                    Size dotSize = new Size(12, 12);
                    e.Graphics.FillEllipse(new SolidBrush(TodoColors.ColorList[first.ColorIndex.GetValueOrDefault()].Color),
                        new Rectangle(rectDay.Left + 3, rectDay.Top + (rectDay.Height - dotSize.Height) / 2, dotSize.Width, dotSize.Height));
                }


            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int totalDays = DateTime.DaysInMonth(dt.Year, dt.Month);
            int daysRectHeight = rectDays.Height / totalDays;

            if(rectCloseButton.Contains(e.Location))
            {
                hoverClose = true;
                Invalidate();
                return;
            }

            if (hoverClose)
            {
                hoverClose = false;
                Invalidate();
            }


            for (int d = 1; d <= totalDays; d++)
            {
                Rectangle rectDay =
                    new Rectangle(1, rectDays.Top + (d - 1) * daysRectHeight, Bounds.Width - 1, daysRectHeight);

               

                if (rectDay.Contains(e.Location))
                {
                    if (hoverDay != d)
                    {
                        hoverDay = d;


                        List<DbTodoEntry> list = entries.Where(x => x.Date.Year == dt.Year && x.Date.Month == dt.Month && x.Date.Day == d).ToList();

                        if (list.Count > 0)
                        {
                            string str = "";

                            foreach (DbTodoEntry entry in list)
                            {
                                str += entry.Info +" \n";

                            }
                            toolTip1.ToolTipIcon = ToolTipIcon.Info;
                            toolTip1.ToolTipTitle = "Yapýlacaklar";
                            Point pt = rectDay.Location;

                            toolTip1.Show(str, this, pt.X -200, pt.Y, 8000);
                           
                        }
                        else
                        {
                            toolTip1.Hide(this);
                        }

                        Invalidate();

                    }

                    break;
                    
                }
            }

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            /*
            Bounds = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - 100, 0,
                                100, Screen.PrimaryScreen.WorkingArea.Height);
            */
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            toolTip1.Hide(this);
            hoverDay = 0;
            Invalidate();
            
            /*
            Bounds = new Rectangle(Screen.PrimaryScreen.WorkingArea.Width - 2, 0,
                                100, Screen.PrimaryScreen.WorkingArea.Height);
            */
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            int totalDays = DateTime.DaysInMonth(dt.Year, dt.Month);
            int daysRectHeight = rectDays.Height / totalDays;

            for (int d = 1; d <= totalDays; d++)
            {
                Rectangle rectDay =
                    new Rectangle(1, rectDays.Top + (d - 1) * daysRectHeight, Bounds.Width - 1, daysRectHeight);



                if (rectDay.Contains(e.Location))
                {

                    FrmEditDay form = new FrmEditDay(new DateTime(dt.Year, dt.Month, d), context);
                    form.ShowDialog();

                    RefreshEntries();
                    

                    break;

                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (rectCloseButton.Contains(e.Location) && hoverClose)
            {
                Close();
            }
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
            e.ToolTipSize = new Size(200, 100);
        }
    }
}
