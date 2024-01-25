using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_winforms_z01
{
    internal class Piramida
    {
        private List<Vector3> coordonate = new List<Vector3>();
        private List<Color> colors = new List<Color>();
        private Random random;
        private bool visibility = true;

        public Piramida()
        {
            random = new Random();

            for(var i = 0; i < 24; i += 4)
            {
                Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                colors.Add(color);
            }
            CitesteCoordonateDinFisier("coordonate.txt");
        }

        private void CitesteCoordonateDinFisier(string numeFisier)
        {
            var file = File.ReadAllLines(numeFisier);

            foreach (var line in file)
            {
                var coord = line.Split(' ');
                coordonate.Add(new Vector3(float.Parse(coord[0]), float.Parse(coord[1]), float.Parse(coord[2])));
            }
        }

    public void DrawTriangle()
    {
        if (!visibility) return;

        GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
        GL.Begin(PrimitiveType.Triangles); // Schimbăm tipul primitivei în Triangles

        var i = 0;
        foreach (var coord in coordonate)
        {
            if (i % 3 == 0) // Pentru fiecare trei coordonate, desenăm un triunghi nou
                GL.Color3(colors[i / 3]);

            GL.Vertex3(coord);
            i++;
        }

        GL.End();
    }

}
}
