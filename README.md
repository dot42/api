api
============================

The api consists of all the C# classes that implement both the Android API classes (such as ``Android.Opengl.GLSurfaceView`` that corresponds to Java class ``android.opengl.GLSurfaceView``) and .NET API classes (such as ``System.Linq.Enumerable``.)

Android API
----------------------------
The Android classes are *generated* from the binary Android distribution (android.jar). For this reason, dot42 supports the *entire* Android API. The Android API classes can be found in the api\Generated\v4.0.3 folder. You will see that these classes are actually proxies. These proxy classes allow you to code against the Android API in C#. They bind to the actual implementation in android.jar using attributes. See for example Android.Bluetooth.cs. The dot42 compiler replaces calls to these classes with the proper DEX code that invokes android.jar. You should not modify any code in the Generated folder.

.NET API
----------------------------
The .NET classes are *handcrafted* on top of the Android classes. For this reason, dot42 supports only *part* of the .NET API. This repository allows you to contribute to the supported set. Take a look at how for example ``System.Collections.Stack`` is implemented on top of ``java.util.ArrayList`` in api\System\Collections\Stack.cs.

Build the api
----------------------------
1. clone this repository
2. open api\Framework.sln in Visual Studio 2010, 2012 or 2013
3. make any changes you want
4. build the solution
5. copy api\Build\Application\Frameworks\v4.0.3\dot42.dll to Program Files\dot42\Android\Frameworks\v4.0.3

Test your api changes
----------------------------
1. create a new dot42 project and select 4.0.3 as the target framework
2. code against the new or modified parts of the .NET API
3. compile and run on your device

Note
----------------------------
The versions of the API and Dot42 must match for this to work. Therefore the repository is labeled in the same way as the release numbers of Dot42. So make sure you have the correct combination of Dot42 and the API. Of course we advise you to use the latest version of DOT42 with the matching version of the API from the master branch. If you are using a version of DOT42 older than 1.0.1.78, you need to update first for this to work.