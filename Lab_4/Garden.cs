using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Garden
    {
        public int AppleBoxes(int n)
        {
            Random random = new Random();
            int smallApples = 0, middleApples = 0, bigApples = 0;


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                    {
                        int appleDiameter = random.Next(5, 12);
                        if (appleDiameter < 7)
                        {
                            smallApples++;
                        }
                        else if (appleDiameter >= 7 && appleDiameter < 10)
                        {
                            middleApples++;
                        }
                        else if (appleDiameter >= 10)
                        {
                            bigApples++;
                        }
                    }

            int boxes = smallApples / 100 + middleApples / 100 + bigApples / 100;

            if (smallApples < 100 && smallApples != 0) boxes++;
            if (middleApples < 100 && middleApples != 0) boxes++;
            if (bigApples < 100 && bigApples != 0) boxes++;
            
            return boxes;
        }
    }
}
