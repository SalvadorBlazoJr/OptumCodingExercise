namespace CodingExercise
{
   public class PackageLogic
   {
      /// <summary>
      /// Category Rules
      /// 1. Weight  greater-than   25 kg    =  Reject
      /// 2. Weight  greater-than   10 kg    =  Heavy Package
      /// 3. Volume  less-than      1500 cm  =  Small Package
      /// 4. Volume  less-than      2500 cm  =  Medium Package
      /// 5.                                    Large Package
      /// </summary>
      /// <param name="package"></param>
      /// <returns></returns>
      protected virtual RulesEnum GetCategory(PackageModel package)
      {
         if (package.Weight > 25)
            return RulesEnum.Rejected;
         else if (package.Weight > 10)
            return RulesEnum.HeavyPackage;
         else if (package.Volume < 1500)
            return RulesEnum.SmallPackage;
         else if (package.Volume < 2500)
            return RulesEnum.MediumPackage;
         else
            return RulesEnum.LargePackage;
      }

      /// <summary>
      /// Cost Computation
      /// 1. Reject           = N/A
      /// 2. Heavy Package    = $15 x Weight
      /// 3. Small Package    = $0.05 x Volume
      /// 4. Medium Package   = $0.04 x Volume
      /// 5. Large Package    = $0.03 x Volume
      /// </summary>
      /// <param name="package"></param>
      /// <returns></returns>
      protected virtual string CalculateCost(PackageModel package)
      {
         string result = string.Empty;

         switch (package.Category)
         {
            case RulesEnum.Rejected:
               result = "N/A";
               break;
            case RulesEnum.HeavyPackage:
               result = (15 * package.Weight).ToString();
               break;
            case RulesEnum.SmallPackage:
               result = (0.05 * package.Volume).ToString();
               break;
            case RulesEnum.MediumPackage:
               result = (0.04 * package.Volume).ToString();
               break;
            case RulesEnum.LargePackage:
               result = (0.03 * package.Volume).ToString();
               break;
         }

         return result;
      }
   }
}
