using System;

namespace csharp_rockpaperscissors.Models
{
  class Game
  {
    public string generateComputerMove()
    {
      Random random = new Random();
      int num = random.Next(3);
      if (num == 0)
      {
        return "PYRO";
      }
      else if (num == 1)
      {
        return "CRYO";
      }
      else
      {
        return "HYDRO";
      }
    }
  }
}
