using System;
using System.Globalization;
/*
# Instalar o SDK
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-7.0

# Instalar o runtime
sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-7.0
--------------------------------------------

dotnet new console -o <Nome da pasta> --use-program-main


mins e max
int.MinValue
int.MaxValue
etc
Overflow - quando um calculo extrapola o limitecda variavel

Complemento a dois

L para long

Convencoes
camelCase: lastName(parametros de metodos, variaveis dentro de metodos)

Pascal case:
                LastName(namespaces, classe, properties e metodos)

Padrao _lastName(atributos "internos" da classe)

Conversao implicita e casting


-- Estrutura basica
>Projeto CSharp é uma solução.(ex.:Arquivo.sln)
>Configuração do projeto(ex.: >PrimeiroProjeto.csproj)
>bin e obj guardam os arquivos compilados

static void Main(string[] args) //Entrepoint
{




*/
// -----------------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------
// -------------------------------------------       ---------------------------------------
// ------------------------------------------ SEÇÃO 3 --------------------------------------
// -------------------------------------------       ---------------------------------------
// -----------------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------

//Camel Case: lastName - parâmetros de metodos, variáveis dentro de métodos
//Pascal Case: LastName - namespaces, classes, properties e metodos
//Padrão: _lastName - atributos "internos" da classe

// Pascal Case
namespace Example
{
	class BankAccount
	{
		//Pascal Case
		public string Holder { get; set }

		private double _balance;

		//Pascal Case / Camel Case
		public void Deposit(double amount)
		{
			_balance += amount;
		}

		public double GetBalance()
		{
			return _balance;
		}
	}
}

/* - Estrutura Sequencial - */

bool completo = false;
char genero = 'F';
char letra = '\u0041';
byte n1 = 126;
int n2 = 1000;
int n3 = 2147483647;
long n4 = 2147483648L;
float n5 = 4.5f;
double n6 = 4.5;
String nome = "Maria Green";
Object obj1 = "Alex Brown";
Object obj2 = 4.5f;

Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(letra);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(nome);
Console.WriteLine(obj1);
Console.WriteLine(obj2);



// Conversãop implícita e Casting

double num1 = 5.1;
float num2 = (float)num1; //Casting

double result = (double)num1 / num2;

// Placeholders, Concatenação e Interpolação
String name = "Maria";
int age = 22;
double balance = 10.35784;

//Placeholder
Console.WriteLine("{0} have {1}years old and was balance equals {2:F2} Reals", name, age, balance);

//Interpolação
Console.WriteLine($"{name} have {age} years old and was balance equals {balance:F2} Reals");

//Concatenação
Console.WriteLine(name + " have " + age + " years old and was balance equals " + balance + " Reals");


// -----------------------------------------------------------------------------------------
// ----------------------------------------Ex 1---------------------------------------------

string product1 = "Computer";
string product2 = "Office Desk";

byte age2 = 30;
int code = 5290;
char gender = 'M';
double price1 = 2100.0;
double price2 = 650.50;
double measure = 53.234567;

Console.WriteLine("Products:");
Console.WriteLine($"{product1}, whose price is ${price1}");
Console.WriteLine($"{product2}, whose price is ${price2}");

Console.WriteLine($"Register: {age} years old, code {code} and gender: {gender}");

Console.WriteLine();

Console.WriteLine($"Measure with eight decimal places:{measure}");
Console.WriteLine("Rounded(With tree decimal places):{0:F3}", measure);
Console.WriteLine("Decimal separator invariant culture:" + measure.ToString("F3", CultureInfo.InvariantCulture);
// -----------------------------------------------------------------------------------------

//Operadores aritméticos
int num2 = 3 + 4 * 2;
int num3 = (3 + 4) * 2;
int num4 = 17 % 3;
double num5 = 10.0 / 8.0;

double a = 1.0, b = -3.0, c = -4.0;
double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

Console.WriteLine(num2);
Console.WriteLine(num3);
Console.WriteLine(num4);
Console.WriteLine(num5);

Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);

//Operadores de atribuição
int num6 = 10;
Console.WriteLine(a);

num6 += 2;
Console.WriteLine(a);

num6 *= 3;
Console.WriteLine(a);

string str1 = "ABC";
Console.WriteLine(str1);

str1 += "DEF";
Console.WriteLine(str1);

//Operadores aritméticos / atribuição
//Operador ++ e --

//a = a + 1;
//a = a - 1;

int num7 = 10;
num7++; //Result: 11

int num8;
num8 = num7++; //num7 - 11 e num8 - 10
num8 = ++num8 //num7 e num8 - 11

//Entrada de dados em C#

//Lê da entrada padrão até a quebra de linha.
//Retorna os dados lidos na forma de string
string str2 = Console.ReadLine();

//Split
string str3 = Console.ReadLine();
string[] vector = str3.Split(' ');
string pt1 = vector[0];
string pt2 = vector[1];
string pt3 = vector[2];

string phrase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

Console.WriteLine("You typed:");
Console.WriteLine(phrase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine("With Split:");
Console.WriteLine(pt1);
Console.WriteLine(pt2);
Console.WriteLine(pt3);
/*
• int.MinValue
• int.MaxValue
• sbyte.MaxValue
• long.MaxValue
• decimal.MaxValue
etc
*/


// Parte 2
string str4 = ReadLine();

string[] vector2 = Console.ReadLine().split(' ');
string name2 = vector[0];
char gender2 = char.Parse(vector[1]);
int age2 = int.Parse(vector[2]);
double height2 = double.Parse(vector[3].CultureInfo.InvariantCulture);

Console.WriteLine(name2);
Console.WriteLine(gender2);
Console.WriteLine(age2);
Console.WriteLine(height2.ToString("F2", CultureInfo.InvariantCulture);


// -----------------------------------------------------------------------------------------
// ----------------------------------------Ex 2---------------------------------------------
Console.Write("Enter with your complete name:");
string fullName = Console.ReadLine();

Console.Write("How many rooms do you have in your house?");
int bedRooms = int.Parse(Console.ReadLine());

Console.Write("Enter the price of a product:");
double priceProduct = double.Parse(Console.ReadLine());

Console.Write("Enter with your last name, age and height(same line)");
string[] data = Console.ReadLine().Split(' ');

string lastName = data[0];
int age3 = int.Parse(data[1]);
double height2 = double.Parse(data[2], CultureInfo.InvarianteCulture);

Console.WriteLine(fullName);
Console.WriteLine(bedRooms);
Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(lastName);
Console.WriteLine(age3);
Console.WriteLine(height2.ToString("F2", CultureInfo.InvariantCulture));


//Console.WriteLine($"{fullName}\n{bedRooms}");
//Console.WriteLine($"{lastName}\n{age3}\n{height2}");


//Ex3 - Sum - Ok

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

sum = number1 + number2;

Console.WriteLine($"SUM={sum}");

// Correções
-Esqueci apenas de dar o tipo para sum.
// -----------------------------------------------------------------------------------------

//Ex4 - CircleRadius - Ok
double radius = double.Parse(Console.ReadLine());
double PI = 3.14159;

double area = PI * Math.Pow(radius, 2);
Console.WriteLine("A=" + ToString("F4", CultureInfo.InvariantCulture));

// Correções
CultureInfo na variavel radius
Calculo para resolver o valor da area
// -----------------------------------------------------------------------------------------


//Ex5 - FourValues - Ok
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

int difference = (a * b - c * d);
Console.WriteLine($"DIFFERENCE={difference}");
// -----------------------------------------------------------------------------------------

//Ex6 - Employee - Ok
int code = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());
double salaryPerHour = double.Parse(Console.ReadLine());

double calc = workHours * salaryPerHour;

Console.WriteLine("NUMBER = " + code + "\nSALARY = U$" + calc);

//Correções
Esqueci de colocar CultureInfo na salaryPerHour e no calc
// -----------------------------------------------------------------------------------------

//Ex7 - Parts
Console.WriteLine("Parts 1:")
int codePart1 = int.Parse(Console.ReadLine());
int qttPart1 = int.Parse(Console.ReadLine());
double pricePart1 = double.Parse(Console.ReadLine());

double calcPart1 = qttPart1 * pricePart1;

Console.WriteLine("Parts 2:")
int codePart2 = int.Parse(Console.ReadLine());
int qttPart2 = int.Parse(Console.ReadLine());
double pricePart2 = double.Parse(Console.ReadLine());

double calcPart2 = qttPart2 * pricePart2;

double totalToPay = calcPart1 + calcPart2;
Console.WriteLine("Value to pay R${totalToPay}");
//Correções
Esqueci apenas a CultureInfo
// -----------------------------------------------------------------------------------------

//Ex8 - TreeValuesFloat
float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());
float c = float.Parse(Console.ReadLine());

