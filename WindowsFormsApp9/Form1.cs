using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Создайте приложение, 
которое будет рисовать шахматную доску и шахматные фигуры на клиентской области формы. 
*/
namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Graphics graphics;
 
          
        public Form1()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
        }
       
        public void ShowChessBoard()//шахматная доска 
        {
            //высота и ширина
            Brush brush = Brushes.Gray;
            int height = 75;
            int width = 75;
            for(int i = 0; i < 8; i+=2)graphics.FillRectangle(brush, width*i, 0, width, height);
            for(int i = 1; i < 8; i+=2)graphics.FillRectangle(brush, width*i, height, width, height);
            for (int i = 0; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height*2, width, height);
            for (int i = 1; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height*3, width, height);
            for (int i = 0; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height*4, width, height);
            for (int i = 1; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height * 5, width, height);
            for (int i = 0; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height * 6, width, height);
            for (int i = 1; i < 8; i += 2) graphics.FillRectangle(brush, width * i, height * 7, width, height);
        }
        public void DrawPawns(int X,int Y,Brush brush)//пешки
        {
            Pen pen = new Pen(Color.Black,2);

            graphics.FillEllipse(brush,X,Y,20,20);
            graphics.DrawEllipse(pen,X,Y,20,20);

            graphics.FillRectangle(brush,X+5,Y+20,10,20);
            graphics.DrawRectangle(pen,X+5,Y+20,10,20);


            graphics.FillEllipse(brush, X-10, Y+32, 40, 20);
            graphics.DrawEllipse(pen, X-10, Y+32, 40, 20);

        }
        public void DrawRook(int X, int Y, Brush brush)//ладья
        {
            Pen pen = new Pen(Color.Black, 2);

            
            graphics.DrawRectangle(pen,X,Y,2,4);
            graphics.FillRectangle(brush, X, Y,2, 4);

            graphics.DrawRectangle(pen, X+10, Y, 2, 4);
            graphics.FillRectangle(brush, X+10, Y, 2, 4);

            graphics.DrawRectangle(pen, X + 20, Y, 2, 4);
            graphics.FillRectangle(brush, X + 20, Y, 2, 4);

            graphics.DrawRectangle(pen, X, Y+5, 22, 40);
            graphics.FillRectangle(brush, X, Y+5, 22, 40);

          
        }
        public void DrawQueen(int X, int Y, Brush brush) //ферзь
        {
            Pen pen = new Pen(Color.Black, 2);
            graphics.FillEllipse(brush, X+5, Y, 10, 10);
            graphics.DrawEllipse(pen, X+5, Y, 10, 10);

            graphics.FillEllipse(brush, X, Y+10, 20, 20);
            graphics.DrawEllipse(pen, X, Y+10, 20, 20);

            graphics.DrawRectangle(pen, X-5, Y+20, 30, 10);
            graphics.FillRectangle(brush, X-5, Y+20, 30, 10);

            graphics.DrawRectangle(pen, X, Y + 25, 20, 40);
            graphics.FillRectangle(brush, X , Y + 25, 20, 40);


        }

        public void DrawKing(int X, int Y, Brush brush) //король
        {
            Pen pen = new Pen(Color.Black, 2);
            graphics.DrawRectangle(pen, X, Y, 2, 4);
            graphics.FillRectangle(brush, X, Y, 2, 4);

            graphics.DrawRectangle(pen, X + 10, Y, 2, 4);
            graphics.FillRectangle(brush, X + 10, Y, 2, 4);

            graphics.DrawRectangle(pen, X + 20, Y, 2, 4);
            graphics.FillRectangle(brush, X + 20, Y, 2, 4);

            graphics.DrawRectangle(pen, X, Y + 5, 22, 8);
            graphics.FillRectangle(brush, X, Y + 5, 22, 8);




        }

        public void DrawElephant(int X, int Y, Brush brush)//слон
        {
            Pen pen = new Pen(Color.Black, 2);
            graphics.FillEllipse(brush, X, Y, 10, 20);
            graphics.DrawEllipse(pen, X, Y, 10, 20);

            graphics.DrawRectangle(pen, X-5, Y + 15, 22, 8);
            graphics.FillRectangle(brush, X-5, Y + 15, 22, 8);

            graphics.DrawRectangle(pen, X, Y + 25, 10, 30);
            graphics.FillRectangle(brush, X, Y + 25, 10, 30);



        }

        public void DrawHorse(int X, int Y, Brush brush)//конь
        {
            Pen pen = new Pen(Color.Black, 2);
            graphics.FillEllipse(brush, X, Y, 50, 10);
            graphics.DrawEllipse(pen, X, Y, 50, 10);

            graphics.FillEllipse(brush, X+30, Y + 7, 20, 50);
            graphics.DrawEllipse(pen, X+30, Y + 7, 20, 50);


        }




        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            
            ShowChessBoard();
            //чёрные
            for(int i=0;i<Width;i+=75)DrawPawns(28+i,97,Brushes.Black);
            DrawRook(25, 29, Brushes.Black);
            DrawRook(553, 29, Brushes.Black);
            DrawKing(250,62, Brushes.Black);
            DrawQueen(330, 9, Brushes.Black);
            DrawElephant(185,19, Brushes.Black);
            DrawElephant(410,19, Brushes.Black);
            DrawHorse(75, 17, Brushes.Black);
            DrawHorse(450, 17, Brushes.Black);
          

            //белые
            for (int i=0;i<Width;i+=75)DrawPawns(28+i,473,Brushes.White);
            DrawRook(25,554,Brushes.White);
            DrawRook(553,554,Brushes.White);
            DrawKing(250, 587, Brushes.White);
            DrawQueen(330, 534, Brushes.White);
            DrawElephant(185,544, Brushes.White);
            DrawElephant(410, 544, Brushes.White);
            DrawHorse(75,545, Brushes.White);
            DrawHorse(450, 545, Brushes.White);





        }


        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"{e.X}:{e.Y}";
        }

    }
}
