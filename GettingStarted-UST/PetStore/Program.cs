﻿// See https://aka.ms/new-console-template for more information
using PetStore;



Console.WriteLine("Starting of program.cs");

    Category obj = new Category();
obj.getattributes();
Tag tag = new Tag();
tag.id = 111;
Console.WriteLine("tagid=" + tag.id);
Console.WriteLine("End of program.cs");