
// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
//  string nome = "Paulo";
//  int idade = 17;
//  double nota = 7.5;
// Console.WriteLine(nome + " tem "+ idade + " e tirou a nota " + nota+" na prova ");
// Console.WriteLine($"{nome} tem {idade} e tirou a nota {nota} na prova  ");


// Console.WriteLine($"{nome}\n{idade}\n{nota} ");

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// ( x ) double
// ( ) long
// ( ) decimal



// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// (x ) int para long
// ( ) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal

       
        //  Console.WriteLine("Por favor, insira três letras:");

       
        //  Console.Write("1ª letra: ");
        //  char letra1 = Console.ReadKey().KeyChar;
        //  Console.WriteLine();

        //  Console.Write("2ª letra: ");
        //  char letra2 = Console.ReadKey().KeyChar;
        //  Console.WriteLine();

        //  Console.Write("3ª letra: ");
        //  char letra3 = Console.ReadKey().KeyChar;
        //  Console.WriteLine();

       
        //  Console.WriteLine("\nUsando concatenação:");
        //  Console.WriteLine("Letras na ordem reversa: " + letra3 + letra2 + letra1);

        //  Console.WriteLine("\nUsando interpolação:");
        //  Console.WriteLine($"Letras na ordem reversa: {letra3}{letra2}{letra1}");

        //  Console.ReadKey();

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// ( f) long resultado = 1.32;
// ( v) var nome = “Maria”;
// ( v) string resultado = 100.ToString();
// ( v) A sequência de escape \n inclui uma nova linha
// ( f) float f = 5.45;
// ( v) decimal valor = (decimal) 10.99f;
// ( f) var status = null;
// ( v) object o = 12.45m;
// ( v) string titulo = true.ToString();
// ( f) A sequencia \t inclui uma tabulação vertical

//  Console.WriteLine("Informe o valor de x:");
//  double x = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine("Informe o valor de y");
//  double y = Convert.ToDouble(Console.ReadLine());

//  Console.WriteLine($"Soma de x + y = {x+y}");
//  Console.WriteLine($"Subtração de x - y = {x-y}");
//  Console.WriteLine($"Multiplicação de x * y = {x*y}");
//  Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x,y)}");
//  Console.WriteLine($"Divisão de x / y = {x/y}");
//  Console.WriteLine($"Modulo de x % y = {x%y}");
//  Console.ReadKey();


// Console.WriteLine("Login, insira login e senha !");
// Console.WriteLine("Login: ");
// string? nome = Console.ReadLine();
// Console.WriteLine("Senha: ");
// int? senha = Convert.ToInt32(Console.ReadLine());

// if (nome == "Maria" || nome == "Admin") 
// {
//     if (senha == 123) 
//     {
//         Console.WriteLine("Acesso permitido");
//     }
//     else
//     {
//         Console.WriteLine("Senha incorreta"); 
//     }
// }
// else
// {
//     Console.WriteLine("Acesso negado");
// }

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Me diga 2 numeros inteiros  ");
Console.Write("Numero 1 :");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Numero 2 :");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (n1%2==0){
        Console.WriteLine($"{n1} é par ");
}
else{
        Console.WriteLine($"{n1} não é par ");
}   
if (n2%2==0){
        Console.WriteLine($"{n2} é par ");
}
else{
        Console.WriteLine($"{n2} não é par ");
}   

