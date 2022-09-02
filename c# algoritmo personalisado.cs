int edad;
Console.WriteLine ("cual es su nombre");
          string nombre = Console.ReadLine ();

     Console.WriteLine ("cual es su edad");
           edad = Convert.ToInt32 ( Console.ReadLine ()); 

   if (edad >=18 ) {
      Console.WriteLine ("Es mayor de edad "+nombre);
   } else {
       Console.WriteLine ("Es menor de edad "+nombre);
   } 

   do
   {
      Console.WriteLine("cual es su nombre");
                 nombre = Console.ReadLine ();

      Console.WriteLine("cual es su edad");
                 edad = Convert.ToInt32 ( Console.ReadLine ());

   }
   while(edad<=18); 
      Console.WriteLine ("no entra al aula"); 





   