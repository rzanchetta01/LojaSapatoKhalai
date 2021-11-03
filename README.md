# LojaSapatoKhalai
 
 # Requisitos 
* ter sql server instalado
* entity framework core
* entity framework core.sql
* entity framework core.tools
* entity framework core.desing

# Cuidados
* Não adcionar nada que ja tenha no banco de dados (por exemplo: mesmo id)
* Não registrar nenhuma venda com um id inesistente
* Rodar o app sem terminar os passo a passos

# Configurando ambiente
1. Adicionar uma connection string sua em appSetings.json
2. Alterar em startup.cs para sua connection string no método ConfigureServices assim evitando problemas com o sql
 
# Comando de terminal pro entity framework
no visual studio -> ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes
no terminal que se abriu

1. add-migration "nome para migration"
2. update-database
