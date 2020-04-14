using System;

namespace StructsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning Class vs Struct");
            CoordinatePoint classCoordinate = new CoordinatePoint(0.82F, 0.34F);
            CoordinatePointStruct structCoordinate = new CoordinatePointStruct(0.82F, 0.34F);
            Console.WriteLine("Initial Coordinates for Class are: " + classCoordinate.xCoordinate.ToString() + ", " + classCoordinate.yCoordinate.ToString());
            Console.WriteLine("Initial Coordinates for Struct are: " + structCoordinate.xCoordinate.ToString() + ", " + structCoordinate.yCoordinate.ToString());
            ChangeValuesClass(classCoordinate);
            ChangeValuesStruct(structCoordinate);
            Console.WriteLine("Changed Coordinates for Class are: " + classCoordinate.xCoordinate.ToString() + ", " + classCoordinate.yCoordinate.ToString());
            Console.WriteLine("Changed Coordinates for Struct are: " + structCoordinate.xCoordinate.ToString() + ", " + structCoordinate.yCoordinate.ToString());
            Console.ReadLine();
            // Because the class is a reference type, the changevalues method, the value of an object of Class is persisted across different scopes of the program.
            // Because the struct is a value type, when the change values method is called, the passed in value is a copy of the original and only affects the local version of that value.
        }

        static void ChangeValuesClass(CoordinatePoint obj)
        {
            obj.xCoordinate = .5F;
            obj.yCoordinate = .5F;
        }

        static void ChangeValuesStruct(CoordinatePointStruct obj)
        {
            obj.xCoordinate = .5F;
            obj.yCoordinate = .5F;
        }
    }
}
