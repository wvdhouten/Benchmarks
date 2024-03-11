// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Benchmarks.Console.Benchmarks;

BenchmarkRunner.Run<Hashing>();

Console.ReadLine();