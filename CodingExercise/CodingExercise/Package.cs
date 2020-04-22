using System;

namespace CodingExercise
{
   public class Package : PackageLogic
   {
      string _weight = string.Empty;
      string _height = string.Empty;
      string _width = string.Empty;
      string _length = string.Empty;

      public Package(string weight, string height, string width, string length)
      {
         _weight = weight;
         _height = height;
         _width = width;
         _length = length;
      }

      /// <summary>
      /// Initialize data for package.
      /// </summary>
      /// <param name="package"></param>
      /// <returns></returns>
      public PackageModel InitPackage()
      {
         PackageModel package = null;

         try
         {
            package = ValidatePackage();

            if (package == null)
               return null;

            package.Category = GetCategory(package);
            package.Cost = CalculateCost(package);
         }
         catch (Exception ex)
         {
            Log.Exception(ex);
         }

         return package;
      }

      /// <summary>
      /// Validate and map inputs to Package model.
      /// </summary>
      /// <returns></returns>
      private PackageModel ValidatePackage()
      {
         bool isValid = true;

         int weight = 0;
         int height = 0;
         int width = 0;
         int length = 0;

         try
         {
            if (string.IsNullOrWhiteSpace(_weight) || !int.TryParse(_weight, out weight))
            {
               Log.Message("Weight is invalid.");
               isValid = false;
            }

            if (string.IsNullOrWhiteSpace(_height) || !int.TryParse(_height, out height))
            {
               Log.Message("Height is invalid.");
               isValid = false;
            }

            if (string.IsNullOrWhiteSpace(_width) || !int.TryParse(_width, out width))
            {
               Log.Message("Width is invalid.");
               isValid = false;
            }

            if (string.IsNullOrWhiteSpace(_length) || !int.TryParse(_length, out length))
            {
               Log.Message("Length is invalid.");
               isValid = false;
            }
         }
         catch (Exception ex)
         {
            Log.Exception(ex);
         }

         if (!isValid)
            return null;
         else
            return new PackageModel()
            {
               Weight = weight,
               Height = height,
               Width = width,
               Length = length
            };
      }
   }
}
