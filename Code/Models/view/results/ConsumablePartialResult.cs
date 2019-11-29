﻿using Models.local.BaseClass;
using Models.result.Interfaces;
using Models.results.DAO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Models.result
{
    [Serializable]
    public class ConsumablePartialResult : ConsumablePartial, IPartialResult
    {
        //List<Consumable> Results { get; set; }
        public IList<Consumable> Results = new List<Consumable>();
        public ConsumablePartialResult()
        {
            // We need this constructor to initialize the webservice
        }

        public ConsumablePartialResult(int? resultSize, int? partialSize, int? partialStart,
                                      string sortByField, bool ascending, string query, string queryType,
                                      decimal seconds, int? pageSize, IList<Consumable> partialResult) //: base()
        {
            this.ResultSize = resultSize;
            this.PartialSize = partialSize;
            this.PartialStart = partialStart;
            this.SortByField = sortByField;
            this.Ascending = ascending;
            this.Query = query;
            this.QueryType = queryType;
            this.Results = partialResult;
            this.Seconds = seconds;
            this.PageSize = pageSize;
        }

        public List<Consumable> GetResults()
        {
            return (List<Consumable>)Results;
        }

        IList IPartialResult.Result => throw new NotImplementedException();
    }
}