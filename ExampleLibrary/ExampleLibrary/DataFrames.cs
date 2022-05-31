using Microsoft.Data.Analysis;

namespace ExampleLibrary
{
    public static class DataFrames
    {
        public static DataFrame CreateDataFrameFromExample()
        {
            /*
            Column0,Column1,Column2
            1,2,3
            4,5,6
            7,8,9
            */

            DoubleDataFrameColumn column0 = new("Column0");
            DoubleDataFrameColumn column1 = new("Column1");
            DoubleDataFrameColumn column2 = new("Column2");

            // 1st Row.
            // 1,2,3
            column0.Append(1);
            column1.Append(2);
            column2.Append(3);

            // 2nd Row.
            // 4,5,6
            column0.Append(4);
            column1.Append(5);
            column2.Append(6);

            // 3rd Row.
            // 7,8,9
            column0.Append(7);
            column1.Append(8);
            column2.Append(9);

            return new DataFrame(column0, column1, column2);
        }
    }
}
