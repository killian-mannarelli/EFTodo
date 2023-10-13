using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class TodoList
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Todo> Todos { get; set; } = new List<Todo>();
}