using System;
using System.ComponentModel.DataAnnotations;

public class Todo
{
    [Key]
    public int Id { get; set; }

    public string? Task { get; set; }

    public bool Completed { get; set; }

    public DateTime Date { get; set; }

    public int TodoListId { get; set; } 
    public TodoList? TodoList { get; set; } 
}

