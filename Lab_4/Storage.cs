using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Storage
    {
        private List<int> CreateFullBox(ref int[] denominations)
        {
            Random random = new Random();
            List<int> box = new List<int>(500);
            for (int j = 0; j < 500; j++)
            {
                box[j] = random.Next(denominations.Length);
            }
            return box;
        }

        public int Coins(int n)
        {
            int[] denominations = {1, 2, 5, 10};
            List<List<int>> storage = new List<List<int>>(n);
            
            //Формирование хранилища
            for (int i = 0; i < n; i++)
            {
                storage[i] = CreateFullBox(ref denominations);
            }

            //Поиск монет с номиналом
            int coins = 0;
            for (int i = 0; i < n; i++)
            {
                List<int> box = new List<int>(500);
                box = storage[i];
                for (int j = 0; j < 500; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (box[j] == 2 * denominations[k])
                        {
                            coins++;
                            break;
                        }
                    }
                }
            }

            return coins;
        }
    }
}
