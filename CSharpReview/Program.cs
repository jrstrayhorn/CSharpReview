using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();

            workflow.Activities.Add(new UploadVideoActivity());
            workflow.Activities.Add(new CallWebServiceActivity());
            workflow.Activities.Add(new SendEmailActivity());
            workflow.Activities.Add(new ChangeVideoStatusActivity());

            var workflowEngine = new WorkflowEngine();

            workflowEngine.Run(workflow);
        }
    }
}
