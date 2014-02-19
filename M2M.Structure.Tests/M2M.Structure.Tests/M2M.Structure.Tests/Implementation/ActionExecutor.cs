using M2M.Structure.Tests.API;
using M2M.Structure.Tests.API.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace M2M.Structure.Tests.Implementation
{
    public class ActionExecutor
    {
        private ActionFactory _actionFactory;

        private ActionValidator _actionValidator;

        public ActionExecutor(ActionFactory actionFactory)
        {
            _actionFactory = actionFactory;
        }

        public void Execute(SystemActionRepresentation actionRepresentation, ActionExecutionContext exectionContext)
        {
            var actionObject = _actionFactory.CreateActionObject(actionRepresentation, exectionContext);
            _actionValidator.Validate(actionObject, actionRepresentation);
            var methods = actionObject.GetType().GetMethods().SelectMany(m => m.GetCustomAttributes(typeof(Execution), true));
            foreach (MethodInfo method in methods)
            {
                method.Invoke(actionObject, new object[0]);
            }
        }
    }
}
