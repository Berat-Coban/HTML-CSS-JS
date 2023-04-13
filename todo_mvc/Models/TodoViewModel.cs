namespace TodoList.Models;
using TodoList.Models.Entities;
using System.ComponentModel.DataAnnotations;

public class TodoViewModel
{
    [Required(ErrorMessage ="LüTFEN Boş Geçmeyiniz")]
    public string? Title {get; set;}
    public IEnumerable<Todo>? Todos { get; set;}


}
