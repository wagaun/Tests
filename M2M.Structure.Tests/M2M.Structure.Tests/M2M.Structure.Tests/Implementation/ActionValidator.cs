using M2M.Structure.Tests.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.Implementation
{
    public class ActionValidator
    {
        public ICollection<ValidationError> Validate(Object actionObject, SystemActionRepresentation descriptor)
        {
            // TODO implementar este método
            return new List<ValidationError>();
        }

        public class ValidationError
        {
            private String _errorMessage;

            public ValidationError(String errorMessage)
            {
                _errorMessage = errorMessage;
            }
        }
    }
}
