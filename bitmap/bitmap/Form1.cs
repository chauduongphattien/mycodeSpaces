using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmap
{
    public partial class Form1 : Form
    {
        private List<shape> MyLines = new List<shape>();
        public Point MouseDownLocation;
        private bool IsMouseDown = false;
        private int m_StartX;
        private int m_StartY;
        private int m_CurX;
        private int m_CurY;
        private string DrawCase = "Line";
        Point Point1 = new Point();
        Point Point2 = new Point();
        Point StartDownLocation = new Point();
        private List<Color> corList=new List<Color>();
        private List<Color> coE=new List<Color>();
        Bitmap bm;
        Graphics gp;
        Color myColor;
        Pen myPen;
        int index=0;
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 500;
            bm=new Bitmap(panel2.Width,panel2.Height);
            gp= Graphics.FromImage(bm);
            myColor = Color.Black;
            myPen= new Pen(myColor,5);
            pictureBox1.Image = bm;
        }
        int draw = 0;
        bool start = false;


        private void button1_Click(object sender, EventArgs e)
        {
            DrawCase = "Line";
            index = 1;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_StartX = e.X;
            m_StartY = e.Y;
            m_CurX = e.X;
            m_CurY = e.Y;
            
               
            

            StartDownLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Pen dashed_pen = new Pen(Color.Green, 1);
            dashed_pen.DashStyle = DashStyle.Dash;
            if (IsMouseDown == false) return;
            m_CurX = e.X;
            m_CurY = e.Y;
            if (index == 0)
            {
                gp.DrawLine(myPen, m_CurX, m_CurY, m_StartX, m_StartY);
                m_StartX = m_CurX;
                m_StartY = m_CurY;
            }
            //panel2.Refresh();
            if (index == 1)
            {
                switch (DrawCase)
                {
                    case "Line":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }
                    
                }
            }
            else if (index == 2)
            {
                switch (DrawCase)
                {
                    case "esclipe":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }

                }
            }
            else if (index == 3)
            {
                switch (DrawCase)
                {
                    case "rec":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }

                }
            }
           

            panel2.Invalidate();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;

            if (e.Button == MouseButtons.Left)
            {
                if (index == 1)
                {
                    switch (DrawCase)
                    {
                        case "Line":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = m_StartX;
                                DrawLine.Y1 = m_StartY;
                                DrawLine.X2 = m_CurX;
                                DrawLine.Y2 = m_CurY;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }
                else if (index == 2)
                {
                    switch (DrawCase)
                    {
                        case "esclipe":
                            {
                                shape DrawEsclipe = new eclipeClass();
                                DrawEsclipe.X1 = m_StartX;
                                DrawEsclipe.Y1 = m_StartY;
                                DrawEsclipe.X2 = m_CurX;
                                DrawEsclipe.Y2 = m_CurY;
                                MyLines.Add(DrawEsclipe);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new eclipeClass();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new eclipeClass();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }
                else if (index == 3)
                {
                    switch (DrawCase)
                    {
                        case "rec":
                            {
                                shape DrawEsclipe = new rectangle();
                                DrawEsclipe.X1 = m_StartX;
                                DrawEsclipe.Y1 = m_StartY;
                                DrawEsclipe.X2 = m_CurX;
                                DrawEsclipe.Y2 = m_CurY;
                                MyLines.Add(DrawEsclipe);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new rectangle();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new rectangle();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }
               
                panel2.Invalidate();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int i, x1, y1, x2, y2;

            for (i = 0; i <= MyLines.Count - 1; i++)
            { 
                Pen LinePen;
                LinePen = new Pen(corList[i], 3);
               
               
                x1 = MyLines[i].X1;
                x2 = MyLines[i].X2;
                y1 = MyLines[i].Y1;
                y2 = MyLines[i].Y2;
                if (MyLines[i].drawNum() == 1)
                {
                    e.Graphics.DrawLine(LinePen, x1, y1, x2, y2);
                }
                else if(MyLines[i].drawNum() == 2)
                {
                    e.Graphics.DrawEllipse(LinePen, x1, y1, Math.Abs(x1-x2),Math.Abs(y1-y2));
                }
                else if(MyLines[i].drawNum() == 3)
                {
                    e.Graphics.DrawRectangle(LinePen, x1, y1, Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                }
            }


            if (IsMouseDown == true)
            {
               
                if (index == 1)
                {
                    switch (DrawCase)
                    {
                        case "Line":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, m_StartX, m_StartY, m_CurX, m_CurY);
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, Point1.X, Point1.Y, Point2.X, Point2.Y);
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, Point1.X, Point1.Y, Point2.X, Point2.Y);
                                break;
                            }
                    }
                
                   

                }
                if (index == 2)
                {
                    switch (DrawCase)
                    {
                        case "esclipe":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen, m_StartX, m_StartY, Math.Abs(m_StartX - m_CurX), Math.Abs(m_StartY - m_CurY));
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen,Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                    }
                }
                if (index == 3)
                {
                    switch (DrawCase)
                    {
                        case "rec":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, m_StartX, m_StartY, Math.Abs(m_StartX - m_CurX), Math.Abs(m_StartY - m_CurY));
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                    }
                }


            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawCase = "copy";
        }
        

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawCase = "move";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd=new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                myColor= cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrawCase = "esclipe";
            index = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DrawCase = "rec";
            index = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;

            m_StartX = e.X;
            m_StartY = e.Y;
            m_CurX = e.X;
            m_CurY = e.Y;




            StartDownLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen dashed_pen = new Pen(Color.Green, 1);
            dashed_pen.DashStyle = DashStyle.Dash;
            if (IsMouseDown == false) return;
            m_CurX = e.X;
            m_CurY = e.Y;
            if (index == 0)
            {
                gp.DrawLine(myPen, m_CurX, m_CurY, m_StartX, m_StartY);
                m_StartX = m_CurX;
                m_StartY = m_CurY;
            }
            //panel2.Refresh();
            if (index == 1)
            {
                switch (DrawCase)
                {
                    case "Line":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }

                }
            }
            else if (index == 2)
            {
                switch (DrawCase)
                {
                    case "esclipe":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }

                }
            }
            else if (index == 3)
            {
                switch (DrawCase)
                {
                    case "rec":
                        {
                            break;
                        }
                    case "copy":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;
                            }
                            break;

                        }
                    case "move":
                        {
                            int i;
                            i = MyLines.Count - 1;
                            if (i >= 0)
                            {
                                Point1.X = e.X + MyLines[i].X1 - StartDownLocation.X;
                                Point1.Y = e.Y + MyLines[i].Y1 - StartDownLocation.Y;
                                Point2.X = e.X + MyLines[i].X2 - StartDownLocation.X;
                                Point2.Y = e.Y + MyLines[i].Y2 - StartDownLocation.Y;

                            }
                            break;

                        }

                }
            }


            panel2.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;

            if (e.Button == MouseButtons.Left)
            {
                if (index == 1)
                {
                    switch (DrawCase)
                    {
                        case "Line":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = m_StartX;
                                DrawLine.Y1 = m_StartY;
                                DrawLine.X2 = m_CurX;
                                DrawLine.Y2 = m_CurY;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new line();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }
                else if (index == 2)
                {
                    switch (DrawCase)
                    {
                        case "esclipe":
                            {
                                shape DrawEsclipe = new eclipeClass();
                                DrawEsclipe.X1 = m_StartX;
                                DrawEsclipe.Y1 = m_StartY;
                                DrawEsclipe.X2 = m_CurX;
                                DrawEsclipe.Y2 = m_CurY;
                                MyLines.Add(DrawEsclipe);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new eclipeClass();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new eclipeClass();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }
                else if (index == 3)
                {
                    switch (DrawCase)
                    {
                        case "rec":
                            {
                                shape DrawEsclipe = new rectangle();
                                DrawEsclipe.X1 = m_StartX;
                                DrawEsclipe.Y1 = m_StartY;
                                DrawEsclipe.X2 = m_CurX;
                                DrawEsclipe.Y2 = m_CurY;
                                MyLines.Add(DrawEsclipe);
                                corList.Add(myColor);
                                break;
                            }
                        case "copy":
                            {
                                shape DrawLine = new rectangle();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                corList.Add(myColor);
                                break;
                            }
                        case "move":
                            {
                                shape DrawLine = new rectangle();
                                DrawLine.X1 = Point1.X;
                                DrawLine.Y1 = Point1.Y;
                                DrawLine.X2 = Point2.X;
                                DrawLine.Y2 = Point2.Y;
                                MyLines.Add(DrawLine);
                                int count = MyLines.Count - 1;
                                MyLines.RemoveAt(count - 1);
                                corList.Add(myColor);
                                int countC = corList.Count - 1;
                                corList.RemoveAt(countC - 1);

                                break;
                            }
                    }
                }

                panel2.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int i, x1, y1, x2, y2;

            for (i = 0; i <= MyLines.Count - 1; i++)
            {
                Pen LinePen;
                LinePen = new Pen(corList[i], 3);


                x1 = MyLines[i].X1;
                x2 = MyLines[i].X2;
                y1 = MyLines[i].Y1;
                y2 = MyLines[i].Y2;
                if (MyLines[i].drawNum() == 1)
                {
                    e.Graphics.DrawLine(LinePen, x1, y1, x2, y2);
                }
                else if (MyLines[i].drawNum() == 2)
                {
                    e.Graphics.DrawEllipse(LinePen, x1, y1, Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                }
                else if (MyLines[i].drawNum() == 3)
                {
                    e.Graphics.DrawRectangle(LinePen, x1, y1, Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                }
            }


            if (IsMouseDown == true)
            {

                if (index == 1)
                {
                    switch (DrawCase)
                    {
                        case "Line":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, m_StartX, m_StartY, m_CurX, m_CurY);
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, Point1.X, Point1.Y, Point2.X, Point2.Y);
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawLine(dashed_pen, Point1.X, Point1.Y, Point2.X, Point2.Y);
                                break;
                            }
                    }



                }
                if (index == 2)
                {
                    switch (DrawCase)
                    {
                        case "esclipe":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen, m_StartX, m_StartY, Math.Abs(m_StartX - m_CurX), Math.Abs(m_StartY - m_CurY));
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawEllipse(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                    }
                }
                if (index == 3)
                {
                    switch (DrawCase)
                    {
                        case "rec":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, m_StartX, m_StartY, Math.Abs(m_StartX - m_CurX), Math.Abs(m_StartY - m_CurY));
                                break;
                            }
                        case "copy":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                        case "move":
                            {
                                Pen dashed_pen = new Pen(Color.Blue, 1);
                                e.Graphics.DrawRectangle(dashed_pen, Point1.X, Point1.Y, Math.Abs(Point1.X - Point2.X), Math.Abs(Point1.Y - Point2.Y));
                                break;
                            }
                    }
                }


            }

        }
    }
}
