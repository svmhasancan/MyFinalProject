﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this -> result olduğu için alttakı kodun anlamı : result'ın tek parametreli olan constructor'ına success'i yolla.Yani bu constructor çalıştığında diğer constructor da çalışmış olacak bu yüzden success işlemini orda yaptık.
        public Result(bool success, string message):this(success)
        {
            Message = message;
            //Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}