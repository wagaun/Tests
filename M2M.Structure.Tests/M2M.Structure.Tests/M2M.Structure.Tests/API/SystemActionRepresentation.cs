using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.API
{
    public class SystemActionRepresentation
    {
        private ActionType _actionType;

        private String _actionName;

        private ActionParameters _actionParameters;

        public SystemActionRepresentation(ActionType actionType, String actionName)
        {
            this._actionType = actionType;
            this._actionName = actionName;
            this._actionParameters = new ActionParameters();
        }

        public ActionType ActionType
        {
            get
            {
                return _actionType;
            }
        }

        public String ActionName
        {
            get
            {
                return _actionName;
            }
        }


        public void AddParameter(String name, Object param)
        {
            _actionParameters.AddParameter(name, param);
        }

        public IEnumerable<String> GetParametersKeys()
        {
            return _actionParameters.GetParametersKeys();
        }

        public Object GetParameter(String name)
        {
            return _actionParameters.Get(name);
        }
    }
}
