using Microsoft.EntityFrameworkCore;


using (var db = new TodoContext())
            {
                // Assurez-vous que la base de données est créée
                db.Database.EnsureCreated();

                // Créer une nouvelle TodoList
                var todoList = new TodoList { Name = "Liste de tâches personnelles" };
                db.TodoLists.Add(todoList);
                db.SaveChanges();

                // Créer un nouveau Todo et l'ajouter à la TodoList
                var todo = new Todo { Task = "Apprendre EF Core", Completed = false, Date = DateTime.MinValue, TodoListId = todoList.Id };
                db.Todo.Add(todo);
                db.SaveChanges();

                // Mettre à jour IsCompleted et définir la date à aujourd'hui
                todo.Completed = true;
                todo.Date = DateTime.Today;

                db.SaveChanges();

                // Afficher tous les éléments Todo pour vérifier
                var todoItems = db.Todo.Include(t => t.TodoList).ToList();
                Console.WriteLine("Tous les éléments Todo:");
                foreach (var item in todoItems)
                {
                    Console.WriteLine($"Liste: {item.TodoList.Name}, Id: {item.Id}, Tâche: {item.Task}, Terminé: {item.Completed}, Date: {item.Date}");
                }
            }