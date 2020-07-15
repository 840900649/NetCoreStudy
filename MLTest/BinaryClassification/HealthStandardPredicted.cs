using System;
using System.Collections.Generic;
using System.Text;

namespace MLTest.BinaryClassification
{
    /// <summary>
    /// 预测结果
    /// </summary>
    public class HealthStandardPredicted : HealthStandard
    {
        public bool PredictedLabel { get; set; }
    }
}
