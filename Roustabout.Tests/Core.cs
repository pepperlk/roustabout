using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roustabout.Tests
{
    [TestClass]
    public class Core
    {
        [TestMethod]
        public void CoreInjection()
        {
            RB.Register<Class2DepOnClass1>();
            RB.Register<Class1>();
            RB.Register<Class3>();

            Class2DepOnClass1 cls2 = RB.Get<Class2DepOnClass1>();

            Assert.IsInstanceOfType(cls2.ijt, typeof(Class1));


        }


        [TestMethod]
        public void CoreInjectionStatic()
        {

            RB.Register<Class1>();
            RB.Register<Class3>();
            RB.Register<Class2DepOnClass1>(true);

            Class2DepOnClass1 cls2 = RB.Get<Class2DepOnClass1>();

            Assert.IsInstanceOfType(cls2.ijt, typeof(Class1));


        }


        [TestMethod]
        public void AutoInjection()
        {
       
            Class2DepOnClass1 cls2 = RB.Get<Class2DepOnClass1>();

            Assert.IsInstanceOfType(cls2.ijt, typeof(Class1));
        }
    }


    public class Class2DepOnClass1
    {
        public Class2DepOnClass1(Class1 cls, Class3 three)
        {
            ijt = cls;
        }

        public object ijt { get; set; }
    }

    public class Class1
    {

    }

    public class Class3
    {
        public Class3(Class1 cls)
        {
            ijt = cls;
        }

        public object ijt { get; set; }
    }

}
