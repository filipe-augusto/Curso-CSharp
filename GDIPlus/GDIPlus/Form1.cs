using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //criar uma folha em branco

            //criar um desenhador

            //utilizar o desenho


        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            //folha em branco
            Bitmap folha = new Bitmap(picture.Width, picture.Height);
            //criar desenhador
            Graphics desenhador = Graphics.FromImage(folha);
            //desenhar na folha
            desenhador.Clear(Color.White);

            #region linhas
            //Brush pincel = new SolidBrush(Color.Red);
            //Pen lapis = new Pen(pincel, 5);
            //Point ponto1 = new Point(100, 200);
            //Point ponto2 = new Point(500, 100);

            //Pen lapis2 = new Pen(Color.Black, 15);
            //Point ponto3 = new Point(0, 0);
            //Point ponto4 = new Point(100, 200);

            ////desenhador.DrawLine(lapis,ponto1, ponto2);
            ////desenhador.DrawLine(lapis2, ponto3, ponto4);
            //Point[] pontos =
            //{
            //    new Point(50,50),
            //    new Point(250,50),
            //    new Point(250,150),
            //    new Point(100,80),
            //    new Point(85,140)
            //};
            //desenhador.DrawLines(lapis2, pontos);
            #endregion
            #region Retangulos
            //Pen lapis1 = new Pen(Color.Black, 5);
            //Pen lapis2 = new Pen(Color.Blue, 20);
            //Rectangle rect1 = new Rectangle(100, 50, 300, 200);//pont x, pont y, width, height
            //Rectangle rect2= new Rectangle(50, 850,120 ,2400);//pont x, pont y, width, height
            //Rectangle rect3= new Rectangle(120, 20, 145, 100);//pont x, pont y, width, height
            //Rectangle rect4= new Rectangle(75, 200, 250, 100);//pont x, pont y, width, height

            //Rectangle[] rectangulos =
            // {
            //    rect1,rect2, rect3,rect4, new Rectangle(10,30,240,85)
            //};
            //desenhador.DrawRectangles(lapis1, rectangulos);

            ////desenhador.DrawRectangle(lapis1, rect1);
            ////desenhador.DrawRectangle(lapis2, 0, 0, 150, 150);
            //Brush pincel1 = new SolidBrush(Color.Green);
            //Brush pincel2 = new LinearGradientBrush(rect4,Color.Green, Color.Red,90);
            ////  desenhador.FillRectangle(pincel2, rect4);
            //desenhador.FillRectangles(pincel2, rectangulos);
            #endregion
            #region Ellipse e circulos
            //Pen lapis1 = new Pen(Color.Black, 5);
            //Rectangle rect1 = new Rectangle(150, 50, 200, 200);
            ////desenhador.DrawRectangle(lapis1, rect1);
            ////desenhador.DrawEllipse(lapis1, rect1);
            //Brush pincel = new LinearGradientBrush(rect1, Color.Brown, Color.Red,50);
            ////desenhador.FillEllipse(pincel, rect1);
            //desenhador.FillEllipse(Brushes.LightGray, rect1);

            #endregion
            #region Poligonos
            //Pen lapis1 = new Pen(Color.Black, 10);
            //Point[] pontos =
            //{
            //    new Point(100,100),
            //      new Point(300,100),
            //        new Point(250,250),
            //        new Point(100,200)
            //};
            //desenhador.DrawPolygon(lapis1, pontos);
            //Brush pincel = new LinearGradientBrush(new Rectangle(0, 0, 500, 500), Color.Red, Color.Yellow, 45);
            //desenhador.FillPolygon(Brushes.Blue, pontos);
            //desenhador.FillPolygon(pincel, pontos);
            #endregion
            #region Curvas

            Pen lapis = new Pen(Brushes.Blue, 10);
            Point[] pontos =
            {
                new Point(100,50),
                new Point(300,300),
                new Point(500,200),
                  new Point(300,100),
                    new Point(500,100),
            };

           // desenhador.DrawCurve(lapis,pontos,1.5f);
         //   desenhador.DrawClosedCurve(lapis, pontos, 1.5f,FillMode.Alternate);
            desenhador.FillClosedCurve(Brushes.Red, pontos,FillMode.Winding,1.5f);
            #endregion


            //utliizando num picture box
            picture.BackgroundImage = folha;

            //salvar o desenho num arquivo
            folha.Save(@"c:\curso\desenho.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
