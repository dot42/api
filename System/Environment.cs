// Copyright (C) 2014 dot42
//
// Original filename: Environment.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Collections;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Dot42;
using JRuntime = Java.Lang.Runtime;
using JSystem = Java.Lang.System;

namespace System
{
    /// <summary>
    /// Provide information about the current environment
    /// </summary>
	public static class Environment
	{
        /// <summary>
        /// Identifies special system folders.
        /// </summary>
        public enum SpecialFolder
        {
            ApplicationData,
            CommonApplicationData,
            LocalApplicationData,
            Cookies,
            Desktop,
            Favorites,
            History,
            InternetCache,
            Programs,
            MyComputer,
            MyMusic,
            MyPictures,
            MyVideos,
            Recent,
            SendTo,
            StartMenu,
            Startup,
            System,
            Templates,
            DesktopDirectory,
            Personal,
            MyDocuments,
            ProgramFiles,
            CommonProgramFiles,
            AdminTools,
            CDBurning,
            CommonAdminTools,
            CommonDocuments,
            CommonMusic,
            CommonOemLinks,
            CommonPictures,
            CommonStartMenu,
            CommonPrograms,
            CommonStartup,
            CommonDesktopDirectory,
            CommonTemplates,
            CommonVideos,
            Fonts,
            NetworkShortcuts,
            PrinterShortcuts,
            UserProfile,
            CommonProgramFilesX86,
            ProgramFilesX86,
            Resources,
            LocalizedResources,
            SystemX86,
            Windows
        }

        /// <summary>
        /// Terminate the current process with the given exit code.
        /// </summary>
        [Inline]
        public static void Exit(int exitCode)
        {
            JSystem.Exit(exitCode);
        }

        /// <summary>
        /// Gets the value of an environment variable of the current process.
        /// </summary>
        /// <param name="variableName">The name of the environment variable</param>
        /// <returns>The value of the environment variable or null if no such variable exists</returns>
        [Inline]
        public static string GetEnvironmentVariable(string variableName)
        {
            return JSystem.Getenv(variableName);
        }

        /// <summary>
        /// Gets the newline string defined for the current environment.
        /// </summary>
        public static string NewLine
        {
            [Inline]
            get { return JSystem.GetProperty("line.separator"); }
        }

        /// <summary>
        /// Gets the number of processors on this system
        /// </summary>
        public static int ProcessorCount
        {
            [Inline]
            get { return JRuntime.GetRuntime().AvailableProcessors(); }
        }

        /// <summary>
        /// Gets the number of milliseconds since the system started.
        /// </summary>
        public static int TickCount
        {
            [Inline]
            get { return unchecked ((int)SystemClock.UptimeMillis());} 
        }

        /// <summary>
        /// Gets the amount of physical memory mapped to the process context.
        /// </summary>
        public static long WorkingSet
        {
            [Inline]
            get { return JRuntime.GetRuntime().TotalMemory(); }
        }

        /// <summary>
        /// SpecialFolder.ApplicationData will return the 
        /// '/data/data/your.package' folder.
        /// </summary>
        public static string GetFolderPath(SpecialFolder folder)
        {
            var context = Application.Context;
            if (context == null)
            {
                throw new InvalidOperationException("Android.App.Application is not propertly initialized");
            }

            switch (folder)
            {
                case SpecialFolder.ApplicationData:
                case SpecialFolder.CommonApplicationData:
                case SpecialFolder.LocalApplicationData:
                case SpecialFolder.UserProfile:
                    var pm = context.PackageManager;
                    String package = context.PackageName;
                    PackageInfo p = pm.GetPackageInfo(package, 0);
                    return p.ApplicationInfo.DataDir;
                default:
                    return "";
            }
        }
	}
}

