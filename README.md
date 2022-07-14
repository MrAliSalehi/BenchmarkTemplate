## Benchmark Template


#### This Is A Visual Studio Template For Benchmarking Using [Benchmark.Net](https://github.com/dotnet/BenchmarkDotNet).

 ## How To Use : 

Just **Clone** This Repo And [Add](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-update-existing-templates?view=vs-2022) It To Your Vs


## Some Tip's

 - **Do Not** Run Your Benchmarks On Debug-mode/ Debugger-Attached.

- **Dot Not** Use Static Methods For Benchmarking.
- You Can Use `[MemoryDiagnoser]` Attribute  On Top Of Your Class To See Memory  Status For Benchmark,
-  - You Can Also Pass `True` If You Wish To See Gc Column's Or `False` To Ignore them.

- **`[Benchmark]`** Attribute Is Required in Top of The Methods That You Want To Benchmark It.
- You Methods Can Be **`void`**.

- **Always** Create Separated Class For Benchmark In Order To Pass it Down To `BenchmarkRunner.Run<MyClass>()`

##### also this is an real example of benchmarking in dotnet; [this repo](https://github.com/MrAliSalehi/MethodCacher) and [this file](https://github.com/MrAliSalehi/MethodCacher/blob/master/MethodCacher.Benchmark/Bench.cs).

#### Have Fun.