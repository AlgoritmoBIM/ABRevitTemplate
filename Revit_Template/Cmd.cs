//Sistema Basico
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Revit Basico
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;


namespace Comando
{
    [Transaction(TransactionMode.Manual)]

    public class Comando : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Seleccionar elementos de Revit antes de invocar este comando

            //Obtener el identificador del documento actual
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            //Acceder a la seleccion actual
            Selection Seluidoc = uidoc.Selection;

            //Crear la lista de elementos IDs
            ICollection<ElementId> ListaElementosId = Seluidoc.GetElementIds();

            //Primer Caso
            if (ListaElementosId.Count == 0)
            {
                //en caso de no seleccionar nada
                TaskDialog.Show("Titulo de ventana", "no existe elementos seleccionados. seleccionar antes de usar funcion");
            }
            //Segundo Caso
            else
            {
                String info = "los elementos ID son";
                //Para trabajar listas se aplica un Foreach
                foreach (var elementos in ListaElementosId)
                {
                    info += "\n" + elementos;
                }

                TaskDialog.Show("Titulo de ventana", info);
            }

            return Result.Succeeded;
        
        }
    }
}