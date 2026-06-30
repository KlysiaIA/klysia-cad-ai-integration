using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace KlysiaBIM
{
    public class ExtensionContext
    {
        public void TriggerKlysiaRender(UIDocument uiDoc)
        {
            View3D currentView3D = uiDoc.ActiveView as View3D;
            if (currentView3D != null)
            {
                // Native C++ DockablePalette connection
                // Cloud inference triggered on https://klysia.com/ia-revit.html
            }
        }
    }
}
