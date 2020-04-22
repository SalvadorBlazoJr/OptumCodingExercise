using System;

namespace CodingExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            string weight = string.Empty;
            string height = string.Empty;
            string width = string.Empty;
            string length = string.Empty;

            Console.Write("Weight:\t\t");
            weight = Console.ReadLine();

            Console.Write("Height:\t\t");
            height = Console.ReadLine();

            Console.Write("Width:\t\t");
            width = Console.ReadLine();

            Console.Write("Length:\t\t");
            length = Console.ReadLine();

            //Start invoking logic
            Package package = new Package(weight, height, width, length);

            //Assign to model
            PackageModel packageModel = package.InitPackage();

            if (packageModel == null)
               return;

            //Category and Cost output
            Console.WriteLine(string.Format("Category:\t{0}", packageModel.Category));
            Console.WriteLine(string.Format("Cost:\t\t${0}", packageModel.Cost));
         }
         catch (Exception ex)
         {
            Log.Exception(ex);
         }
         finally
         {
            Log.Output();
            Console.ReadLine();
         }
      }
   }
}
