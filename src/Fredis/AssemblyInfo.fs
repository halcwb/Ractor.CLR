﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Fredis")>]
[<assembly: AssemblyProductAttribute("Fredis")>]
[<assembly: AssemblyDescriptionAttribute("F# Redis client")>]
[<assembly: AssemblyVersionAttribute("0.0.5")>]
[<assembly: AssemblyFileVersionAttribute("0.0.5")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.5"
