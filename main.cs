using System;

class MainClass {
  public static void Main (string[] args) {
    int preal, precio, inportacion, num;
    string tipo;
  Console.WriteLine("Dijite el tipo de Auto \n dijite 1 para toyota \n dijite 2 para mazda \n dijite 3 para chevrolet \n dijite 4 para otro");
    tipo=Console.ReadLine();
    switch(tipo){
      case "1":
        Console.WriteLine("Digite 1 si es importado o 2 si es nacional");
        num=int.Parse(Console.ReadLine());
        if (num==1){
          precio=40000000;
          preal=precio+2500000;
        }
        else{
          precio=40000000;
          preal=precio+1000000; 
        }
        Console.WriteLine("El valor comercial es :" + precio + " El precio real es: " + preal);
      break;

      case "2":
        Console.WriteLine("Digite 1 si es importado o 2 si es nacional");
        num=int.Parse(Console.ReadLine());
        if (num==1){
          precio=65000000;
          preal=precio+2500000;
        }
        else{
          precio=45000000;
          preal=precio+1000000; 
        }
        Console.WriteLine("El valor comercial es :" + precio + " El precio real es: " + preal);
      break;

      case "3":
        Console.WriteLine("Digite 1 si es importado o 2 si es nacional");
        num=int.Parse(Console.ReadLine());
        if (num==1){
          precio=38000000;
          preal=precio+2500000;
        }
        else{
          precio=30000000;
          preal=precio+1000000; 
        }
        Console.WriteLine("El valor comercial es :" + precio + " El precio real es: " + preal);
      break;

      case "4":
        Console.WriteLine("Digite 1 si es importado o 2 si es nacional");
        num=int.Parse(Console.ReadLine());
        if (num==1){
          precio=30000000;
          preal=precio+2500000;
        }
        else{
          precio=30000000;
          preal=precio+1000000; 
        }
        Console.WriteLine("El valor comercial es :" + precio + " El precio real es: " + preal);
      break;

      default:
          Console.WriteLine("\n" + "El numero que dijitaste no es una opción");
      break;
    }
  }
}