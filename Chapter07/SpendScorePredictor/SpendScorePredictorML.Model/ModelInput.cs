// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace SpendScorePredictorML.Model
{
    public class ModelInput
    {
        [ColumnName("CustomerID"), LoadColumn(0)]
        public float CustomerID { get; set; }


        [ColumnName("Gender"), LoadColumn(1)]
        public string Gender { get; set; }


        [ColumnName("Age"), LoadColumn(2)]
        public float Age { get; set; }


        [ColumnName("AnnualIncome"), LoadColumn(3)]
        public float AnnualIncome { get; set; }


        [ColumnName("SpendingScore"), LoadColumn(4)]
        public float SpendingScore { get; set; }


    }
}