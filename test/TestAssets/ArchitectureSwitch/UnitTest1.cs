﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectNetcore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           foreach(DictionaryEntry  envVar in Environment.GetEnvironmentVariables())
           {
               if(envVar.Key.ToString().StartsWith("DOTNET_ROOT"))
               {
                    Console.WriteLine($"{envVar.Key}: {envVar.Value.ToString()}");
               }
           }

           Console.WriteLine("OSArchitecture: " + RuntimeInformation.OSArchitecture.ToString());
           Console.WriteLine("ProcessArchitecture: " + RuntimeInformation.ProcessArchitecture.ToString());
           Console.WriteLine("Runtime location: " + typeof(object).Assembly.Location);
           Assert.IsTrue(false);
        }
    }
}
