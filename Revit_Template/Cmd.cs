using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;


namespace AB_Revit_Template
{
    [Transaction(TransactionMode.ReadOnly)]
    public class CmdShowMessage : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
                                ref string message,
                                ElementSet elements)
        {
            TaskDialog.Show("Title", "Hola Mundo");

            return Result.Succeeded;
        }
    }
}
