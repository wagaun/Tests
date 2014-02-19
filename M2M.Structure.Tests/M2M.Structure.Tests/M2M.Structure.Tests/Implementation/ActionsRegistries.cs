using M2M.Structure.Tests.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.Implementation
{
    public class ActionsRegistries
    {

        private IDictionary<ActionDescriptor, Type> registries = new Dictionary<ActionDescriptor, Type>();

        public void Registry(ICollection<Type> types)
        {
            foreach(Type type in types) {
                ActionImplementor att = (ActionImplementor)type.GetCustomAttribute(typeof(ActionImplementor), true);
                var c = type.GetConstructor(new Type[0]);
                if (c != null)
                {
                    registries.Add(new ActionDescriptor(att.GetActionType(), type.Name), type);
                }
                else
                {
                    // Logo um warning. Uma classe de action deve ter um construtor default.
                }
            }
        }

        public Type GetAction(ActionType actionType, String actionName)
        {
            return registries[new ActionDescriptor(actionType, actionName)];
        }
    }

    class ActionDescriptor
    {
        private ActionType _actionType;

        private String _actionName;

        public ActionDescriptor(ActionType actionType, String actionName)
        {
            this._actionType = actionType;
            this._actionName = actionName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || (!GetType().IsInstanceOfType(obj.GetType())))
            {
                return false;
            }
            ActionDescriptor descriptor = (ActionDescriptor)obj;
            return _actionType == descriptor._actionType && _actionName == descriptor._actionName;
        }

        public override int GetHashCode()
        {
            int result = _actionType.GetHashCode();
            result = (result * 397) ^ _actionName.GetHashCode();
            return result;
        }
    }
}
