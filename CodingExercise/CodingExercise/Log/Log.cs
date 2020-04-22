using System;
using System.Collections.Generic;

namespace CodingExercise
{
   public static class Log
   {
      public static List<string> _logs = new List<string>();

      /// <summary>
      /// Accept exception type.
      /// </summary>
      /// <param name="ex"></param>
      public static void Exception(Exception ex)
      {
         if (ex == null)
            return;

         string message = ex.Message;
         string stackTrace = ex.StackTrace;

         _logs.Add(string.Format("Message: [{0}] StackTrace: [{1}]", message, stackTrace));
      }

      /// <summary>
      /// Accept string as message.
      /// </summary>
      /// <param name="message"></param>
      public static void Message(string message)
      {
         _logs.Add(message);
      }

      public static void Output()
      {
         if (_logs.Count > 0)
         {
            Console.WriteLine();
            Console.WriteLine("Kindly see the issue(s) below.");
            _logs.ForEach(x => Console.WriteLine(x));
         }

      }
   }
}
