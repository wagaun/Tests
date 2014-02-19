using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.API
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ActionImplementor : Attribute
    {
        private ActionType _actionType;

        public ActionImplementor(ActionType actionType)
        {
            _actionType = actionType;
        }

        public ActionType GetActionType()
        {
            return _actionType;
        }
    }
}
