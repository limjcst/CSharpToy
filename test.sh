msbuild /t:Rebuild
mono --debug --profile=coverage:output=coverage.xml,covfilter-file=filter.txt \
    packages/NUnit.ConsoleRunner.3.8.0/tools/nunit3-console.exe \
    --inprocess CSharpToyTest/bin/Debug/CSharpToyTest.dll
