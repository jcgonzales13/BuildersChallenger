# BuildersChallenge
 Challenger
1 -Executar na pasta raiz no terminal para adicionar uma migration nova.
dotnet ef migrations add Initial -c ApplicationDBContext -p src\core\DesafioBuilders.Core.Infra\ -s src\modules\DesafioBuilders.Modules.Api\


2- Executar quando ja tiver executado o projeto e o docker sql estiver ok.
dotnet ef database update -c ApplicationDBContext -p src\core\DesafioBuilders.Core.Infra\ -s src\modules\DesafioBuilders.Modules.Api\ --connection "Server=127.0.0.1,1434;Database=DesafioBuilders;uid=sa;Password=1Secure*Password1;Timeout=60;TrustServerCertificate=True;Encrypt=false"




- Credenciais para usuar no swagger 
    - client_id: `bd753592-cf9b-4d1a-96b9-cb8b2c01bd12`
    - client_secret: `4e8229fe-1131-439c-9846-799895a8be5b`
    
    
Codigo boleto utilizad    
Code 1:   `34191790010104351004791020150008291070026000`

Code 2:  `34191790010104351004791020150008191070069000`

Code 3:  `34199800020104352008771020110004191070010000`

Code 4:  `34197650070104357008271020110004991070040000`