float triangle = a * c / 2.0;
float circle = 3.14159 * c * c;
float trapeze = (a + b) / 2.0 * c;
float square = b * b
float rectangle = a * b;

Console.WriteLine("TRIANGLE = " + triangle.ToString("F3", CultureInfo.InvariantCulture)));
Console.WriteLine("CIRCLE = " + circle.ToString("F3", CultureInfo.InvariantCulture)));
Console.WriteLine("TRAPEZE = " + trapeze.ToString("F3", CultureInfo.InvariantCulture)));
Console.WriteLine("SQUARE = " + square.ToString("F3", CultureInfo.InvariantCulture)));
Console.WriteLine("RECTANGLE = " + rectangle.ToString("F3", CultureInfo.InvariantCulture));

//Correções
CultureInfo e a falta do calculo do retangulo
// -----------------------------------------------------------------------------------------

// Operadores Comparativos
int num11 = 10;
bool num12 = num1 < 10;
bool num13 = num1 < 20;
bool num14 = num1 > 10;
bool num15 = num1 > 5;
Console.WriteLine(num12);
Console.WriteLine(num13);
Console.WriteLine(num14);
Console.WriteLine(num15);

Console.WriteLine("------------------------------------");

bool num15 = num1 <= 10;
bool num16 = num1 >= 20;
bool num17 = num1 == 10;
bool num18 = num1 != 10;
Console.WriteLine(num15);
Console.WriteLine(num16);
Console.WriteLine(num17);
Console.WriteLine(num18);


//Operadores lógicos
bool num19 = 2 > 3 || 4 != 5; //True
bool num20 = !(2 > 3) && 4 != 5 // True
bool num21 = 10 < 5; //False
bool num22 = num19 || num20 && num21; //False


// Estrutura condicional
//Simples
if (condição)
{
	Comando 1
}

//Composta
if (condição)
{
	Comando 1
}
else
{
	Comando2
}

//Encadeada
if (condição)
{
	Comando 1
}
else if (condição 2 ){
	comando 2
}else
{
	comando 3
}

// Escopo e inicialização
-Escopo de uma variável: é a região do programa onde a variável é válida, ou seja, onde ela pode ser referenciada.
- Uma variável não pode ser usada se não for iniciada.



// -----------------------------------------------------------------------------------------
// ----------------------------------------Ex 3---------------------------------------------

//Ex 9
int num23 = int.Parse(Console.ReadLine());

if (num23 > 0)
{
	Console.WriteLine("Positive");
}
else if (num23 < 0)
{
	Console.WriteLine("Negative");
}
else
{
	Console.WriteLine("Null");
}

// Correções
Esqueci de uma chave no else
// -----------------------------------------------------------------------------------------
//Ex 10
int num24 = int.Parse(Console.ReadLine());
if (num24 % 2 == 0)
{
	Console.WriteLine("Par");
}
else
{
	Console.WriteLine("Ímpar");
}
// -----------------------------------------------------------------------------------------
// Ex 11
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

if (numA % numB == 0 || numB % numA == 0)
{
	Console.WriteLine("Are multiple");
}
else
{
	Console.WriteLine("Are not multiple");
}
// -----------------------------------------------------------------------------------------
// Ex12
string[] vector4 = Console.ReadLine().Split(' ');
int beginHour = int.Parse(vector4[0]);
int finalHour = int.Parse(vector4[1]);

int duration = 0;
if (beginHour < finalHour)
{
	duration = finalHour - beginHour;
}
else
{
	duration = 24 - beginHour + finalHour;
}

Console.WriteLine($"The game lasted:{duration} hours");

//Correçoes
Coloquei um if a mais, arrumei ReadLine
// -----------------------------------------------------------------------------------------
// Ex13
int code2 = int.Parse(Console.ReadLine());
int quantitie = int.Parse(Console.ReadLine());

double price;
if (code2 > 1)
{
	price = 4.0;
}
else if (code2 > 1)
{
	price = 4.5;
}
else if (code2 > 1)
{
	price = 5.0;
}
else if (code2 > 1)
{
	price = 2.0;
}
else if (code2 > 1)
{
	price = 1.5;
}

double total = quantitie * price;
Console.WriteLine($"Total ${total}");
//Correções
Reatribui total para dentro dos blocos como um só, calculando isoladamente. Tbm corrigi a condicional, tinha feito para ser > e não == e tbm o tipo de resultado esperado, esqueci de mudar os valores para todos os ifs elses coloquei valor 1 e nao 1 ate 5 como deveria
// -----------------------------------------------------------------------------------------
// Ex14
int value = int.Parse(Console.ReadLine());

if (value > 0 || value <= 25)
{
	Console.WriteLine("Intervalo (0,25)");
}
else if (value > 25 || <= 50)
{
	Console.WriteLine("Intervalo (25,50)");
}
else if (value > 50 || value <= 75)
{
	Console.WriteLine("Intervalo (50,75)");
}
else if (value > 75 || value <= 100)
{
	Console.WriteLine("Intervalo (75,100)");
}
else
{
	Console.WriteLine("Fora de intervalo");
}
//Correçoes
Alterei o if 'fora do intervalo', pela logica do prof para haver esse if os valores devem ser menor que zero ou maior que 100. Também alterei os valores dos demais para ficar mais simples, sentir uma leveza, mas será que é certo? Deixa uma lacuna para haver mais problemas.
// -----------------------------------------------------------------------------------------
// Ex15
double numX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double numY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (numX == 0.0 && numY == 0.0)
{
	Console.WriteLine("Origin");
}
else if (numX == 0.0)
{
	Console.WriteLine("Axle X");
}
else if (numY == 0.0)
{
	Console.WriteLine("Axle Y");
}
else if (numX > 0.0 && numY > 0.0)
{
	Console.WriteLine("Q1");
}
else if (numX < 0.0 && numY > 0.0)
{
	Console.WriteLine("Q2");
}
else if (numX < 0.0 && numY < 0.0)
{
	Console.WriteLine("Q3");
}
else
{
	Console.WriteLine("Q4");
}


//Ex16
double salary3 = double.Parse(Console.ReadLine());

double tax = 0.0;
if (salary3 <= 2000.0)
{
	tax = 0.0;
}
else if (salary3 <= 3000.0)
{
	//8%
	tax = (salary3 - 2000.0) * 0.08;
}
else if (salary3 <= 4500.0)
{
	//18%
	tax = (salary3 - 3000.0) * 0.18 + 1000.0 * 0.08;
}

