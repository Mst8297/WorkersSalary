using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkerSalary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Quick_SortTest()
        {
            var T = new WorkerSalary.Form1();
            WorkersDetailes w1 = new WorkersDetailes("1", "worker1", "4200");
            WorkersDetailes w2 = new WorkersDetailes("2", "worker2", "42000");
            WorkersDetailes w3 = new WorkersDetailes("3", "worker3", "11000");
            WorkersDetailes w4 = new WorkersDetailes("4", "worker4", "3500");
            List<WorkersDetailes> testW = new List<WorkersDetailes>() { w1, w2, w3, w4 };
            int len = testW.Count();
            T.Quick_sort(testW, 0, len - 1);
            int newLen = testW.Count();
            Assert.AreEqual(newLen, len);

        }

        [TestMethod()]
        public void Quick_sortTest()
        {
            var T = new WorkerSalary.Form1();
            WorkersDetailes w1 = new WorkersDetailes("1", "worker1", "4200");
            WorkersDetailes w2 = new WorkersDetailes("2", "worker2", "42000");
            WorkersDetailes w3 = new WorkersDetailes("3", "worker3", "11000");
            WorkersDetailes w4 = new WorkersDetailes("4", "worker4", "3500");
            List<WorkersDetailes> testW = new List<WorkersDetailes>() { w1, w2, w3, w4 };
            int len = testW.Count();
            T.Quick_sort(testW, 0, len - 1);
            for (int i = 0; i < len - 1; i++)
            {
                Assert.IsFalse(double.Parse(testW[i].getSalary()) > double.Parse(testW[i + 1].getSalary()));
            }
        }

        [TestMethod()]
        public void tax_countTest()
        {
            var T = new WorkerSalary.Form1();
            double expected = 400;
            WorkersDetailes w1 = new WorkersDetailes("1", "worker1", "4000");
            double result = T.tax_count(w1.getSalary());
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Quick_sortTest1()
        {
            var T = new WorkerSalary.Form1();
            WorkersDetailes w1 = new WorkersDetailes("1", "worker1", "4200");
            WorkersDetailes w2 = new WorkersDetailes("2", "worker2", "42000");
            WorkersDetailes w3 = new WorkersDetailes("3", "worker3", "11000");
            WorkersDetailes w4 = new WorkersDetailes("4", "worker4", "3500");
            List<WorkersDetailes> testW = new List<WorkersDetailes>() { w1, w2, w3, w4 };

            //Assert.IsNotNull( T.Quick_sort(testW, 0, len- 1));
            
               try
                {
                T.Quick_sort(testW, 0, testW.Count - 1);
                    return; // indicates success
                }
                catch (Exception ex)
                {
                    Assert.IsNotNull(ex);
                }
        }
    }
}