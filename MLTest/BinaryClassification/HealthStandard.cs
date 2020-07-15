using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLTest.BinaryClassification
{
    /// <summary>
    /// 健康标准数据
    /// </summary>
    public class HealthStandard
    {
        [LoadColumn(0)]
        public float Height { get; set; }

        [LoadColumn(1)]
        public float Weight { get; set; }

        [LoadColumn(2)]
        public bool Result { get; set; }
    }
}
