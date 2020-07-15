using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLTest.BinaryClassification
{
    /// <summary>
    /// 模型学习
    /// </summary>
    public class ModelStudy
    {

        public void TrainAndSave(string dataPath, string modelPath)
        {
            //初始化数据
            MLContext context = new MLContext();
            var fullData = context.Data.LoadFromTextFile<HealthStandard>(path: dataPath, hasHeader: true, separatorChar: ',');
            var trainTestData = context.Data.TrainTestSplit(fullData, 0.2);
            var trainData = trainTestData.TrainSet;
            var trainTest = trainTestData.TestSet;
            //训练数据
            IEstimator<ITransformer> dataProcessPipeline = context.Transforms.Concatenate("Feature", new[] { "Height", "Weight" })
                .Append(context.Transforms.NormalizeMeanVariance("FeaturesNormalizedByMeanVar", "Feature"));//数据均差值归一

            IEstimator<ITransformer> estimator = context.BinaryClassification.Trainers.SdcaLogisticRegression("Result", "FeaturesNormalizedByMeanVar");//二元分类，逻辑回归算法。处理结果

            IEstimator<ITransformer> trainingPipeline = dataProcessPipeline.Append(estimator);//融合数据管道

            ITransformer model = trainingPipeline.Fit(trainData);//提取特征模型

            //评估数据 
            var dataView = model.Transform(trainTest);//将测试数据，转换数据视图进行演示 
            var metrics = context.BinaryClassification.Evaluate(dataView, "Result", "Score");   //评估值
            Console.WriteLine(metrics);

            //保存模型
            context.Model.Save(model, trainData.Schema, modelPath);
            Console.WriteLine($"Model file saved to :{modelPath}");

        }
        MLContext MLContext;

        PredictionEngine<HealthStandard, HealthStandardPredicted> predctionEngine;
        /// <summary>
        /// 加载训练模型
        /// </summary>
        public void LoadTrainModel(string modelPath, HealthStandard health)
        {
            if (MLContext == null)
            {
                MLContext = new MLContext();
                ITransformer model = MLContext.Model.Load(modelPath, out var inputStream);
                predctionEngine = MLContext.Model.CreatePredictionEngine<HealthStandard, HealthStandardPredicted>(model);

            }

            var prediction = predctionEngine.Predict(health);
            string val = prediction.PredictedLabel ? "健康" : "不健康";
            Console.WriteLine($"身高：{health.Height}，体重：{health.Weight}。预测结果 :{val}");
        }
    }
}
