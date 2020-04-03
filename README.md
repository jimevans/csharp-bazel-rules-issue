# csharp-bazel-rules-issue
Demo project showing compilation issue under C# Bazel rules

To reproduce the issue:
0. Clone this repo.
1. Open `BazelCompileIssue.sln` in Visual Studio.
2. Build the project and verify that it compiles.
3. At a Developer Command Prompt for Visual Studio, in the root directory of the
cloned repo, execute `bazel build //BazelCompileIssue:CompileIssue`.

While the code builds successfully in Visual Studio, it fails to build on the
command line. The types being referenced exist as part of the core library (`mscorlib`),
so it should not require any other references to build properly.