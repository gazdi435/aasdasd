using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Plotter
    {
        private int maxWidth;
        private int maxHeight;
        private int toolNumber;

        //pozicio
        private int actX, actY;
        private bool isHeadDown = false;
        private int actTool;

        public Plotter(int maxWidth, int maxHeight, int toolNumber,int actTool)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.toolNumber = toolNumber;
            this.actX = 0;
            this.actY = 0;
            this.actTool = actTool;
        }

        public void Menj(int newX, int newY)
        {
            //real.
            if (newX> maxWidth || newY>maxHeight || newX<0 || newY<0)
            {
                throw new Exception("Hibás adat!");
            }
            else
            {
                actX=newX;
                actY=newY;

            }
        }

        //"rövid kis leírás"
        public void Fel()=> isHeadDown = false;

        public void Le() => isHeadDown = true;

        public void Csere(int toolNum)
        {
            if (toolNum>toolNumber || toolNum<0)
            {
                throw new Exception("Hibás adat!");
            }
            else
            {
                actTool = toolNum;
            }
        }
        public void Draw(int oldX,int oldY,int newX, int newY)
        {
            
        
            Console.Clear();
            int xLength = Math.Abs(oldX - newX);
            int yLength = Math.Abs(oldY - newY);
        
            if (oldX<newX)
            {
                if (oldY<=newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        Console.SetCursorPosition(oldX + i, oldY + (i * yLength / xLength));
                        Console.Write("*");
                    }
                }
                else if(oldY>newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        Console.SetCursorPosition(oldX + i, oldY - (i * yLength / xLength));
                        Console.Write("*");
                        
                    }
                }
                else
                {
        
                }
            }else if (oldX > newX)
            {
                if (oldY <= newY)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        Console.SetCursorPosition(oldX - i, oldY + (i * yLength / xLength));
                        Console.Write("*");
                    }
                }
                else if (oldY > newY)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        Console.SetCursorPosition(oldX - i, oldY - (i * yLength / xLength));
                        Console.Write("*");
                    }
                }
                else
                {
        
                }
            }
        
        
        
        }
    }
}
