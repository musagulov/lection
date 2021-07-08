alcoCalk2

запуск тестов в консоле:

    dotnet test --logger:"junit;LogFilePath=%cd%\artifacts\test-result.xml;MethodFormat=Class;FailureBodyFormat=Verbose" --collect:"XPlat Code Coverage"

устновка покрытие отчета генератор

    dotnet tool install --global dotnet-reportgenerator-globaltool –version 4.8.11
