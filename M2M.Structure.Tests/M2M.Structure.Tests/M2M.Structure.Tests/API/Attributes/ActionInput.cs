using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2M.Structure.Tests.API
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property)]
    public class ActionInput : Attribute
    {
        private readonly String _inputName;

        private Object _inputValue;

        public ActionInput(String inputName)
        {
            _inputName = inputName;
        }

        public String InputName
        {
            get
            {
                return _inputName;
            }
        }

        public object InputValue
        {
            get
            {
                return _inputValue;
            }
            set
            {
                _inputValue = value;
            }
        }
    }
}
