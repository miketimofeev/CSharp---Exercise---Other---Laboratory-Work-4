using System;
using System.Linq;
using System.Globalization;
using LaboratoryWork.Utils;
using LaboratoryWork.Extensions;

namespace LaboratoryWork
{
  internal static class MainClass
  {
    private static void Main()
    {
      double[,] z = Matrix.ReadDouble(Base.ReadInt32("Please enter z matrix row count value: "), Base.ReadInt32("Please enter z matrix row column value: "), "Please enter z[{0}, {1}] value: ").PrintLine(", ");
    }
  }
}
