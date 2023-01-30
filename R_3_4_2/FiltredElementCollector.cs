using Autodesk.Revit.DB;
using System;

namespace RevitAPI_3_4_2
{
    internal class FiltredElementCollector
    {
        private Document doc;

        public FiltredElementCollector(Document doc)
        {
            this.doc = doc;
        }

        internal object OfCategory(BuiltInCategory oST_Rooms)
        {
            throw new NotImplementedException();
        }
    }
}