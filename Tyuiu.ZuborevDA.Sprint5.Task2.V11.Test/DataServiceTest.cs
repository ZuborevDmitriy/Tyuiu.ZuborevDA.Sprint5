﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZuborevDA.Sprint5.Task2.V11.Lib;

namespace Tyuiu.ZuborevDA.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\BobaBibkov\source\repos\Tyuiu.ZuborevDA.Sprint5\Tyuiu.ZuborevDA.Sprint5.Task2.V11\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
