﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace Odevdeneme
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"Yellow Cards", @"Yellow Cards"),new InputOutputColumnPair(@"Red Cards", @"Red Cards")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Name", @"Name"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Position", @"Position"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Age", @"Age"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Country", @"Country"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Club", @"Club"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Goals", @"Goals"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"Assists", @"Assists"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"Yellow Cards",@"Red Cards",@"Name",@"Position",@"Age",@"Country",@"Club",@"Goals",@"Assists"}))      
                                    .Append(mlContext.Regression.Trainers.FastForest(new FastForestRegressionTrainer.Options(){NumberOfTrees=4,FeatureFraction=1F,LabelColumnName=@"Markey Value In Millions(£)",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
