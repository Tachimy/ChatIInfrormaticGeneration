using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.IO;
namespace TestUI
{
    public class DataItem
    {
        [LoadColumn(0)]
        public string Query { get; set; }

        [LoadColumn(1)]
        public string Description { get; set; }
    }

    public class DataItemPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Description { get; set; }
    }

    public class MLService
    {
        private readonly MLContext _mlContext;
        private PredictionEngine<DataItem, DataItemPrediction> _predictionEngine;

        public MLService()
        {
            _mlContext = new MLContext();
        }

        private void InitializeModel()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "datalearn.txt");
            var data = _mlContext.Data.LoadFromTextFile<DataItem>(path, separatorChar: ',');
            var trainTestData = _mlContext.Data.TrainTestSplit(data, testFraction: 0.9);
            var trainData = trainTestData.TrainSet;

            var inputColumns = new[] { nameof(DataItem.Query) };
            var labelColumn = nameof(DataItem.Description);

            var dataProcessPipeline = _mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "Label", inputColumnName: labelColumn)
                .Append(_mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: nameof(DataItem.Query)));

            var trainer = _mlContext.MulticlassClassification.Trainers.SdcaNonCalibrated();
            var trainingPipeline = dataProcessPipeline.Append(trainer).Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = trainingPipeline.Fit(trainData);

            _predictionEngine = _mlContext.Model.CreatePredictionEngine<DataItem, DataItemPrediction>(model);
        }

        public async Task<string> RunPredictionAsync(string query)
        {
            if (_predictionEngine == null)
            {
                InitializeModel();
            }

            return await Task.Run(() =>
            {
                var input = new DataItem { Query = query };
                var prediction = _predictionEngine.Predict(input);

                return prediction.Description;
            });
        }
    }
}
