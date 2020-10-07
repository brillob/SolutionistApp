using System;
using System.Collections.Generic;
using System.Text;

namespace Solutionists.Manager.ViewModels
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            ErrorInfo = new ErrorInfo();
        }
        public object ObjectValue { set; get; }
        public string Message { set; get; }
        public int ReferenceId { set; get; }
        public ErrorInfo ErrorInfo { set; get; }
        
       
       
    }
}
