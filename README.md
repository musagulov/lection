alcoCalk2

запуск тестов в консоле:

    dotnet test --logger:"junit;LogFilePath=%cd%\artifacts\test-result.xml;MethodFormat=Class;FailureBodyFormat=Verbose" --collect:"XPlat Code Coverage"

устновка покрытие отчета генератор

    dotnet tool install --global dotnet-reportgenerator-globaltool –version 4.8.11

формула расчета stage

     градус*объем/вес/(возраст если меньше 27)(54-возраст если 27<=возраст<54)  
