using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solutionists.Model
{
    /// <summary>
    /// Will be used for a more complex Error Info Object
    /// </summary>
  public enum ErrorCategory
    {
        TimeOut = 0,
        NetworkIssues = 1,
        DatabaseIssues = 2
    }

    public enum ValidationType
    {
        Model = 0,
        Rules = 1,
    }

}
