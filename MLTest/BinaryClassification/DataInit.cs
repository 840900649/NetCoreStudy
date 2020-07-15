using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLTest.BinaryClassification
{
    /// <summary>
    /// 数据初始化
    /// </summary>
    public class DataInit: IDataInit
    {
        public void CreateData(string filePath)
        {

            StreamWriter sw = new StreamWriter(filePath, false);
            sw.WriteLine("Height,Weight,Result");

            Random random = new Random();
            float height, weight;
            Result result;

            for (int i = 0; i < 2000; i++)
            {
                height = random.Next(150, 195);
                weight = random.Next(70, 200);

                if (height > 170 && weight < 120)
                    result = Result.Good;
                else
                    result = Result.Bad;

                sw.WriteLine($"{height},{weight},{(int)result}");
            }
            sw.Close();
            sw.Dispose();


        }
    }

    enum Result
    {
        Bad = 0,
        Good = 1
    }

}
