using M2M.Structure.Tests.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.Implementation
{
    public class ActionExecutorFiller
    {
        public void Fill(Object executor, SystemActionRepresentation representation, ActionExecutionContext context)
        {
            var methodInfos = executor.GetType().GetMethods().SelectMany(m => m.GetCustomAttributes(typeof(ActionInput), true));
            foreach (MethodInfo methodInfo in methodInfos)
            {
                var att = methodInfo.GetCustomAttribute(typeof(ActionInput), true);
                att.
            }
        }
    }
}
