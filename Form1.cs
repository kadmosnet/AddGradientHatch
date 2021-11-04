using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DXFReaderNET;
namespace AddGradientHatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            int j;
            int n = 0;

            dxfReaderNETControl1.NewDrawing();
            dxfReaderNETControl1.SetLimits(new Vector2(-1, -1), new Vector2(31, 31));
            for (k = 0; k <= 2; k++)
            {
                for (j = 0; j <= 2; j++)
                {
                    List<DXFReaderNET.Entities.LwPolylineVertex> polyVertexes = new List<DXFReaderNET.Entities.LwPolylineVertex>();
                    polyVertexes.Add(new DXFReaderNET.Entities.LwPolylineVertex(j * 10, k * 10));
                    polyVertexes.Add(new DXFReaderNET.Entities.LwPolylineVertex(j * 10 + 9, k * 10));
                    polyVertexes.Add(new DXFReaderNET.Entities.LwPolylineVertex(j * 10 + 9, k * 10 + 9));
                    polyVertexes.Add(new DXFReaderNET.Entities.LwPolylineVertex(j * 10, k * 10 + 9));

                    List<DXFReaderNET.Entities.EntityObject> Boundary = new List<DXFReaderNET.Entities.EntityObject>();
                    Boundary.Add(dxfReaderNETControl1.AddLightWeightPolyline(polyVertexes, true));

                    DXFReaderNET.Entities.HatchGradientPatternType hgType = (DXFReaderNET.Entities.HatchGradientPatternType)n;
                    n += 1;

                    Vector3 Position = polyVertexes[3].Position.ToVector3() + new Vector3(0, 0.2, 0);
                    dxfReaderNETControl1.AddText(hgType.ToString(), Position, Position, 0.7);

                    dxfReaderNETControl1.AddGradientHatch(hgType, Boundary);
                }
            }

            dxfReaderNETControl1.ZoomLimits();
            dxfReaderNETControl1.Refresh();
        }
    }
}
