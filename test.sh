mkdir -p OpenCover
packages/OpenCover.4.6.519/tools/OpenCover.Console.exe -register:user -target:packages/NUnit.ConsoleRunner.3.8.0/tools/nunit3-console.exe -targetargs:CSharpToyTest/CSharpToyTest.csproj -filter:+[CSharpToy]*+[Test]* -output:Opencover/results.xml
