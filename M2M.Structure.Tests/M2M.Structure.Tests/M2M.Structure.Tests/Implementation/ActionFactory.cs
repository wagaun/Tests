using M2M.Structure.Tests.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.Implementation
{
    public class ActionFactory
    {
        private ActionsRegistries _registries;

        private ActionExecutorFiller _executionFiller;

        public ActionFactory(ActionsRegistries registries, ActionExecutorFiller executionFiller)
        {
            _registries = registries;
            _executionFiller = executionFiller;
        }

        public Object CreateActionObject(SystemActionRepresentation representation, ActionExecutionContext context) {
            var actionType = _registries.GetAction(representation.ActionType, representation.ActionName);
            var action = actionType.GetConstructor(new Type[0]).Invoke(new Object[0]);

            // Fill action properties
            _executionFiller.Fill(action, representation, context);
            return action;
        }
    }
}
