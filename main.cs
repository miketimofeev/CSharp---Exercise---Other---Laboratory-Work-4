using System;
using System.Linq;
using LaboratoryWork.Utils;
using LaboratoryWork.Extensions;

namespace LaboratoryWork
{
  internal static class MainClass
  {
    private static void Main()
    {
      double[,] z = LaboratoryWork.Utils.Matrix.ReadDouble(Base.ReadInt32("Please enter z matrix row count value: "), Base.ReadInt32("Please enter z matrix row column value: "), "Please enter z[{0}, {1}] value: ").PrintLine(", ");
      
      z.ToRows().Where(row => row.Any(item => item < 0)).Select(row => row.Where(item => item != 0).Average()).PrintLine(", ").ToArray();
    }
  }
}
