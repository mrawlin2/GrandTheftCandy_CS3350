using System;

namespace GrandTheftCandy
{
#if WINDOWS || XBOX
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      static void Main(string[] args)
   {
         using (GTC_Level1 game = new GTC_Level1())
         {
            game.Run();
         }
      }
   }
#endif
}

