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
        //CIGÁNY VAGY!
        /*
        public void Draw(int newX, int newY)
        {
            //ez unity. get real.
            int length = Convert.ToInt16(Math.Sqrt((actX - actY) ^ 2 + (newX - newY) ^ 2));
            if (actX < newX)//nem
            {
                for (int i = 1; i <= length; i++)
                {
                    actX
                }
            }
        }
        */
    }
}
