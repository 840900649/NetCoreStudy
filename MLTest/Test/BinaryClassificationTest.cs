using MLTest.BinaryClassification;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MLTest.Test
{
    /// <summary>
    /// 二元分类基础学习测试
    /// </summary>
    public class BinaryClassificationTest : ITest
    {
        static readonly string DataPath = Path.Combine(Environment.CurrentDirectory, "Data", "figure_full.csv");
        static readonly string ModelPath = Path.Combine(Environment.CurrentDirectory, "Data", "FastTree_Model.zip");

        public void Test()
        {
            // new DataInit().CreateData(DataPath);
            var ml = new ModelStudy();
            ml.TrainAndSave(DataPath, ModelPath);
            for (int i = 0; i < 10; i++)
            {
                var random = new Random();
                ml.LoadTrainModel(ModelPath, new HealthStandard()
                {
                    Height = random.Next(150, 195),
                    Weight = random.Next(70, 200),
                });
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
