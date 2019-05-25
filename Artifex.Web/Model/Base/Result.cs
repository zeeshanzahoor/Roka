using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifexPay.Web.Model.Base
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public static OkObjectResult Create(bool Success = true, object Data = null, string Message = null)
        {
            return new OkObjectResult(new Result() {
                Data = Data,
                Message = Message,
                Success = Success
            });
        }
    }
}
