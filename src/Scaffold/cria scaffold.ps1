dotnet ef dbcontext scaffold "Server = localhost,5434; Database = testedeapidb; User Id = sa; Password = Abcd@1234" Microsoft.EntityFrameworkCore.SqlServer -o ..\testedeapi.DA.Abstractions\Models -n testedeapi.DA.Abstractions.Models -f -c testedeapiContext --context-dir ..\testedeapi.DA --context-namespace testedeapi.DA --use-database-names --no-pluralize

