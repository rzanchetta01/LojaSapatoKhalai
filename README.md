# LojaSapatoKhalai
 
 #Requisitos 
ter sql server instalado
entity framework core
entity framework core.sql
entity framework core.tools
entity framework core.desing

#Configurando ambiente
1º Adicionar uma connection string sua em appSetings.json
2º Alterar em startup.cs para sua connection string no método ConfigureServices
exemplo: 
antes:
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddControllersWithViews();
        }
depois:
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("RodrigoConnection"))
            );
            services.AddControllersWithViews();
        }
 
 Assim evitando problemas com o sql
 
 #Comando de terminal pro entity framework
 no visual studio -> ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes
 no terminal que se abriu
 
 1º -> add-migration "nome para migration"
 semelhante a um commit do git
 2 --> update-database
 para salvar no seu database local as alterações feitas
