using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class Painter : Form
    {
        Color crColor;//цвет
        Pen upen;//руча
        Graphics canvas;//Загадочная хрень. Плохо изученная. Ну.. В мсдн написано что надо это юзать. Значит будем юзать
        Point crMousePosition;//текущий поинт курсора(Экран)
        Point prMousePosition;//Прошедший поинт курсора(Тоже Экран)
        Bitmap art;//Битмапа-Рисовака 
        SolidBrush brushShape;//Браша - Это для филла. Ну так в МСДН НАПИСАНО, я че. я ниче. 
        Size brushSize;//Фак вот это не помню..... А - это типа переменная САЙйз в которую я пхнул Со скрола ВалуЭ.
        int mainTool = 0;//основная тула 
        int additionalTool = 0;//Адитиональ Тулла!!

        public Painter()//стандартная подлива
        {
            InitializeComponent();
        }


        private void AllToolsOFF()//ТулоОбнуляшка 
        {

            mainTool = 0;
            additionalTool = 0;

        }

        private Rectangle FigureDrawCalculator(int x1, int y1, int x2, int y2)// формирователь правильного ректангуляра относительно стартовой и конечной точки курсора
        {
            Size figureSizeTemp = new Size(Math.Abs(x1 - x2), Math.Abs(y1 - y2));

            if (x1 > x2 & y1 > y2)
            {
                return new Rectangle(prMousePosition, figureSizeTemp);
            }
            if (x1 < x2 & y1 < y2)
            {
                return new Rectangle(crMousePosition, figureSizeTemp);
            }
            if (x1 > x2 & y1 < y2)
            {
                return new Rectangle(new Point(x2, y1), figureSizeTemp);
            }
            if (x1 < x2 & y1 > y2)
            {
                return new Rectangle(new Point(x1, y2), figureSizeTemp);
            }
            else
            {
                return new Rectangle(new Point(0, 0), new Size(0, 0));
            }

        }


        private void Drawing()
        {
            brushShape.Color = crColor;//СОЛИД БРАША!!!  
            upen.Color = crColor;//ручка... при отрисовке DrawRectangle returs pretty interesting result.  
            switch (additionalTool)

            {
                case 0://проверка инструментов + Если филл включен 
                    canvas.FillEllipse(brushShape, new Rectangle(new Point(crMousePosition.X - (bSizeBar.Value / 2), crMousePosition.Y - (bSizeBar.Value / 2)), brushSize));
                    break;
                case 1:
                    //
                    if (FillCheckBox.Checked)
                    {
                        canvas.FillRectangle(brushShape, FigureDrawCalculator(crMousePosition.X, crMousePosition.Y, prMousePosition.X, prMousePosition.Y));
                    }
                    else
                    {
                        
                        canvas.DrawRectangle(upen, FigureDrawCalculator(crMousePosition.X, crMousePosition.Y, prMousePosition.X, prMousePosition.Y));
                    }

                    break;
                case 2:
                    if (FillCheckBox.Checked)
                    {
                        canvas.FillEllipse(brushShape, FigureDrawCalculator(crMousePosition.X, crMousePosition.Y, prMousePosition.X, prMousePosition.Y));
                    }
                    else
                    {

                        canvas.DrawEllipse(upen, FigureDrawCalculator(crMousePosition.X, crMousePosition.Y, prMousePosition.X, prMousePosition.Y));
                    }                    
                    break;
                default:
                    break;
            }

            //canvas.FillRectangle(brushShape, new RectangleF(new Point(crMousePosition.X - (bSizeBar.Value/2), crMousePosition.Y - (bSizeBar.Value/2)), brushSize));//Ректангль Схапе!!!!...

            paper.Image = art;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            brushSize = new Size(bSizeBar.Value, bSizeBar.Value);//Принимает значения ползунка размеров
            brushShape = new SolidBrush(crColor);//Инициализируем солид брашу 
            art = new Bitmap(paper.Width, paper.Height);//создаем битмапу по размеру нашего канваса. полотна кароч. 
            crMousePosition = Cursor.Position;//писваиваем поинту текущее положение мышки(НА ЭКРАНЕ !!! не на форме)
            crColor = colorButton.BackColor;//приваиваем переменной текущего цвета цвет кнопки выбора цветов. цвет цвет цвет маслечко масляное 

            upen = new Pen(crColor,bSizeBar.Value);// инициализируем ручку как новую с шейпой Солид Браши????? тут вопрос конечно. да тут вопрос. 
            upen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            upen.DashCap = System.Drawing.Drawing2D.DashCap.Round;//какой будет конец у нашей ручки я так понял.. МСДН пфффффффф. мсдн. Скругляшки 
            upen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;//тип линии - Солид канешно штрихпунктир выглядит норм. но чет сплошняком лучше 

            canvas = Graphics.FromImage(art); //график у нас будет работать с битмапой
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//ну тут такое тоже м МСДН ПОДСМОТРЕЛЬ. ну такое. такое. Типа сглаживание..

            saveFileDialog.FileName = "MyCreation";//Шаблон названия файла 
            saveFileDialog.Filter = "PNG(*.PNG; *.png)| *.PNG; *.png; | Jpeg(*.JPEG; *.jpeg) | *.JPEG; *.jpeg; | Bitmap(*.BMP; *.bmp)|*.BMP; *.bmp |All files(*.*) | *.*";//ШАблон форматов файлов


        }



        private void paper_MouseDown(object sender, MouseEventArgs e)//Нажимашка на Бамажка 
        {
            brushSize.Width = bSizeBar.Value;
            brushSize.Height = bSizeBar.Value;
            upen.Width = bSizeBar.Value;
            mainTool = 1;
            if (additionalTool != 0)
            {
                prMousePosition = PointToClient(Cursor.Position);
            }

        }

        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            mainTool = 0;

            if (additionalTool != 0)
            {
                Drawing();
            }

            upen.Brush.Dispose();//А в мсднЕ нАписАно, что ЭЭЭтоО очищААет память. И карму.  

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            cDialog.ShowDialog();
            crColor = cDialog.Color;
            colorButton.BackColor = cDialog.Color;
        }

        private void colorButton_MouseLeave(object sender, EventArgs e)
        {
            colorButton.Width = 50;
            colorButton.Height = 50;
            colorButton.Location = new Point(300, 495);
        }

        private void colorButton_MouseMove(object sender, MouseEventArgs e)
        {
            colorButton.Width = 60;
            colorButton.Height = 60;
            colorButton.Location = new Point(295, 490);
        }

        private void paper_MouseMove(object sender, MouseEventArgs e)//ОООООООООО ведем по канвасу мышой 
        {


            if (mainTool != 0 & additionalTool == 0)// Проверяем чо происходит. Если тулсы активированы какие то - Действуем.
            {
                prMousePosition = crMousePosition;
                crMousePosition = PointToClient(Cursor.Position);
                Drawing();
            }
            else
            {
                switch (additionalTool)
                {
                    case 1:
                        crMousePosition = PointToClient(Cursor.Position);//Позицьйон Относительно формъйон. 
                        break;
                    case 2:
                        crMousePosition = PointToClient(Cursor.Position);
                        break;
                    default:
                        break;
                }
            }
        }

        private void recBtn_MouseClick(object sender, MouseEventArgs e)//клик по ректангль батон
        {
            additionalTool = 1;
        }

        private void paper_DoubleClick(object sender, EventArgs e)//ДАБЛ КЛИН НА ПОЛЕ - ОТМЕНА ВСЕХ ТУЛЗОВ 
        {
            AllToolsOFF();
        }

        private void ellipsButton_Click(object sender, EventArgs e)//клик по элипс-батОну 
        {
            additionalTool = 2;
        }

        private void bSizeBar_Scroll(object sender, EventArgs e)//размеры, тааааак это не интересно...
        {
            sizeIndicator.Text = bSizeBar.Value.ToString();
        }

        private void saveBtn_MouseClick(object sender, MouseEventArgs e)//О, О.....Сохраняшка....МММММММ______ :)
        {          

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                art.Save(saveFileDialog.FileName);
            }
        }

        //Фак. Я забыл стирачку сделать. Ну пох лан. я и контролЗет забыл и заливку и кривые . ой ну блин. .... 


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
