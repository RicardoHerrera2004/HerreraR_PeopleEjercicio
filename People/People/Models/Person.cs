﻿using SQLite;
namespace People.Models;
[Table("personas")]
public class Person
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [MaxLength(250), Unique]
    public string Name { get; set; }
}
