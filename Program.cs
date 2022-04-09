double altura, peso;
string diag;

Console.Write("\nDigite a sua altura.: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o seu peso...: ");
peso = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 17){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diag = "Muito abaixo do peso";
    
    }
 
else if (imc < 18.5){
    Console.ForegroundColor = ConsoleColor.Red;
    diag = "Abaixo do peso";
    
    }
 
else if (imc < 25){
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    diag = "Peso Normal";
    
    }
 
else if (imc < 30){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    diag = "Acima do peso";
    
    }
 
else if (imc < 35){
    Console.ForegroundColor = ConsoleColor.Red;
    diag = "Obesidade I";
    
    }
 
else if (imc < 40){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diag = "Obesidade II (severa)";
    
    }
 
else {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    diag = "Obesidade III (mórbida)";
    
    }

Console.WriteLine($"\n{diag}\n");
Console.ResetColor();
 