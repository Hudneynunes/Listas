using System;
using System.Collections.Generic;

List<string> list = new List<string>();  // criando uma lista de nomes

list.Add("Maria");  // Add adicionar nomes a listas de string 
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");
list.Insert(2, "Marco");  // Inserir nome na posição 2 da lista 

foreach (string item in list) {   // laço para percorrer a lista 
    Console.WriteLine(item);
}

Console.WriteLine("List size " + list.Count);  //Tamanho da lista 

string s1 = list.Find(x => x[0] == 'A');  // Achar primeiro que começa com A 
Console.WriteLine("First 'A' :  " + s1);

string s2 = list.FindLast(x => x[0] == 'A');  // Achar Ultimo que começa com A 
Console.WriteLine("Last 'A' :  " + s2);

int pos1 = list.FindIndex (x => x[0] == 'A');  // achar a posição do primeito que começa com A 
Console.WriteLine("First Position 'A' :  " + pos1);

int pos2 = list.FindLastIndex (x => x[0] == 'A');  // achar a posição do ultimo que começa com A
Console.WriteLine("Last Position 'A' :  " + pos2);

List<string> list2 = list.FindAll(x => x.Length == 5); // segunda lista recebendo nomes do tamhanho com 5 caracteres 
Console.WriteLine("----------------------------------------------");
foreach(string item in list2) {  //percorrer a lista 
    Console.WriteLine(item);
}

list.Remove("Alex"); // Remover da lista 
Console.WriteLine("----------------------------------------------");
foreach (string item in list) {   
    Console.WriteLine(item);
}

list.RemoveAll( x => x[0] == 'M');  
Console.WriteLine("----------------------------------------------");
foreach (string item in list) {
    Console.WriteLine(item);
}
