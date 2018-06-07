using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            if (workflow == null)
            {
                throw new ArgumentNullException(nameof(workflow));
            }

            foreach (var activity in workflow.Activities)
            {
                activity.Execute();
            }
        }
    }
}
