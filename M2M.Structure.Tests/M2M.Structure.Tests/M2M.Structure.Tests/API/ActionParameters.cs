using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.API
{
    public class ActionParameters
    {
        private IDictionary<String, Object> _parameters = new Dictionary<String, Object>();

        public void AddParameter(String parameterName, Object parameterValue)
        {
            _parameters.Add(parameterName, parameterValue);
        }

        public Object Get(String parameterName)
        {
            return _parameters[parameterName];
        }

        public IEnumerable<String> GetParametersKeys()
        {
            return _parameters.Keys;
        }
    }
}
