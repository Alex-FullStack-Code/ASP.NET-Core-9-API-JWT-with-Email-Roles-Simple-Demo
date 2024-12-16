namespace AuthCore.Models;

public record User(Guid Id, string Name, string Email, string Password, string[] Roles);
//record: Classes are mutable, while records are immutable: - This means that once you create an instance of a class, 
//    you can change its properties.However, once you create an instance of a record, you cannot change its properties.
