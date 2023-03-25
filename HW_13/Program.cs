using HW_13;

var task1 = new List<int> {1,2,3,4,5,6,7,8,9};
Console.WriteLine(string.Join(", ", task1.Top(30)));

var dima = new User(44, "Dima");
var ivan = new User(60, "Ivan");
var vlad = new User(22, "Vlad");
var damir = new User(23, "Damir");
var katya = new User(20, "Katya");
var vika = new User(43, "Vika");
var tanya = new User(75, "Tanya");
var victor = new User(71, "Victor");
var task2 = new List<User>{dima, ivan, vlad, damir, katya, vika, tanya, victor};
Console.WriteLine(string.Join(", ", task2.Top(50, person => person.Age)));

