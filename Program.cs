string[] vect = new string[] { "piranha", "vadia", "baranga" };

for(int i =0; i < vect.Length; i++)
{
    Console.WriteLine(vect[i]);
}

Console.WriteLine("__________________________________________________________________________________");

foreach(string obj in vect)
{
    Console.WriteLine(obj);//obj é um apelido, pode ser usado qualquer nome
}