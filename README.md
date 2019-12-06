# Crash Test Dummy

This is a test to prove out debugging info combined with various publish flags.

The following line will create a single executable that will print a line number of an exception, but is fairly large (~67M).

~~~bash
dotnet publish -c release -r win7-x64 -p:PublishSingleFile=true -p:IncludeSymbolsInSingleFile=true -o .
~~~

The following line with create a single executable that will print no line number, but is *relatively* small (~25M).

~~~bash
dotnet publish -c release -r win7-x64 -p:PublishSingleFile=true -p:IncludeSymbolsInSingleFile=true -p:PublishTrimmed=true -o .
~~~

I would like something that will give me the best of both worlds, but I haven't found it yet.
