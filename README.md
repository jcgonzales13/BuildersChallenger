# BuildersChallenge
 Challenger
1 -Executar na pasta raiz no terminal para adicionar uma migration nova.
dotnet ef migrations add Initial -c ApplicationDBContext -p src\core\DesafioBuilders.Core.Infra\ -s src\modules\DesafioBuilders.Modules.Api\


2- Executar quando ja tiver executado o projeto e o docker sql estiver ok.
dotnet ef database update -c ApplicationDBContext -p src\core\DesafioBuilders.Core.Infra\ -s src\modules\DesafioBuilders.Modules.Api\ --connection "Server=127.0.0.1,1434;Database=DesafioBuilders;uid=sa;Password=1Secure*Password1;Timeout=60;TrustServerCertificate=True;Encrypt=false"


