﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZuborevDA.Sprint5.Task1.V28.Lib;

namespace Tyuiu.ZuborevDA.Sprint5.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\BobaBibkov\source\repos\Tyuiu.ZuborevDA.Sprint5\Tyuiu.ZuborevDA.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
