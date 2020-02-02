using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Needed for bitmaps/Color classes
using System.Windows.Forms; //Needed for menutabs/ Messageboxes

namespace ImageProcessing
{
    //This class holds the resizing and error detection methods
    class Process
    {


        //Image Resizing Method

        public bool isResizeTrue = false; //Bool var stating if imaged is resized or not

        //Method to resize bimtap, takes in the old bitmap, and the desired width and height
        //Code is adapted from:   Brian "Resize an image in C#":  https://www.youtube.com/watch?v=_9J7C2u_jIY 

        public Bitmap imageReszie(Bitmap Picture, int width, int height)
        {
            try //Try this block of code
            {
                Size newSize = new Size(width, height); //Setting size parameters with width and height

                Bitmap newResized = new Bitmap(width, height);

                using (Graphics GrapPic = Graphics.FromImage(newResized)) //Uses the graphics system, just alike the top processes to resize bitmap
                {
                    GrapPic.DrawImage(Picture, new Rectangle(Point.Empty, newSize)); //Takes old bitmap picture and reszies it 
                }

                isResizeTrue = true; //Image is reszied, set true
                return newResized; //return the newresized bitmap
            }
            catch (Exception) //If it catches and error that the picture is unable to scale down/ up, then...
            {
                MessageBox.Show("Picture is unable to scale more limit reached "); //Display message saying limit reached
                isResizeTrue = false; //Image is not resized, set false
                return Picture; //return the orginial unchanged bitmap
            }
        }

        //Error detection to see if image is correct size(less than or equal to 800 by 600
        public bool errorSizeDetection(Bitmap bmp)
        {
            if(bmp.Width>800 | bmp.Height>600 | bmp.Width<=0 | bmp.Height<=0) //If image height/width are greater than 800 or 600 and or if it is less than 0
            {
                MessageBox.Show("Error  Loading Pictur \n A Max Image Size of 800 by 600 Pixels Can Be Loaded");
                return true; //Return error true
            }
            else
            {
                return false; //return no error
            }
        }
    }
}
