using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLTest.TextAnayze
{
    public class CreateText: IDataInit
    {
        public void CreateData(string filePath)
        {

            StreamWriter sw = new StreamWriter(filePath, false);
            sw.WriteLine("Height,Weight,Result");

            Random random = new Random();
            float height, weight;
         

            //for (int i = 0; i < 2000; i++)
            //{
            //    height = random.Next(150, 195);
            //    weight = random.Next(70, 200);

            //    if (height > 170 && weight < 120)
            //        result = Result.Good;
            //    else
            //        result = Result.Bad;

            //    sw.WriteLine($"{height},{weight},{(int)result}");
            //}
            sw.Close();
            sw.Dispose();


        }
    }
}
