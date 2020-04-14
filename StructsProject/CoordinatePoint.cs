using System;
using System.Collections.Generic;
using System.Text;

namespace StructsProject
{
    class CoordinatePoint
    {
        public float xCoordinate;
        public float yCoordinate;

        public CoordinatePoint()
        {
        }

        public CoordinatePoint(float x, float y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }
    }
    struct CoordinatePointStruct
    {
        public float xCoordinate;
        public float yCoordinate;

        public CoordinatePointStruct(float x, float y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }
    }
}
