using Domain.Entities;
using System.ComponentModel;

namespace SistemasTarefasInteligente
{
    public class TestTasks
    {
        [Fact]
        [Description("Criando tasks com sucesso")]
        public void CreateTasksWithSuccess()
        {
            var title = "Teste";
            var description = "Decrição";
            var dueDate = DateTime.Now;
            var priority = 1;
            var tags = new List<string>() { "Test1", "Test2" };

            var tasks = new Tasks(title, description, dueDate, priority, tags);

            Assert.Equal(tasks.Title, title);
            Assert.Equal(tasks.Description, description);
            Assert.Equal(tasks.DueDate, dueDate);
        }
    }
}