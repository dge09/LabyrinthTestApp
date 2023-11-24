using System.Windows.Forms;

namespace LabyrinthTestApp
{
    public partial class Form1 : Form
    {
        public List<MyPath> pathList = new List<MyPath>();
        public List<PictureBox> myPicBoxes = new List<PictureBox>();
        public TargetField targetField = new(true, 37);

        public Form1()
        {
            InitializeComponent();

            //this.PreviewKeyDown += Form1_PreviewKeyDown;

            List<PictureBox> myPicBoxes = InitPictureBox();

            pathList = InitMyPathList();

            int i = 1;

            foreach (PictureBox item in myPicBoxes)
            {
                item.Image = Image.FromFile(pathList[i].ImgPath);
                i++;
            }


        }

        private List<MyPath> InitMyPathList()
        {
            List<MyPath> pathList = new List<MyPath>();

            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox0, 0));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox1, 1));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\pathAndPlayer.jpg", pictureBox2, 2));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox3, 3));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox4, 4));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox5, 5));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox6, 6));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox7, 7));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox8, 8));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox9, 9));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox10, 10));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox11, 11));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox12, 12));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox13, 13));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox14, 14));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox15, 15));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox16, 16));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox17, 17));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox18, 18));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox19, 19));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox20, 20));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox21, 21));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox22, 22));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox23, 23));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox24, 24));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox25, 25));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox26, 26));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox27, 27));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox28, 28));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox29, 29));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox30, 30));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox31, 31));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox32, 32));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox33, 33));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg", pictureBox34, 34));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox35, 35));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox36, 36));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox37, 37));
            pathList.Add(new MyPath(true, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\target.jpg", pictureBox38, 38));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox39, 39));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox40, 40));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox41, 41));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox42, 42));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox43, 43));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox44, 44));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox45, 45));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox46, 46));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox47, 47));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox48, 48));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox49, 49));
            pathList.Add(new MyPath(false, @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\wall.jpg", pictureBox50, 50));

            return pathList;

        }

        private List<PictureBox> InitPictureBox()
        {
            List<PictureBox> myPicBoxes = new List<PictureBox>();
            myPicBoxes.Add(pictureBox1);
            myPicBoxes.Add(pictureBox2);
            myPicBoxes.Add(pictureBox3);
            myPicBoxes.Add(pictureBox4);
            myPicBoxes.Add(pictureBox5);
            myPicBoxes.Add(pictureBox6);
            myPicBoxes.Add(pictureBox7);
            myPicBoxes.Add(pictureBox8);
            myPicBoxes.Add(pictureBox9);
            myPicBoxes.Add(pictureBox10);
            myPicBoxes.Add(pictureBox11);
            myPicBoxes.Add(pictureBox12);
            myPicBoxes.Add(pictureBox13);
            myPicBoxes.Add(pictureBox14);
            myPicBoxes.Add(pictureBox15);
            myPicBoxes.Add(pictureBox16);
            myPicBoxes.Add(pictureBox17);
            myPicBoxes.Add(pictureBox18);
            myPicBoxes.Add(pictureBox19);
            myPicBoxes.Add(pictureBox20);
            myPicBoxes.Add(pictureBox21);
            myPicBoxes.Add(pictureBox22);
            myPicBoxes.Add(pictureBox23);
            myPicBoxes.Add(pictureBox24);
            myPicBoxes.Add(pictureBox25);
            myPicBoxes.Add(pictureBox26);
            myPicBoxes.Add(pictureBox27);
            myPicBoxes.Add(pictureBox28);
            myPicBoxes.Add(pictureBox29);
            myPicBoxes.Add(pictureBox30);
            myPicBoxes.Add(pictureBox31);
            myPicBoxes.Add(pictureBox32);
            myPicBoxes.Add(pictureBox33);
            myPicBoxes.Add(pictureBox34);
            myPicBoxes.Add(pictureBox35);
            myPicBoxes.Add(pictureBox36);
            myPicBoxes.Add(pictureBox37);
            myPicBoxes.Add(pictureBox38);
            myPicBoxes.Add(pictureBox39);
            myPicBoxes.Add(pictureBox40);
            myPicBoxes.Add(pictureBox41);
            myPicBoxes.Add(pictureBox42);
            myPicBoxes.Add(pictureBox43);
            myPicBoxes.Add(pictureBox44);
            myPicBoxes.Add(pictureBox45);
            myPicBoxes.Add(pictureBox46);
            myPicBoxes.Add(pictureBox47);
            myPicBoxes.Add(pictureBox48);
            myPicBoxes.Add(pictureBox49);
            myPicBoxes.Add(pictureBox50);

            return myPicBoxes;

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var curpos = pathList.FirstOrDefault(a => a.ImgPath.EndsWith("pathAndPlayer.jpg"));
            string currentPosition = curpos.CurrentPos.ToString();
            int topField = (int.Parse(currentPosition)) - 10;
            int bottomfield = (int.Parse(currentPosition)) + 10;
            int leftField = (int.Parse(currentPosition)) - 1;
            int rightField = (int.Parse(currentPosition)) + 1;

            switch (e.KeyCode)
            {
                case Keys.Up:

                    if (currentPosition != "2" && pathList[topField].IsPath == true)
                    {
                        pathList[int.Parse(currentPosition)].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg";
                        pathList[topField].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\pathAndPlayer.jpg";

                        pathList[int.Parse(currentPosition)].PictureBox.Image = Image.FromFile(pathList[int.Parse(currentPosition)].ImgPath);
                        pathList[topField].PictureBox.Image = Image.FromFile(pathList[topField].ImgPath);
                    }
                    else
                    {
                        LError.Text = ("Can't move there!");
                    }

                    break;
                case Keys.Down:

                    if (pathList[bottomfield].ImgPath.EndsWith("path.jpg") == true || pathList[bottomfield].ImgPath.EndsWith("target.jpg") == true)
                    {
                        pathList[int.Parse(currentPosition)].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg";
                        pathList[bottomfield].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\pathAndPlayer.jpg";

                        pathList[int.Parse(currentPosition)].PictureBox.Image = Image.FromFile(pathList[int.Parse(currentPosition)].ImgPath);
                        pathList[bottomfield].PictureBox.Image = Image.FromFile(pathList[bottomfield].ImgPath);
                    }
                    else
                    {
                        LError.Text = ("Can't move there!");
                    }

                    Refresh();

                    break;
                case Keys.Left:


                    if (!(currentPosition.EndsWith("1")) && pathList[leftField].IsPath == true)
                    {
                        pathList[int.Parse(currentPosition)].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg";
                        pathList[leftField].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\pathAndPlayer.jpg";

                        pathList[int.Parse(currentPosition)].PictureBox.Image = Image.FromFile(pathList[int.Parse(currentPosition)].ImgPath);
                        pathList[leftField].PictureBox.Image = Image.FromFile(pathList[leftField].ImgPath);
                    }
                    else
                    {
                        LError.Text = ("Can't move there!");
                    }


                    break;
                case Keys.Right:


                    if (pathList[rightField].IsPath == true)
                    {
                        pathList[int.Parse(currentPosition)].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\path.jpg";
                        pathList[rightField].ImgPath = @"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\pathAndPlayer.jpg";

                        pathList[int.Parse(currentPosition)].PictureBox.Image = Image.FromFile(pathList[int.Parse(currentPosition)].ImgPath);
                        pathList[rightField].PictureBox.Image = Image.FromFile(pathList[rightField].ImgPath);
                    }
                    else
                    {
                        LError.Text = ("Can't move there!");
                    }

                    break;
            }
            e.IsInputKey = true; // Dies ist wichtig, um die Pfeiltasten als Eingabetaste zu behandeln.

            curpos = pathList.FirstOrDefault(a => a.ImgPath.EndsWith("pathAndPlayer.jpg"));
            currentPosition = curpos.CurrentPos.ToString();

            if (int.Parse(currentPosition) == targetField.FinishField)
            {
                curpos.PictureBox.Image = Image.FromFile(@"C:\Users\DominikG\source\repos\04_School\LabyrinthTestApp\Imgs\winner.jpg");
                MessageBox.Show("You found the way! Nice!");

                
            }   
        }
    }
}
