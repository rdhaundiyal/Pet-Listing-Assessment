using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGL.Assessment.Domain.Helpers;

namespace AGL.Assessment.Domain.Exceptions
{
   public class AssessmentException:Exception
    {
       public string ErrorId { get; set; }
       public AssessmentException() : base(ConfigSettings.GeneralExceptionMessage)
       {
           ErrorId = "AssessmentError";
       }

    }
}
