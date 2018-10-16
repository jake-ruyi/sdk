# UE4 Integration

Details how we integrated Ruyi C++ SDK with [Unreal Engine 4](https://www.unrealengine.com/en-US/) for the [UE4 demo](https://bitbucket.org/playruyi/unreal_demo) and [platformer game](https://bitbucket.org/playruyi/platformer_game).

## Prerequisites

- See [prerequisites for C++ SDK](cplusplus.md#Prerequsites)
- Unreal Engine 18 (4.18), Compiled version

## Download SDK from developer website Instructions

1. You can download our sdk from [here](https://github.com/subor/sdk/releases/).  Our SDK files will be in two folders: __include__ and __lib__.  Put them in one of your game module source folder.  For example, `source/ModuleName/include` and `source/ModuleName/lib`.  They may be put in a sub-folder, just make sure they're in the same folder.
1. Open __ModuleName.Build.cs__ and add `ModuleName/xxx/include` to the `PublicIncludePaths` property.  For example:

        PublicIncludePaths.AddRange(
            new string[] {
                "ModuleName/include",
            }
        );

1. Add `using System.IO;` to the top of the file.  Bind lib path with:

        private string ModulePath
        {
            get { return ModuleDirectory; }
        }

        private string LibPath
        {
            get { return Path.GetFullPath(Path.Combine(ModulePath, "xxx/lib/")); }
        }

1. Add the following to the same function:

        PublicDelayLoadDLLs.Add(Path.Combine(LibPath, "zmq", "libzmq.dll"));

        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "RuyiSDK.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "zmq", "libzmq.lib"));

        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_chrono-vc141-mt-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_chrono-vc141-mt-gd-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_date_time-vc141-mt-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_date_time-vc141-mt-gd-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_system-vc141-mt-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_system-vc141-mt-gd-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_thread-vc141-mt-1_64.lib"));
        PublicAdditionalLibraries.Add(Path.Combine(LibPath, "boost", "libboost_thread-vc141-mt-gd-1_64.lib"));

1. Copy `lib/zmq/libzmq.dll` to the build output folder.  For example, `Binaries/Win64`.
1. Open your project with Unreal Engine 4 Editor.  Click __File -> Refresh Visual Studio Project__ (or right-click __xxxxx.uproject__ file and click __Generate visual studio project file__).  Wait for it to finish, then reload your Visual Studio project and you will find __include__ and __lib__ folders in _Solution Explorer_ (click __View -> Solution Explorer__).
1. When using SDK functions, include `RuyiSDK.h` and use apprpropriate namespaces (like `Ruyi::RuyiSDK`).  Refer to the [UE4 sample](https://bitbucket.org/playruyi/unreal_demo) and [SDK documentation](http://dev.playruyi.com/api) for API details.
1. Build your project.

## Download sdk_source repo Instructions

You can also download the SDK from our [sdk_source](https://bitbucket.org/playruyi/sdk_source) repository.

1. Download the sdk_source repo.

1. Download the third-party libraries using the provided link.  Unpack it, copy the __externals__ folder to the same level of your __sdk_source__ folder.
  
1. Build the "RuyiSDKCpp" solution.

1. Go to "RuyiSDKCpp\bin\Release", copy the __include__ and __lib__ folder to your main module.

1. The rest is just the same as the insturction of downloading sdk from website.

## Common Issues

- Since the sdk uses [boost](http://www.boost.org/), you may encounter `error LNK2038: mismatch detected for 'boost__type_index__abi': value 'RTTI is used'`.  You can solve this by adding `bUseRTTI = true;` to __xxxx.build.cs__.

- Similarly: `Error C4577: 'noexcept' used with no exception handling mode specified`.  You can solve this by adding `bEnableExceptions = true;` to __xxx.build.cs__.

- if you have problem like below:

![](/docs/img/unreal_compile_01.png)

  this is the problem cause by using v140 toolset in UE4.18.
  you can use generate your VS porject file in cmd by add "-2017" param 
  "UnrealBuildTool.exe -projectfiles -project="C:/XXX.uproject" -game -engine -progress -2017"
  if it stills use v140 toolset, do as below:
  1 Open Registry Editor by input "regedit" in Search Window  
  2 enter path "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\SxS\VC7"
  3 Normally there is "14.0" and "15.0" key
  value of "14.0" should be "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC” 
  “15.0” should be ”C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\VC"
  please delete "14.0", leave "15.0". If there is no "15.0", add one or modify
  
  ![](/docs/img/unreal_compile_02.png)
  
  4 re-generate the project file in cmd, note "-2017" is needed
  5 open the sln project file, compile it, it should work fine.
  6 you can add the "14.0" key back after you generate the porject file