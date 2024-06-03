using DevFreela.Classes.Entities;

namespace DevFreela.Infraestructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto em ASPNET Core 1", "Minha descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto em ASPNET Core 2", "Minha descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto em ASPNET Core 3", "Minha descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Lucas Felipe", "lucasdev@gmail.com", new DateTime(1999, 1, 1)),
                new User("Roberto Marks", "roberto112@gmail.com", new DateTime(1993, 2, 10)),
                new User("Joao Joao", "joao@gmail.com", new DateTime(1890, 3, 1)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQLServer")
            };


        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
