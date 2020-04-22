using System.ComponentModel;

namespace CodingExercise
{
   public enum RulesEnum
   {
      [Description("Rejected")]
      Rejected,

      [Description("Heavy Package")]
      HeavyPackage,

      [Description("Small Package")]
      SmallPackage,

      [Description("Medium Package")]
      MediumPackage,

      [Description("Large Package")]
      LargePackage
   }
}
