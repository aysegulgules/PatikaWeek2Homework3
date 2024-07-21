
int i = 0;

Console.WriteLine("Kaç defa \" Ben bir Patika'lıyım \" yazılsın? ");
int limit = int.Parse(Console.ReadLine())-1;

//while örneği
Console.WriteLine("\n while-------------\n");
while (i<=limit)
{
    Console.WriteLine($"{i + 1}- Ben bir Patika'lıyım");
    i++;
}



//do-while örneği

Console.WriteLine("\n do-while-------------\n");
i = 0;
do
{
    Console.WriteLine($"{i + 1}- Ben bir Patika'lıyım");
    i++;
}
while (i <= limit);


/*
 "while" da koşul true değil ise ekran çıktısı  yazılmamakta.

Ama "do-while" da koşul sonda olduğu için ekran çıktısı bir defa yazılmakta.
 
 */