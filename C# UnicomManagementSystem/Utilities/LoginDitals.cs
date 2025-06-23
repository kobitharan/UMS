using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__UnicomManagementSystem.Utilities
{
    internal class LoginDitals
    {
        private static Dictionary<string, object> _sessionData = new Dictionary<string, object>();
        public static void Set(string key, object value)
        {
            if (_sessionData.ContainsKey(key))
            {
                _sessionData[key] = value;
            }
            else
            {
                _sessionData.Add(key, value);
            }
        }

        public static object Get(string key)
        {
            return _sessionData.ContainsKey(key) ? _sessionData[key] : null;
        }
        public static void Clear()
        {
            _sessionData.Clear();
        }
    }
}
