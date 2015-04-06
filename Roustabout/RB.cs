using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Roustabout
{
    public class RB
    {

        private static Dictionary<Type, object> _cache = new Dictionary<Type, object>();

        public static void Register<T>(bool keepstatic = false)
        {
            Register(typeof(T), keepstatic);
        }

        public static void Register(Type t, bool keepstatic = false)
        {
            object obj = null;
            if (keepstatic)
            {
                _cache[t] = null;
                obj = Get(t);
            }

            _cache[t] = obj;

        }

        public static T Get<T>()
        {
            return (T)Get(typeof(T));
        }

        public static object Get(Type t)
        {

            if (!_cache.ContainsKey(t))
            {

                Register(t);

            }

                if (_cache[t] != null)
                {
                    return _cache[t];
                }

                var ctor = t.GetConstructors().FirstOrDefault();
                var cparams = ctor.GetParameters();

                if (cparams.Length == 0)
                {
                    return ctor.Invoke(new object[] { });

                    //return Activator.CreateInstance(t);
                }
                else
                {
                    
                    
                    var tl = new List<object>();
                    foreach (var pt in cparams)
                    {
                        tl.Add(RB.Get(pt.ParameterType));
                    }


                    return ctor.Invoke(tl.ToArray());

                }




            

            Debug.WriteLine(string.Format("({0}) is not registered for injection", t.Name));
            throw new Exception(string.Format("Type not registered with RB use RB.Register<{0}>()", t.Name));



        }

        
    }
}
