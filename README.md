# Teste De criação de API 

Este é meu repositório para demonstrar as minhas habilidades de criação de API.

## Objetivo
API criada em **C# ASP .NET Core 3.1** conectada a um banco de dados **SQL Server** e publicada no **Microsoft Azure**.

## Implementações
API **ASP. NET Core 3.1** com documentação ***SWAGGER***

## Estrutura do projeto
A estrutura do projeto é composta pela **Controller**,  camada de validação (**Validations**), camada de Mapeamento (**Mapper**), camada de acesso a dado (**DA**) e uma camada também para regra de negócios (**Business**). Foi utilizado o **Scaffold**  para mapear o banco para o *Entity Framework*.

# *Como testar!*
Acesse o link onde a API está hospedada: ***https://testedeapiapi20210521160948.azurewebsites.net/swagger/index.html***

Deve aparecer esta interface
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/pagina%20inicial%20swagger.png?raw=true)

Para testar se API está funcionando clique no primeiro **GET** da **Health**.

![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/teste%20heath%20da%20api.png?raw=true)

Clique em ***Try it out***.
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/testar%20heath%20da%20api.png?raw=true)

Agora é só clicar em ***"Execute"*** para testar.
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/testar%20heath%20da%20api%282%29.png?raw=true)

Caso retorne a mensagem ***"OK"*** a API está funcionando e já podemos começar a testar o *CRUD*.

![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/testar%20heath%20da%20api%283%29.png?raw=true)


Para **inserir um paciente**  clique em **POST**
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Inserir%20paciente.png?raw=true)

Em seguida clique em ***Try it out*** e insira as informações do paciente como no exemplo. Antes de clicar em ***"Execute"*** para enviar as informações certifique-se que está dentro das **validações** descritas a cima do campo.

![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Inserir%20paciente%281%29.png?raw=true)

Para **Listar os pacientes**  clique no primeiro **GET** de **Paciente**.
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Listas%20pacientes.png?raw=true)

Em seguida clique em ***Try it out*** e insira a **quantidade de pacientes de deseja pular**, a **quantidade que deseja listar**, se deseja contar a **quantidade de pacientes no banco**, se deseja trazer apenas os **usuários ativos ou inativos** e caso queira **pesquisar pelo nome** de um paciente inserir sua pesquisa no campo pesquisa. Para finalizar clique em ***"Execute"*** , a lista de pacientes aparecerá logo a baixo.

![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Lista%20pacientes%282%29.png?raw=true)

Para Pegar apenas um ***"paciente específico"*** clique no *segundo* **GET** do paciente.
![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Get%20paciente.png?raw=true)

Em seguida clique em ***Try it out*** e insira o **"ID do paciente"** que deseja pegar, para finalizar clique em ***"Execute"*** , as informações do paciente aparecerá logo a baixo.

![enter image description here](https://github.com/leonellp/TesteDeAPI/blob/master/readmeImagens/Get%20paciente%281%29.png?raw=true)

Para **Editar um paciente** clique em **PUT** em seguida clique em ***Try it out*** e insira o **"ID do paciente"** que deseja atualizar. Assim como no **Inserir** basta colocar as informações no campo, dentro das validações descritas. Não esquecer de adicionar o id do paciente no campo ***"idpaciente"*** .

Para **Inativar** um paciente basta clicar em ***"DELETE"*** e seguir os mesmos passos de ***pegar um paciente específico*** informando o ***Id do paciente*** a ser inativado.
