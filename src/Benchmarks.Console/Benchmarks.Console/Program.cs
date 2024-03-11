using BenchmarkDotNet.Running;
using Benchmarks.Console.Benchmarks;

BenchmarkRunner.Run<Hashing>();

Console.ReadLine();