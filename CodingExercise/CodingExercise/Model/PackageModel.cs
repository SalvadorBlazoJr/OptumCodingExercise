namespace CodingExercise
{
   /// <summary>
   /// Measurements
   /// Weight  = kg
   /// Height  = cm
   /// Width   = cm
   /// Length  = cm
   /// Volume  = cm (Length x Width x Height)
   /// </summary>
   public class PackageModel
   {
      public int Weight { get; set; }
      public int Height { get; set; }
      public int Width { get; set; }
      public int Length { get; set; }
      public RulesEnum Category { get; set; }
      public string Cost { get; set; }
      public int Volume
      {
         get
         {
            return Length * Width * Height;
         }
      }
   }
}
