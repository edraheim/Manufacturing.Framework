﻿using System;
using System.Collections.Generic;
using Manufacturing.Framework.Dto;

namespace Manufacturing.Framework.Datasource
{
    public class RandomDatasourceRecordGenerator
    {
        private static int[] _datasources = { 1, 2, 3 };
        public static IEnumerable<DatasourceRecord> GenerateDummyData(int records)
        {
            var rand = new Random();

            for (var i = 0; i < records; i++)
            {
                var dr = new DatasourceRecord
                {
                    DatasourceId = _datasources[rand.Next(0, 2)],
                    IntervalSeconds = rand.Next(60, 3600),
                    Timestamp = DateTime.UtcNow.AddMilliseconds(i*10),
                    DataType = DatasourceRecord.DataTypeEnum.Double
                };
                dr.SetDoubleValue(rand.NextDouble() * 100000);
                yield return dr;
            }
        }
    }
}
