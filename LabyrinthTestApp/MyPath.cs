using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthTestApp
{
    public class MyPath
    {
        public bool IsPath { get; set; } 
        public string ImgPath { get; set; }
        public int CurrentPos { get; set; }
        public PictureBox PictureBox { get; set; }

        public MyPath(bool isPath, string imgPath, PictureBox picB)
        {
            if (!(String.IsNullOrEmpty(imgPath)))
            {
                ImgPath = imgPath;
            }

            if (isPath == true) 
            {
                IsPath = true;
            }

            PictureBox = picB;

        }

        public MyPath(bool isPath, string imgPath, PictureBox picB, int currentPos)
        {
            if (!(String.IsNullOrEmpty(imgPath)))
            {
                ImgPath = imgPath;
            }

            if (isPath == true) 
            {
                IsPath = true;
            }

            PictureBox = picB;

            CurrentPos = currentPos;

        }

        public MyPath(bool isPath)
        {
            if (isPath == true)
            {
                IsPath = true;
            }
        }
    }
}
