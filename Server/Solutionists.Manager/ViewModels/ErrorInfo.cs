using System;
using System.Collections.Generic;
using System.Text;

namespace Solutionists.Manager.ViewModels
{
    public class ErrorInfo
    {
        public ErrorInfo()
        {
            ErrorList = new List<string>();
        }
        public bool HasErrors { get; set; }
        public List<string> ErrorList { set; get; }
    }
}
