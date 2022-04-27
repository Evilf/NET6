using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.MainClasses
{
    public class DataContext : INotifyPropertyChanged
    {
        private Dictionary<string, object> _properties = new Dictionary<string, object>();

        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        protected dynamic Get([CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");
            object value = null;

            if (_properties.TryGetValue(name, out value))
                return value == null ? default : value;

            return default;
        }

        protected dynamic Get<T>([CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");

            try
            {
                return _properties[name];
            }
            catch
            {
                return GetTypeDefaultValue(typeof(T));
            }
        }

        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="name"></param>
        protected void Set<T>(T value, [CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");

            if (Equals(value, Get(name)))
                return;

            _properties[name] = value;
            OnPropertyChanged(name);
        }
        #region PRIVATE METHODS
        private object GetTypeDefaultValue(Type type)
        {
            if (type.IsValueType)
                return Activator.CreateInstance(type);
            else
                return null;
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