else if (salary3 > 4500.00)
{
	//28%
	tax = (salary3 - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}

if (tax == 0.0)
{
	Console.WriteLine("Isent");
}
else
{
	Console.WriteLine("$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
}
	//Correçoes
	Esqueci apenas do CultureInfo no salary3
// -----------------------------------------------------------------------------------------
//Funções
-> Representam um processamento que possui um significado
	Math.Sqrt(double)
	Console.WriteLine(string)

-> Principais vantagens:
	Modularização - modificar o parâmetro de uma onda de acordo com a intensidade de outra.
	Delegação - grupo de indivíduos que exerce uma função ou tarefa representativa. e
	Reaproveitamento - Reutilizar a mesma função, por exemplo.

-> Dados de entrada e saída
	Funções podem receber dados de entrada (parâmetros ou argumentos)
	Funções podem ou não retornar uma saída

-> Em orientação a objetos, funções em classes recebem o nome de "métodos"

// Debugging com Visual Studio
# Tópicos

-> Teclas
	F9 - marcar/desmarcar breakpoint
	F5 - iniciar/continuar o debug
	F10 - executar um passo (pula função)
	F11 - executar um passo (entra na função)
	SHIFT+F11 - sair do método em execução
	SHIFT+F5 - parar debug

-> Janelas
	Watch (expressões personalizadas)
	Autos (expressões "interessantes" detectadas pelo Visual Studio)
	Locals (variáveis locais)

//Estrutura repetitiva while
while( condição )
{ // Regra: Verdadeiro - Executa e Volta; Falso - Pula fora
	comando 1
}


double numUser = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

while(numUser >= 0.0)
{
	double squareRoot = Math.Sqrt(numUser);

	Console.WriteLine(squareRoot.ToString("F3", CultureInfo.InvariantCulture));

	Console.Write("Enter with another number:);
	numUser = double.Parse(Console.ReadLine(), CultureInfo.InvarianteCulture);
}

Console.WriteLine("Number negative!");


// -----------------------------------------------------------------------------------------
// ----------------------------------------Ex 4---------------------------------------------
//Ex17
int acess = 2002;

int password = int.Parse(Console.ReadLine());

do
{
	Console.WriteLine("Password incorrect! Try again.");
	password = int.Parse(Console.ReadLine());

}while(password != acess);
# -> Correções
Esqueci de fechar a string da CW
// -----------------------------------------------------------------------------------------

//Ex18
int numX2 = int.Parse(Console.ReadLine());
int numY2 = int.Parse(Console.ReadLine());

while (numX2 != 0 || numY2 != 0)
{
	if (numX2 != 0 && numY2 != 0)
	{
		Console.WriteLine("Q1");
	}
	else if (numX < 0.0 && numY > 0.0)
	{
		Console.WriteLine("Q2");
	}
	else if (numX < 0.0 && numY < 0.0)
	{
		Console.WriteLine("Q3");
	}
	else
	{
		Console.WriteLine("Q4");
	}
}
Console.WriteLine("Ok");
# -> Correções
Ajustei a logica para E pois pensei que estava causando loop no while, mas ai vi que era apenas adicionar um tipo de break, fazer o usuario digitar os valores novamente, para nao causar loop.
// -----------------------------------------------------------------------------------------
//Ex19
int choose = int.Parse(Console.ReadLine());

int alcohol = 0;
int  diesel = 0;
int gasoline = 0;

while(choose != 4)
{
	if(choose == 1)
	{
		alcohol ++;
	}else if(choose == 2)
	{
		gasoline ++;
	}else if(choose == 3)
	{
		diesel ++;
	}

	Console.WriteLine($"Alcohol:{alcohol}");
    Console.WriteLine($"Gasoline:{gasoline}");
    Console.WriteLine($"Diesel:{diesel}");
}

Console.WriteLine($"Alcohol:{alcohol}");
Console.WriteLine($"Gasoline:{gasoline}");
Console.WriteLine($"Diesel:{diesel}");
# -> Correções
Eu ainda tenho uma péssima familiaridade com lógicas mais complexas, ainda mais quando envolve while e for.
// -----------------------------------------------------------------------------------------
# Estrutura repetitiva for
// Executa somente na primeira vez ; V: Executa e volta/F:Pula Fora; Executa toda vez depois de voltar
//V - verdadeiro
//F - Falso
for(inicio; condição ; incremento)
{

}

//Ex20
int num25 = int.Parse(Console.ReadLine());

for(int i = 0;i < num25;i++)
{
	if(i % 2 != 0) Console.WriteLine(i);
}

# -> Correções
Pela minha cabeça a lógica de declarar uma variavel inteira fosse necessaria, mas apenas uma logica reutilizando a propria declaração do i no for já seria suficiente.
// -----------------------------------------------------------------------------------------
//Ex21
int num26 = int.Parse(Console.ReadLine());

int contIn = 0;
int contOut = 0;
for(int i = 0;i < num26;i++)
{
	if(num26 > 10 && num26 <= 25)
	{
		contIn++;
	}else {
		contOut++;
	}
}

Console.WriteLine($"In:{contOIn}");
Console.WriteLine($"Out:{contOut}");

# -> Correções
Não parei pra pensar que in e out eram palavras reservadas, fiquei meia hora analisando e percebi isso depois de ver que elas tbm ficaram vermelhas, as consertei.
// -----------------------------------------------------------------------------------------
//Ex22
int numN = int.Parse(Console.ReadLine());

for(int i = 0;i < numN;i++){
	string [] vector5 = Console.ReadLine().Split(' ');
	double value2 = vector5[0];
	double value3 = vector5[1];
	double value4 = vector5[2];

	double avg = (value2 * 2.0 + value3 * 3.0 + value4 * 5.0) / 10.0;
	Console.WriteLine(avg.ToString("F1", CultureInfo.InvariantCulture));
}
# -> Correções
Minha matematica é fraca, preciso me empenhar em aprimora-la e errei apenas na variavel que repeti e esqueci de alterar apos;
// -----------------------------------------------------------------------------------------
//Ex23
   //Ex23
        int num27 = int.Parse(Console.ReadLine());
   for (int i = 0; i < num27; i++)
        {
            string [] vector5 = Console.ReadLine().Split(' ');
            int numX5 = int.Parse(vector5[0]);
            int numY5 = int.Parse(vector5[1]);

            if(numY5 == 0){
                Console.WriteLine("Impossible division");
            }
            else
            {
                double division = (double) numX5 / numY5;
                Console.WriteLine(division.ToString("F2", CultureInfo.InvariantCulture));
            }
        } // Corrigido

// -----------------------------------------------------------------------------------------
 //Ex24
        int numN2 = int.Parse(Console.ReadLine());

        int fatorial = 1;
        for (int i = 1; i <= numN2; i++)
        {
            fatorial = fatorial * i;
        }

         Console.WriteLine(fatorial);
		 //Corrigido


//Ex25
int numN3 = int.Parse(Console.Parse());
//INCOGNITA
        //Ex25
        int numN3 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }


        for (int i = 1; i <= numN3; i++)
        {
            if (numN3 % i == 0)
            {
                Console.WriteLine(i);
            }
        }

//Ex27
uint numN4 = int.Parse(Console.ReadLine());

for(int i = 1;i < numN4;i++)
{
	int first = i;
	int second = i * i;
	int thirt = i * i * i;
	Console.WriteLine($"{first} {second} {thirt}");
} //Corrigido

##
## POO

//Ex26
//Class
public string name;
public int age;

//Main
DataPerson person1 = new DataPerson();
DataPerson person2 = new DataPerson();

Console.WriteLine("Enter with the name of first person:");
person1.name = Console.ReadLine();
person1.age = Console.ReadLine();


Console.WriteLine("Enter with the name of second person:");
person2.name = Console.ReadLine();
person2.age = Console.ReadLine();

if(person1.age > person2.age){
	Console.WriteLine($"Pessoa mais velha:{person1.name}");
}else{
	Console.WriteLine($"Pessoa mais velha:{person2.name}");
}
# -> Correções
Apenas renomeie a classe para o nome atual que declarei na classe main, DataPerson. E coloquei int.Parse pq esqueci da conversão


// -----------------------------------------------------------------------------------------

//Ex 26
//Classe
public string employeeName;
public double salary;


//Main
Employee dEmp1 = new Employee();
Employee dEmp2 = new Employee();

Console.Write("Employee 1: Name - ");
dEmp1.employeeName = Console.ReadLine();

Console.Write("Employee 1: Salary - ");
dEmp1.salary = double.Parse(Console.ReadLine());

Console.Write("Employee 2: Name - ");
dEmp2.employeeName = Console.ReadLine();

Console.Write("Employee 2: Salary - ");
dEmp2.salary = double.Parse(Console.ReadLine());


### Criando um método para obtermos os benefícios de reaproveitamento e delegação

//Classe
public double A;
public double B;
public double C;

public double Area()
{
	double p = (A + B + C) / 2.0;
	return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
}

### Começando a resolver um segundo problema exemplo
//Class - Product
	public string Name;
	public double Price;
	public int Quantitie;

	public double TotalValueInStock()
	{
		return Price * Quantitie;
	}

	public void AddProducts(int Quantitie)
	{
		Quantitie += Quantitie;
	}
	public void RmvProducts(int Quantitie)
	{
		Quantitie -= Quantitie;
	}

	public override string ToString()
	{
		return "Data:"+name+", $"+price+","+quantitie" units, Total:"+TotalValueInStock();
	}
//Main
Product prod = new Product();
Console.WriteLine("Enter with the data of product:");
Console.Write("Name:");
Console.Write("Price:");
Console.Write("Quantitie in stock:");

Console.WriteLine(prod);

Console.WriteLine();

Console.WriteLine("Enter the number of products a been add in to stock:");
int quantitie = int.Parse(Console.ReadLine());

Console.WriteLine($"Update:{prod}");

Console.WriteLine("Enter the number of products a been rmv in to stock:");
quantitie = int.Parse(Console.ReadLine());

Console.WriteLine($"Update pt 2:{prod}");
// -----------------------------------------------------------------------------------------
//Ex 27
// Class Rectangle
public double Width;
public double Height;

public double Area()
{
	return 0;
}

public double Perimeter()
{
	return 0;
}

public double Diagonal()
{
	return 0;
}

public override string ToString()
{
	return "AREA"+Area().ToString("F2", CultureInfo.InvariantCulture)+"\n"+"PERIMETER"+Perimeter().ToString("F2", CultureInfo.InvariantCulture)+"\n"+
	"DIAGONAL:"+diagonal().ToString("F2", CultureInfo.InvariantCulture);
}

//Main
Rectangle rctg = new Rectangle();
Console.Write("Enter the Width and Height of Rectangle:");
rctg.Width = double.Parse(Console.ReadLine());
rctg.Height = double.Parse(Console.ReadLine());

Console.WritLine($"{rctg}");
// -----------------------------------------------------------------------------------------
// Exerc28
//Class EmployeeData
	public string Name;
	public double GrossSalary;
	public double Tax;

	public double NetSalary()
	{
		return GrossSalary - Tax;
	}

	public void IncreaseSalary(double percentage)
	{
		GrossSalary += (GrossSalary * percentage / 100.0);
	}

	public override string ToString()
	{
		return "Employee:"+name +","+IncreaseSalary().ToString("F2", CultureInfo.InvariantCulture);
	}


//Main
	EmployeeData empD = new EmployeeData();
	Console.Write("Name:");
	empD.Name = Console.ReadLine();

	Console.Write("Gross salary:");
	empD.GrossSalary = double.Parse(Console.ReadLine());

	Console.Write("Tax:");
	empD.Tax = double.Parse(Console.ReadLine());

	Console.Write();
	Console.Write($"{empD}");
	Console.Write();

	Console.Write("Enter the percentage to increase the salary:");
	double percentage = double.Parse(Console.ReadLine());
	empD.IncreaseSalary(percentage);

	Console.Write($"Updated data:{empD}");
// -----------------------------------------------------------------------------------------
//Ex29
//Class Student
	public string StudentName;
	public double Grades;

	public double FinalGrade()
	{
		return Grades + Grades + Grades;
 	}

//Main
	Student std = new Student();

	Console.Write("Student name:");
	std.StudentName = Console.ReadLine();
	Console.Write("Enter to the three grades of student:");

	double sum = 0;
	int count = 0;

	while (count < 3)
	{
		std.Grades = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		sum += std.Grades;
	}

	double fg = std.FinalGrade();
	double missing;

	if(fg >= 60)
	{
		Console.WriteLine("APPROVED!");
		Console.WriteLine($"Grade final:{fg}");
	}else {
		missing = 60 - fg;
		Console.WriteLine($"Missing:{missing} points");
	}


## Membros estáticos
Membros = atributos e métodos
- Também chamados membros de classe
-- Em oposição a membros e instância

- São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados. São chamados a partir do próprio nome da classe.

- Aplicações comuns:
-- Classes utilitárias -> Math.Sqrt(double)
-- Declaração de constantes

- Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.


//V1
	static double PI = 3.14;
	static void Main(string [] args)
	{
		...
		...
		...

		static double Circunferece(double radius)
		{
			return 2.0 * PI * radius;
		}

		static double Volume(double radius)
		{
			return 4.0 / 3.0 * PI * radius * radius * radius;
		}

	}

// Parte 2
//Classe - Calculate - V3
	public double PI = 3.14;

	public static double Circunferece(double radius)
	{
		return 2.0 * PI * radius;
	}

	public static double Volume(double radius)
	{
		return 4.0 / 3.0 * PI * radius * radius * radius;
	}


//Main
	double circunference = Calculate.Circunference(3.0);
	double volume = Calculate.Volume(4.0);

	Console.WriteLine("Circ.:"+circunference.ToString("F2", CultureInfo.InvariantCulture));
	Console.WriteLine("Vol.:"+volume.ToString("F2", CultureInfo.InvariantCulture));
	Console.WriteLine("PI:"+Calculate.PI.ToString("F2", CultureInfo.InvariantCulture));

//Ex30
//Classe CoinConversor
	public static double IOF = 6.0;

	public static double DolarToReal(double amount, double quotation)
	{
		double total = amount * quotation;
		return total + total * IOF / 100.0;
	}


//Main
	Console.WriteLine("Quotation dollar today:");
	double quotation = double.Parse(Console.ReadLine());

	Console.WriteLine("How many do you buy:");
	double amount = double.Parse(Console.ReadLine());

	double total = CoinConversor.DolarToReal(amount, quotation);
	Console.WriteLine($"Total to pay in R$:{total}");


## Construtores
- É uma operação especial da classe, que executa no momento da instanciação do objeto

- Usos comuns:
-- Iniciar valores dos atributos
-- Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência)

- Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão:
--  Produto p = new Produto();

- É possível especificar mais de um construtor na mesma classe (sobrecarga)


//Example
//Classe - Product
	public string Name;
	public double Price;
	public int Quantitie;

	public Product(string Name, double Price, int Quantitie)
	{
		Name = Name;
		Price = Price;
		Quantitie = Quantitie;
	}

//Main

	Console.WriteLine("Enter with data of products:");
	Console.Write("Name:");
	string name = Console.ReadLine();

	Console.Write("Price:");
	double price = double.Parse(Console.ReadLine());

	Console.Write("Quantitie:");
	int quantitie = int.Parse(Console.ReadLine());

	Product prod = new Product(name, price, quantitie);

## Sobrecarga
É um recurso que uma classe possui de oferecer mais de uma
operação com o mesmo nome, porém com diferentes listas de
parâmetros.
//Classe - Product
	public Produto() {}

	public Produto(string name, double price, int quantitie) {

		Name = name;
		Price = price;
		Quantitie = quantitie;

	}

	public Produto(string name, double price, int quantitie) {

		Name = name;
		Price = price;
		Quantitie = 0;

	}

## Sintaxe alternativa para inicializar valores
//Main - Isso funciona mesmo se a classe não possuir construtores implementados
Product prod = new product() //O () é opcional!
{
	Name = "TV",
	Price = 900.0,
	Quantitie = 0
};

### this
- É uma referência para o próprio objeto
- Usos comuns:
-- Diferenciar atributos de variáveis locais (Java)
-- Referenciar outro construtor em um construtor
-- Passar o próprio objeto como argumento na chamada de um método ou construtor


	public Produto(string name, double price, int quantitie) {

		this.Name = name;
		this.Price = price;
		Quantitie = 0;

	}

## Referenciar outro construtor em um construtor
	public Product()
	{
		Quantitie = 0;
	}

	public Product(string name, double price):this()
	{
		Name = name;
		Price = price;
	}

	//Reaproveitar o constructor de cima
	public Produto(string name, double price, int quantitie) : this(name, price) {
		Quantitie = quantitie;
	}
## Passar o próprio objeto como argumento na chamada de um método ou construtor
	class ChessMatch {
	(...)
	PlaceNewPiece('e', 1, new King(board, Color.White, this));
	(...)

## Encapsulamento
- É um princípio que consiste em
esconder detalhes de implementação
de um componente, expondo apenas
operações seguras e que o mantenha
em um estado consistente.

<strong>
- Regra de ouro: o objeto deve sempre
estar em um estado consistente, e a
própria classe deve garantir isso.
</strong>

<br>

-> Opção 1: implementação manual
- Todo atributo é definido como private

- Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio
<strong>
- Nota: não é usual na plataforma C#
</strong>

<br>

	private string _name;
	private double price;
	private int _quantitie;

	public Product()
	{

	}

	public Product(string name, double price, int quantitie)
	{
		_name = name;
		_price = price;
		_quantitie = quantitie;
	}

	public string GetName()
	{
		return _name;
	}
	public void SetName(string name)
	{
		if(name != null && name.length > 1)
		{
			_name = name;
		}
	}

	public double GetPrice()
	{
		return _price;
	}
	public int GetQuantitie()
	{
		return _quantitie;
	}
	public double ValueTotalInStock()
	{
		return _price * _quantitie;
	}

## Properties
- São definições de métodos encapsulados, porém expondo uma
sintaxe similar à de atributos e não de métodos

> https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
- Uma propriedade é um membro que oferece um mecanismo flexível para ler,
gravar ou calcular o valor de um campo particular. As propriedades podem ser
usadas como se fossem atributos públicos, mas na verdade elas são métodos
especiais chamados "acessadores". Isso permite que os dados sejam
acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
dos métodos.

	private string _name;
	private double price;
	private int quantitie;

	public Product()
	{

	}

	public Product(string name, double price, int quantitie)
	{
		_name = name;
		_price = price;
		_quantitie = quantitie;
	}

	public string Name{
		get { return _name; }
		set {
			if(name != null && name.length > 1)
			{
				_name = name;
			}
		}
	}

	public double Price
	{
		get { return _price; }
	}

	public int Quantitie
	{
		get { return _quantitie; }
	}


## Auto Properties

Propriedades autoimplementadas
•É uma forma simplificada de se declarar propriedades que não
necessitam lógicas particulares para as operações get e set.

	private string _name;
	public double Price { get; private set; }
	public double Quantitie { get; set; }

	public Produto(string nome, double preco, int quantidade) {
		_nome = nome;
		Preco = preco;
		Quantidade = quantidade;
	}
> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties


##### Ordem sugerida para implementação de membros
- Atributos privados
-- Propriedades autoimplementadas
-- Construtores
-- Propriedades customizadas
-- Outros métodos da classe

### Classes
- Acesso por qualquer classe
-- public class product

- Acesso somente dentro do assembly
-- internal class Product
-- class Product

- Acesso somente pela classe-mae
-- private class Product

<strong>
- Nota: classe aninhada, por padrão, é private
</strong>

//Ex31
//Classe UserAccount
	public int Account { get; private set; }
	public string Holder { get; set; }
	public double Balance { get; private set; }

	public UserAccount(){

	}
	public UserAccount(int account, string holder){
		Account = account;
		Holder = holder;
	}

	public UserAccount(int account, string holder, double balance):this(account, holder)
	{
		Balance = balance;
	}


	public void deposit(double amount)
	{
		Balance += amount;
	}

	public void withdraw(double amount)
	{
		Balance -= amount + 5;
	}

		public override string ToString()
	{
		return Account +", "+Name +", $"+ Balance.ToString("F2", CultureInfo.InvariantCulture);
	}



//Main
	UserAccount ua;
	Console.Write("Enter the number of account:");
	int account = int.Parse(Console.ReadLine());

	Console.Write("Holder account:");
	string holder = Console.ReadLine();

	Console.Write("There will be a initial deposit[y/n]:");
	char answer = char.Parse(Console.ReadLine()).ToUpper();
	if(answer == 'Y')
	{
		Console.Write("Enter the value of initial deposity:");
		double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		ua = new UserAccount(account, holder, initialDeposit);
	}
	else
	{
		ua = new UserAccount(account, holder);
	}

	Console.Write("");
	Console.Write("Data of account:");
	Console.Write($"{UserAccount}");

	Console.Write("Enter a value to deposity:");
	double amount = double.Parse(Console.ReadLine());

	Console.Write("Data of account updated:");
	Console.Write($"{UserAccount}");

	Console.Write("");
	Console.Write("Enter a value to withdraw:");
	amount = double.Parse(Console.ReadLine());

	Console.Write("");
	Console.Write("Data of account updated. Pt2:");
	Console.Write($"{UserAccount}");


## Tipos de refêrencia VS. Tipos valor
- Classes são tipos referência
 Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim “tentáculos” (ponteiros) para caixas

// Example

	Product p1, p2;
	p1 = new Product("TV", 900.0, 0);
	p2 = p1; //p2 passa a apontar para onde p1 aponta

// Valor "null"

	Tipos referência aceitam o valor "null", que indica que a variável aponta pra ninguém

// Example
	Product p1, p2;
	p1 = new Product("TV", 900.0, 0);
	p2 = null

// Structs são tipos valor
	A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e não ponteiros.
	double x, y;
	x = 10;
	y = x; //y recebe uma cópia de x

- É possível criar seus próprios structs

	namespace Example
	{
		Struct Point
		{
			public double X, Y;

			public override string ToString()
			{
				return "(" + X + ", "+ Y+ ")";
			}
		}
	}

//Structs e inicialização

	//Point point = new Point();
	Point point;
	point.X = 10;
	point.Y = 20;
	Console.WriteLine(point);

	point = new Point(); // Aceita o new
	Console.WriteLine(point);


//Valores padrão
- Quando alocamos (new) qualquer tipo estruturado (classe, struct,
array), são atribuídos valores padrão aos seus elementos

	números: 0
	bool: False
	char: caractere código 0
	objeto: null

- Lembrando: uma variável apenas declarada, mas não instanciada,
inicia em estado "não atribuída", e o próprio compilador não permite que ela seja acessada.

#### Classe
- Usufrui de todos os recursos OO
- Variáveis são ponteiros
- Objetos precisam ser instanciadas usando new, ou apontar para um objeto já existente
- Aceita valor null
- Suporte a herança
	Y = X;
	"Y passa a apontar para onde X aponta"
- Objetos instanciados no heap
- Objetos não utilizados são desalocados em um momento próximo pelo garbarage collector

#### Struct
- É mais simples e mais perfomático
- Variáveis são caixas
- Não é preciso instânciar usando new, mas é possível
- Não aceita valor null
- Não tem suporte a herança(Mas pode implementar interfaces)
	Y = x
	"Y recebe uma cópia de X"
- Objetos instanciados no stack
- "Objetos" são desalocados imediatamente quando seu escopo de execução é finalizado

# Desalocação de memória - garbage collector e escopo local
- É um processo que automatiza o gerenciamento de memória de um
programa em execução
- O garbage collector monitora os objetos alocados dinamicamente
pelo programa (no heap), desalocando aqueles que não estão mais
sendo utilizados.

-- Desalocação por garbage collector
	Product p1, p2;
	p1 = new Product("Tv"900.0, 0);// Será desalocado pelo garbage collector
	p2 = new Product("Mouse"30.0, 0);

	p1 = p2;

//Desalocação por escopo
	//Example 1.1
	void method()
	{
		int x = 10;
		if(x > 0)
		{
			int y = 20;
		}
		Console.WriteLine(x); //Y não sai do escopo do if, pq ele só existe la dentro
	}

	//Example 1.2
	void method1()
	{
		Product p = method2();
		Console.WriteLine(p.Name);
	}

	Product method2()
	{
		Product prd = new Product("Tv", 900.0, 0);
		return prd;
	}

//Nullable
- É um recurso de C# para que dados de tipo valor (structs) possam
receber o valor null

- Uso comum:
-- Campos de banco de dados que podem valer nulo (data de nascimento, algum valor numérico, etc.).

-- Dados e parâmetros opcionais.

	double? x = null;
	double? y = 10.0;

	Console.WriteLine(x.GetValueOrDefault());

	Console.WriteLine(x.HasValue);

	Console.WriteLine(x.Value);


- Um nullable não pode ser atribuído para um struct comum
- Valor default para tipos:
> https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/default-value-expressions

//Operador de Coealescência nula

	Para quando o valor atribuido for nulo, colocar um valor padrão
	double? x = null;
	double y = x ?? 0.1;


# Vetores
- Em programação, "vetor" é o nome dado a arranjos unidimensionais
- Arranjo é uma estrutura de dados:
  - Homogênea (dados do mesmo tipo)
  - Ordenada (elementos acessados por meio de posições)
  - Alocada de uma vez só, em um bloco contíguo de memória

<br>

- Vantagens
  - Acesso imediato aos elementos pela sua posição

<br>

- Desvantagens
  - Tamanho fixo
  - Dificuldade para se realizar inserções e deleções


//Ex32
	//Class DataStudents
	/*
	Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
	*/

	public string Name { get; set; }
	public string Email {get; set; }
	public int room { get; set; }

	public DataStudent(string name, string email)
	{
		Name = name;
		Email = email;
	}
	public override string ToString(){
		return $"{name}, {email}";
	}

//Main

	/*
		A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos números 0 a 9.
		Fazer um programa que inicie com todos os dez quartos vazios, e depois
	*/
	int [] rooms = new int[10];

	/*
		leia uma quantidade N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10).
	*/

	DataStudents [] ds = new DataStudents();

	int n = int.Parse(Console.ReadLine());
	for(int i = 0; i <= n;i++)
	{
		Console.WriteLine($"Rent:#{i + 1}");

		Console.WriteLine("Name:");
		string name = Console.ReadLine();

		Console.WriteLine("Email:");
		string email = Console.ReadLine();

		Console.WriteLine("Room:");
		int room = int.Parse(Console.ReadLine());

		rooms[room];

		ds[i] = new DataStudents(Name = name, Email = email);
	}
	for(int i = 0;i <= n; i++)
	{
		Console.WriteLine($"{rooms}: {ds.Name}, {ds.Email});
	}


### Modificador de parâmetros: params
	//Class Calc
	public static int Sum(params int [] numbers)
	{
		int sum = 0;
		for(int = 0; i < numbers.lenght;i++)
		{
			sum += number[i];
		}
		return sum;
	}

	// Main
	int sum1 = Calc.Sum(1, 5, 7, 9);
	int sum2 = Calc.Sum(1, 2, 3);

	Console.WriteLine(sum1);
	Console.WriteLine(sum2);
### Modificador de parâmetros: ref e out
//ref

	//Class Calc
	public static void Triple(ref int x)
	{
		x *= 3;
	}

	//Main
	int a = 10;
	Calc.Triple(ref a);
	Console.WriteLine(a);

//out
	//Class Calc
	public static void Triple(int origin, out int result)
	{
		result = origin * 3;
	}

	//Main
	int a = 10;
	int triple;
	Calc.Triple (a, out triple);
	Console.WriteLine(triple);
	/*
	Nota: ambos são considerados "code smells"(design ruim) e devem ser evitados
	*/


### Boxing e unboxing
//Boxing

	/*
		É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível
	*/
	int x = 10;
	Object obj = x;

//Unboxing

	int x = 10;
	Object obj = x;
	int y = (int) obj;


// Laço foreach

	Sintaxe opcional e simplificada para percorrer coleções

	Leitura: "para cada objeto 'obj' contido em vect, faça:"

	string [] vect = new string[]{"Maria", "Bob", "Alex"};

	foreach(string obj in vect)
	{
		Console.WriteLine(obj);
	}

### Listas

	//Listas
  - Lista é uma estrutura de dados:
    - Homogênea(Dados de mesmo tipo)

    - Ordenada(Elementos acessados por meio de posições)

	- Inicia vazia, e seus elementos são alocados sob demanda

	- Cada elemento ocupa um 'nó'(ou nodo da lista):

	- (0) 1.72 -> (1) 1.56 -> (2) 1.80; //Lista

//Declaração

  - Usar a lista com a classe List pertencente ao namespace: System.Collection.List;

		using System.Collection.List;

	//Main

		List<string> str = new List<string>();
		List<string> str2 = new List<string>{"João","Helena"};


//Parte 2

	//Example
	List<string> list = new List<string>();

	- Inserir elemento na lista:

		 list.Add("Maria");
        list.Add("Atena");
        list.Add("Kleber");
        list.Add("João");
        list.Add("Leandro");
        list.Add("Jack");
        list.Add("Glória");
        list.Add("Alexander");
        list.Add("Double");
        list.Add("Helena");

        list.Insert(1, "Bob");

	- Tamanho da lista:

		list.Count

	- Encontrar o primeiro ou ultimos elementos da lista que satisfaça um predicado:

		string str1 = list.Find(x => x[0] == 'A');
		<br>
		string str1 = list.FindLast(x => x[0] == 'a');

	- Encontrar a primeira ou ultima posição de elemento da lista que satisfaça um predicao:

        int str3 = list.FindIndex(x => x[0] == 'M');
        Console.WriteLine(str3);
		int str4 = list.FindLastIndex(x => x[0] == 'a');
        Console.WriteLine(str4);

	- Filtrar a lista com base em um predicado:

        List<string> str5 = list.FindAll(x => x.Length == 5);
        foreach (string obj in str5)
        {
            Console.WriteLine(obj);
        }
	- Remover elementos da lista:
		list.Remove("Bob")
		list.RemoveAll(x => x[0] == 'M')

		//Remove pela posição

        list.RemoveAt(2);
        foreach (string rmv in list)
        {
            Console.WriteLine($"Remove at:{rmv}");
        }

		//Remover um elemento de uma faixa
		//				Posição, Qtd de elementos
		list.RemoveRange(2,2)

		//Testes - Ok
		        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("---------- Add e Insert Ok ----------");

        Console.WriteLine(list.Count);
        Console.WriteLine("---------- Count Ok ----------");

        string str1 = list.Find(x => x[0] == 'B');
        Console.WriteLine(str1);
        string str2 = list.FindLast(x => x[1] == 'a');
        Console.WriteLine(str2);
        Console.WriteLine("---------- Find e FindLast Ok ----------");

        int str3 = list.FindIndex(x => x[0] == 'M');
        Console.WriteLine(str3);
        int str4 = list.FindLastIndex(x => x[0] == 'a');
        Console.WriteLine(str4);
        Console.WriteLine("---------- FindIndex e FindLastIndex Ok ----------");

        List<string> str5 = list.FindAll(x => x.Length == 5);
        foreach (string obj in str5)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("---------- FindAll Ok ----------");

        list.Remove("Bob");
        list.RemoveAll(x => x[0] == 'M');

        foreach (string rmv in list)
        {
            Console.WriteLine($"Remove all e Remove:{rmv}");
        }
        Console.WriteLine("---------- RemoveAll e Remove Ok ----------");

        list.RemoveAt(2);
        foreach (string rmv in list)
        {
            Console.WriteLine($"Remove at:{rmv}");
        }
        Console.WriteLine("---------- RemoveAt Ok ----------");

        list.RemoveRange(0,2);
       foreach (string rmv in list)
        {
            Console.WriteLine($"Remove range:{rmv}");
        }
        Console.WriteLine("---------- RemoveRange Ok ----------");


//Ex33

	//Main
        List<Employee> emp = new List<Employee>();

        Console.Write("How many employees will be registered?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Employee#{i}");
            Console.Write("ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Salary $");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            emp.Add(new Employee(id, name, salary));
        }

        Console.WriteLine();
        Console.Write("Enter the employee id that will have salary increase:");
        int findId = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Employee emp2 = emp.Find(x => x.Id == findId);
        if (emp2 != null)
        {
            Console.Write("Enter the percentage:");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp2.Increase(percentage);
        }
        else
        {
            Console.WriteLine("This id does not exist");
        }
        Console.WriteLine();
        Console.WriteLine("Updated list of employees:");
        foreach (Employee emp3 in emp)
        {
            Console.WriteLine(emp3);
        }

//Classe Employee

	    public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }

        public void Increase(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

#### Matrizes

       double [,] mat = new double[2,3];
       Console.WriteLine(mat.Length);
       Console.WriteLine(mat.Rank);
       Console.WriteLine(mat.GetLength(0));
       Console.WriteLine(mat.GetLength(1));

## Inferência de tipos: palavra var

	var x = 10;
	var y = 20.1;
	var z = "Maria";
	//Tomar cuidado com uso excessivo da palavra reservada

## Sintaxe alternativa: switch-case

	Estrutura opcional a vários if-else encadeados, quando a condição envolve o teste do valor de uma variável.

	var myVariable = int.Parse(Console.ReadLine());

	switch(myVariable)
	{
		case 1:
		Console.WriteLine("Case 1");
		break;
		...

		default:
		Console.WriteLine("Case default");
		break;

	}


## Expressão condicional ternária

	Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição.

	sintaxe: (condição) ? valor_true : valor_false;
	(2 > 4) ? 50 : 80;

## Funções interessantes para string

	 string text = "Lorem ipsum dolor sit amet consectetur adipisicing elit.!";

        Console.WriteLine();

        string test1 = text.ToLower();
        string test2 = text.ToUpper();
        string test3 = text.Trim();
        int test4 = text.IndexOf("Le");
        int test5 = text.LastIndexOf("e!");
        string test6 = text.Substring(1, 7);
        string test7 = text.Substring(1);
        string test8 = text.Replace('L', 'Q');
        string test9 = text.Replace("Lorem", "Loreal");
        bool test10 = String.IsNullOrEmpty("magnam");
        bool test11 = String.IsNullOrEmpty("Vitae");
        Console.WriteLine("-> Formatar:");
        Console.WriteLine("ToLower:" + test1);
        Console.WriteLine("ToUpperr:" + test2);
        Console.WriteLine("Trim:" + test3);
        Console.WriteLine("-> Buscar:");
        Console.WriteLine("IndexOf:" + test4);
        Console.WriteLine("LastIndexOf:" + test5);
        Console.WriteLine("-> Recortar: ");
        Console.WriteLine("Substring os dois(char, char):" + test6);
        Console.WriteLine("Substring apenas (char):" + test7);
        Console.WriteLine("-> Substituir:");
        Console.WriteLine("Replace char:" + test8);
        Console.WriteLine("Replace string:" + test9);
        Console.WriteLine("String Is null Or empty: " + test10);
        Console.WriteLine("String is null or white space:" + test11);

        Console.WriteLine();

        Console.WriteLine("Conversão para número:");
        var str = "12";
        int x = int.Parse(str);
        int x2 = Convert.ToInt32(str);
        Console.WriteLine("X:" + x);
        Console.WriteLine("X2:" + x2);

        Console.WriteLine();

        Console.WriteLine("Conversão para número, pt 2:");
        var str2 = "1";
        var str3 = "898";
        var str4 = "777";
        var str5 = "44";

        str2 = x.ToString();
        str3 = x.ToString("C");
        str4 = x.ToString("C3");
        str5 = x.ToString("F2");

        Console.WriteLine(str2);
        Console.WriteLine(str3);
        Console.WriteLine(str4);
        Console.WriteLine(str5);

### DateTimehttp

	Representa um INSTANTE
	É um tipo valor (struct)

//Representação interna

	Um objeto DateTime internamente armazena:
		- O número de 'ticks'(100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum(1 d.C.)

	DateTime dt1 = DateTime.Now;
	Console.WriteLine(dt1);
	Console.WriteLine(dt1.Ticks);

//Instanciação

	- Construtores
	DateTime(ano, mes, dia)
	DateTime(ano, mes, dia, hora, minuto, segundo)
	DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo) //Kind - Hora local ou Global

	Representa um INSTANTE
	É um tipo valor (struct)

//Representação interna

	Um objeto DateTime internamente armazena:
		- O número de 'ticks'(100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum(1 d.C.)

	DateTime dt1 = DateTime.Now;
	Console.WriteLine(dt1);
	Console.WriteLine(dt1.Ticks);

//Instanciação

	- Construtores
        DateTime dt1 = DateTime.Now;
        Console.WriteLine(dt1);
        Console.WriteLine(dt1.Ticks);

        DateTime dt2 = new DateTime(2015, 01, 01);
        Console.WriteLine(dt2);

        DateTime dt3 = new DateTime(2015, 01, 02, 15, 37, 10);
        Console.WriteLine(dt3);

        DateTime dt4 = new DateTime(2015, 01, 03, 16, 50, 55, 1);
        Console.WriteLine(dt4); //Kind - Hora local ou Global

	- Builders
        Console.WriteLine("Now, UtcNow, Today:");
        DateTime dt5 = DateTime.Now;
        Console.WriteLine(dt5);
        DateTime dt6 = DateTime.UtcNow;
        Console.WriteLine(dt6);
        DateTime dt7 = DateTime.Today;
        Console.WriteLine(dt7);

        Console.WriteLine("Parse:");
        DateTime dt8 = DateTime.Parse("07-01-2015");
        Console.WriteLine(dt8);
        DateTime dt81 = DateTime.Parse("17-01-2015 13:05:58");
        Console.WriteLine(dt8);
        DateTime dt82 = DateTime.Parse("27/01/2015");
        Console.WriteLine(dt8);
        DateTime dt83 = DateTime.Parse("30-01-2015 13:10:01");
        Console.WriteLine(dt8);
        Console.WriteLine("Parse Exact:");
        DateTime dt9 = DateTime.ParseExact("2015-01-09", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        Console.WriteLine(dt9);
        DateTime dt91 = DateTime.ParseExact("19/01/2015 12:32:20", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Console.WriteLine(dt91);

### TimeSpan

	Representa uma DURAÇÃO
	É um tipo valor (struct)

//Representação interna

	- Um objeto TimeSpan internamente armazena uma duração na forma de ticks(100 nanosegundos)

 		//                          HH: mm: ss
        TimeSpan ts1 = new TimeSpan(12, 55, 30);
        Console.WriteLine(ts1);
        Console.WriteLine(ts1.Ticks);

//Construtores

	TimeSpan()
	TimeSpan(ticks)
	TimeSpan(horas, minutos, segundos)
	TimeSpan(dias, horas, minutos, segundos)
	TimeSpan(dias, horas, minutos, segundos, milissegundos)

	TimeSpan ts2 = new TimeSpan();
    Console.WriteLine(ts2);
	//							ticks
    TimeSpan ts3 = new TimeSpan(900000000L);
    Console.WriteLine(ts3);
    TimeSpan ts4 = new TimeSpan(16, 01, 15);
    Console.WriteLine(ts4);
    TimeSpan ts5 = new TimeSpan(9, 16, 1, 5);
    Console.WriteLine(ts5);
    TimeSpan ts6 = new TimeSpan(10, 16, 2, 30, 4);
    Console.WriteLine(ts6);

	Console.WriteLine("Métodos From:");
    //                              1 Dia.12horas(1 dia e meio)
    TimeSpan ts7 = TimeSpan.FromDays(1.5);
    Console.WriteLine(ts7);
    TimeSpan ts8 = TimeSpan.FromHours(1.5);
    Console.WriteLine(ts8);
    TimeSpan ts9 = TimeSpan.FromMinutes(1.5);
    Console.WriteLine(ts9);
    TimeSpan ts10 = TimeSpan.FromSeconds(1.5);
    Console.WriteLine(ts10);
    TimeSpan ts11 = TimeSpan.FromMilliseconds(1.5);
    Console.WriteLine(ts11);
     TimeSpan ts12 = TimeSpan.FromTicks(900000000L);
    Console.WriteLine(ts12);

### Propriedades e Operações com DateTime

//Propriedades

	Date(DateTime)
	Day(int)
	DayOfWeek(DayOfWeek)
	DayOfYear(int)
	Hour(int)
	Kind(DateTimeKind)
	Millisecond(int)
	Minute(int)
	Monht(int)
	Second(int)
	Ticks(long)
	TimeOfDay(TimeSpan)
	Year(int)

	DateTime dt10 = new DateTime(2015, 1, 10, 16, 22, 58, 275);
	Console.WriteLine($"{dt10}");
	Console.WriteLine($"Date:{dt10.Date}");
	Console.WriteLine($"Day:{dt10.Day}");
	Console.WriteLine($"Day Of Week:{dt10.DayOfWeek}");
	Console.WriteLine($"Day Of Year:{dt10.DayOfYear}");
	Console.WriteLine($"Hour:{dt10.Hour}");
	Console.WriteLine($"Kind:{dt10.Kind}");
	Console.WriteLine($"Millisecond:{dt10.Millisecond}");
	Console.WriteLine($"Minute:{dt10.Minute}");
	Console.WriteLine($"Month:{dt10.Month}");
	Console.WriteLine($"Second:{dt10.Second}");
	Console.WriteLine($"Ticks:{dt10.Ticks}");
	Console.WriteLine($"Time Of Day:{dt10.TimeOfDay}");
	Console.WriteLine($"Year:{dt10.Year}");

//Formatação (DateTime -> string)

     DateTime dt11 = new DateTime(2015, 01, 11, 17, 31, 45);
        string sdt1 = dt11.ToLongDateString();
        Console.WriteLine(sdt1);
        string sdt2 = dt11.ToLongTimeString();
        Console.WriteLine(sdt2);
        string sdt3 = dt11.ToShortDateString();
        Console.WriteLine(sdt3);
        string sdt4 = dt11.ToShortTimeString();
        Console.WriteLine(sdt4);
        string sdt5 = dt11.ToString();
        Console.WriteLine(sdt5);
        string sdt6 = dt11.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine(sdt6);
        //                                              milisegundos
        string sdt7 = dt11.ToString("yyyy-MM-dd HH:mm:ss.fff");
        Console.WriteLine(sdt7);

//Operações com Datetime

     	TimeSpan ts4 = new TimeSpan(16, 01, 15);
        DateTime dt1x = DateTime.Parse("2015-01-12 17:19:15");

        DateTime dt1y = dt1x.Add(ts4);
        Console.WriteLine(dt1y);

        DateTime dt3y = dt1x.AddDays(2.1);
        Console.WriteLine(dt3y);

        DateTime dt4y = dt1x.AddHours(1.1);
        Console.WriteLine(dt4y);

        DateTime dt5y = dt1x.AddMilliseconds(0.1);
        Console.WriteLine(dt5y);

        DateTime dt6y = dt1x.AddMinutes(1.1);
        Console.WriteLine(dt6y);

        DateTime dt7y = dt1x.AddMonths(1);
        Console.WriteLine(dt7y);

        DateTime dt8y = dt1x.AddSeconds(2.0);
        Console.WriteLine(dt8y);

        DateTime dt9y = dt1x.AddTicks(900000000L);
        Console.WriteLine(dt9y);

        DateTime dt10y = dt1x.AddYears(8);
        Console.WriteLine(dt10y);

        DateTime dt11y = dt1x.Subtract(ts4);
        Console.WriteLine("DateTime:" + dt11y);

        TimeSpan ts7 = dt1x.Subtract(dt1y);
        Console.WriteLine("TimeSpan:"+ts7);

//Propriedades e Operações com TimeSpan

	TimeSpan ts8 = TimeSpan.MaxValue;
	Console.WriteLine($"{ts8}");
	TimeSpan ts9 = TimeSpan.MinValue;
	Console.WriteLine($"{ts9}");
	TimeSpan ts10 = TimeSpan.Zero;
	Console.WriteLine($"{ts10}");


//Propriedades

        TimeSpan ts11 = new TimeSpan(2, 3, 5, 7, 11);
        Console.WriteLine($"{ts11}");
        Console.WriteLine($"Days:{ts11.Days}");
        Console.WriteLine($"Hours:{ts11.Hours}");
        Console.WriteLine($"Minutes:{ts11.Minutes}");
        Console.WriteLine($"Seconds:{ts11.Seconds}");
        Console.WriteLine($"Milliseconds:{ts11.Milliseconds}");
        Console.WriteLine($"Ticks:{ts11.Ticks}");

        Console.WriteLine($"Total days:{ts11.TotalDays}");
        Console.WriteLine($"Total hours:{ts11.TotalHours}");
        Console.WriteLine($"Total minutes:{ts11.TotalMinutes}");
        Console.WriteLine($"Total seconds:{ts11.TotalSeconds}");
        Console.WriteLine($"Total milliseconds:{ts11.TotalMilliseconds}");

//Operações

	TimeSpan ts12 = new TimeSpan(1, 30, 10);
	TimeSpan ts13 = new TimeSpan(0, 10, 5);
	TimeSpan sum = ts12.Add(ts13);
	TimeSpan dif = ts12.Subtract(ts3);
	TimeSpan mult = ts12.Multiply(2.0);
	TimeSpan div = ts12.Divide(2.0);

	Console.WriteLine($"T12:{ts12}");
	Console.WriteLine($"T13:{ts13}");
	Console.WriteLine($"+:{sum}");
	Console.WriteLine($"-:{dif}");
	Console.WriteLine($"*:{mult}");
	Console.WriteLine($"/:{Div}");

### DateTimeKind e padrão ISO 8601

	//DateTimeKind
	Tipo enumerado especial que define três valores possíveis para a localidade da data:
		- Local [Fuso horário do sistema . Ex.: São Paulo -> GMT - 3]
		- Utc [Fuso horário GMT(Greenwich Mean Time)]
		- Unspecified

	-> Boa prática
		- Armazenar em formato UTC(Texto:BD / JSon / XML)
		- Instanciar e mostrar em formato local

	-> P/ Converter um DateTime para Local ou Utc:
		- myDate.ToLocalTime();
		- myDate.ToUniversalTime();

       DateTime dt13 = new DateTime(2015, 01, 13, 18, 01, 25, DateTimeKind.Local);
        DateTime dt14 = new DateTime(2015, 01, 13, 18, 01, 25, DateTimeKind.Utc);
        DateTime dt15 = new DateTime(2015, 01, 13, 18, 01, 25);

        Console.WriteLine($"D1:{dt13}");
        Console.WriteLine($"D1 Kind:{dt13.Kind}");
        Console.WriteLine($"D1 To Local:{dt13.ToLocalTime()}");
        Console.WriteLine($"D1 To Utc:{dt13.ToUniversalTime()}");

        Console.WriteLine();

        Console.WriteLine($"D2 :{dt14}");
        Console.WriteLine($"D2 Kind:{dt14.Kind}");
        Console.WriteLine($"D2 To Local:{dt14.ToLocalTime()}");
        Console.WriteLine($"D2 To Utc:{dt14.ToUniversalTime()}");

        Console.WriteLine();

        Console.WriteLine($"D3:{dt15}");
        Console.WriteLine($"D3 Kind:{dt15.Kind}");
        Console.WriteLine($"D3 To Local:{dt15.ToLocalTime()}");
        Console.WriteLine($"D3 To Utc:{dt15.ToUniversalTime()}");

//Padrão ISO 8601

	- Formato: yyyy-MM-ddTHH:mm:SSZ
	- Z indica que a data/hora está em UTC

		DateTime dt16 = DateTime.Parse("2015-01-16 18:13:37");
		DateTime dt17 = DateTime.Parse("2015-01-17T18:01:09"); //Cria local DateTime

        Console.WriteLine($"D1 :{dt16}");
        Console.WriteLine($"D1 Kind:{dt16.Kind}");
        Console.WriteLine($"D1 To Local:{dt16.ToLocalTime()}");
        Console.WriteLine($"D1 To Utc:{dt16.ToUniversalTime()}");

        Console.WriteLine();

        Console.WriteLine($"D2:{dt17}");
        Console.WriteLine($"D2 Kind:{dt17.Kind}");
        Console.WriteLine($"D2 To Local:{dt17.ToLocalTime()}");
        Console.WriteLine($"D2 To Utc:{dt17.ToUniversalTime()}");

		Console.WriteLine($"{dt17.ToString("yyyy-MM-ddTHH:mm:ssZ")}");//Cuidado!
		Console.WriteLine($"{dt17.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")}");

# Enum

	-Improviso
	Conjunto de constantes relacionadas: número real fixo.

	//Converter para string
	string txt = OrderStatus.Processing.ToString();

	//Tipo enumerado
	OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

#### Composição

	- Organização: Divide o sistema em responsabilidades
	- Coesão: Cada objeto é responsavel por uma unica coisa
	- Flexibilidade: Trabalhar em algo que está dividido em partes é mais flexivel
	- Reuso: Pode ser reutilizado em mais de um lugar

  	- Nota: embora o símbolo UML para composição (todo-parte) seja o diamante preto, neste contexto estamos chamando de composição qualquer associação tipo "tem-um" e "tem-muitos".

//ExercR1 - Está em Exercises <br>
//ExercR2 - Está em Exercises <br>
//Exercs10 - Feito

# Herança

//Herança na pasta Heranca

#### Upcasting e Downcasting

    	Account acc = new Account(001, "Bob", 100.0);
        BusinessAccount bac = new BusinessAccount(002, "Jack", 350.0, 500.0);

        /* Upcasting */
        acc = bac;
        //Conversão de subclasse para superclasse
        Account acc2 = new BusinessAccount(003, "Ellen", 147.44, 500.0);
        Account acc3 = new SavingsAccount(004, "Rihanna", 44.47, 0.01);

        /* Downcasting é Inseguro */
        BusinessAccount bac2 = (BusinessAccount) acc2;
        bac2.Loan(55.77);

        //Erro
        //BusinessAccount bac3 = (BusinessAccount) acc3;

        if (acc3 is BusinessAccount)
        {
            //BusinessAccount bac4 = (BusinessAccount)acc3;
            //Alternativa
            BusinessAccount bac4 = acc3 as BusinessAccount;
            System.Console.WriteLine("Loan!");
        }

        if (acc3 is SavingsAccount)
        {
            //SavingsAccount sa1 = (SavingsAccount) acc3;
            SavingsAccount sa1 = acc3 as SavingsAccount;
            sa1.UpdateBalance();
            System.Console.WriteLine("Update");
        }

# Classes e métodos selados

//Classe Heranca

	Pra quê?

	- Segurança: dependendo das regras do negócio, às vezes é desejável
	garantir que uma classe não seja herdada, ou que um método não
	seja sobreposto.
		-- Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta de entrada para inconsistências

	- Performance: atributos de tipo de uma classe selada são analisados
	de forma mais rápida em tempo de execução.
		-- Exemplo clássico: string


# Polimorfismo

	- Polimorfismo
	Em Programação Orientada a Objetos, polimorfismo é recurso que permiteque variáveis de um mesmo tipo mais genérico possam apontar para objetosde tipos específicos diferentes, tendo assim comportamentos diferentesconforme cada tipo específico.

	Account acc1 = new Account(1001, "Alex", 500.0);
	Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

	acc1.Withdraw(10.0);
	acc2.Withdraw(10.0);

	Console.WriteLine(acc1.Balance);
	Console.WriteLine(acc2.Balance);

// Importante entender
	- A associação do tipo específico com o tipo genérico é feita em tempo de execução (upcasting).

	- O compilador não sabe para qual tipo específico a chamada do método Withdraw está sendo feita (ele só sabe que são duas variáveis tipo Account):

	Account acc1 = new Account(1001, "Alex", 500.0);
	Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

	acc1.Withdraw(10.0);
	acc2.Withdraw(10.0);

//ExercR3
//ExercR4
//Exercs11
//Fazer?


# Abstract

	abstract class Account{}

# Método abstract

	//Ex.:
	abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }

	//Classe Rectangle - Herdando Shape
	public override double Area()
    {
        return Width * Height;
    }

	//Classe Circle - Herdando Shape
	public override double Area()
    {
    	return Math.PI * Radius * Radius;
    }

	//Main
	List<Shape> list = new List<Shape>();


# Exceções

// Est. try-catch

	try
	{
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int result = n1 / n2;
		Console.WriteLine(result);
	}
	catch (DivideByZeroException)
	{
		Console.WriteLine("Division by zero is not allowed");
	}
	catch (FormatException e)
	{
		Console.WriteLine("Format error! " + e.Message);
	}

//Bloco finally

	finally
	{
		if (fs != null)
		{
			fs.Close();
		}
	}

