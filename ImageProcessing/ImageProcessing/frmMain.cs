using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; //
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ronan Almeida
//November 2018
//Program- Assignment 2.5: ImageProcessing
//Purpose: The purpose of this program is to load images and edit them  by basic process (e.g blur, darken whiten) and to have these effects stacked

//Enhancements: 
// - Feature to save pictures
// - Added a "Brighten" Process, increases brightness of an image
// - Redesign of the entire Form, made it look more like photoshop 

namespace ImageProcessing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       //Create the outlines where the pixels/colors are going to be stored into
        private Color[,] originalPic;
        private Color[,] transformedPic;
        private Color[,] temporaryPic;
        private int OrgHeight;
        private int OrgWidth;

        //create a bitmap to store the file in
        Bitmap bmp;

        Process ImageProcess = new Process(); //Create an instance of the Process called called ImageProcess


        private void tabLoad_Click(object sender, EventArgs e)
        {
            //try catch should handle any errors for invalid picture files
            try
            {
            
                //open the file dialog to select a picture file
                OpenFileDialog fd = new OpenFileDialog();

                if (fd.ShowDialog() == DialogResult.OK)
                {


                    Bitmap ErrorTestingBmp = new Bitmap(fd.FileName); //Placeholder Bitmap to test if the diemensions dont give out any errors

                    //Calling method errordetection to check diemensions of array
                    if (ImageProcess.errorSizeDetection(ErrorTestingBmp) == true) //if there is an error, do nothing, The method will notify user about it
                    {

                    }
                    else if(ImageProcess.errorSizeDetection(ErrorTestingBmp) == false) //if there isnt any error, then continue
                    {
                        //store the selected file into a bitmap
                        bmp = new Bitmap(fd.FileName);

                        //create the arrays that store the colours for the image
                        //the size of the arrays is based on the height and width of the bitmap
                        //initially both the original and transformedPic arrays will be identical
                        originalPic = new Color[bmp.Width, bmp.Height];
                        transformedPic = new Color[bmp.Width, bmp.Height];
                        temporaryPic = new Color[bmp.Width, bmp.Height];

                        OrgWidth = bmp.Width;
                        OrgHeight = bmp.Height;

                        //load each color into a color array
                        for (int i = 0; i < bmp.Width; i++)//each row
                        {
                            for (int j = 0; j < bmp.Height; j++)//each column
                            {
                                //assign the colour in the bitmap to the array
                                originalPic[i, j] = bmp.GetPixel(i, j); //transfer pictures from bmp to originalPic Array
                                transformedPic[i, j] = originalPic[i, j];
                                temporaryPic[i, j] = transformedPic[i, j];
                            }
                        }

                        //this will cause the form to be redrawn
                        picBox.Image = bmp;
                        activeButtons(true); //Calls activebuttons method and  Makes the tabs enabled

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Picture File. \n" + ex.Message); //If it catches an error, notify user and display message
            }
        }


        //Method to enable/disable menu tabs on startup and when image is loaded |Except for the Open,Exit and About tab
        //The Menu tabs are enabled (set to true) when pic is loaded
        //The Menu Tabs are diabled (set to false) on startup
        public void activeButtons(bool Appear) //The menuTabs are enabled(true) or disabled(false) depending on the Appear boolean value
        {
            mnuReset.Enabled = Appear;
            mnuInvert.Enabled = Appear;
            mnuDarken.Enabled = Appear;
            mnuWhiten.Enabled = Appear;
            mnuFlipX.Enabled = Appear;
            mnuFlipY.Enabled = Appear;
            mnuMirrorHor.Enabled = Appear;
            tabMirrorVert.Enabled = Appear;
            mnuScale200.Enabled = Appear;
            mnuScale50.Enabled = Appear;
            mnuRotate.Enabled = Appear;
            mnuBlur.Enabled = Appear;
            mnuGray.Enabled = Appear;
            mnuSave.Enabled = Appear;
            mnuBrighten.Enabled = Appear;
        }


        //On Load, when the program opens set the disable the menu tabs (set to false)
        private void frmMain_Load(object sender, EventArgs e)
        {
            activeButtons(false);
        }

        private void tabExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //When User presses exit tab, close application
        }
        
        //Reset function
        private void tabReset_Click(object sender, EventArgs e)
        {

            transformedPic = new Color[OrgWidth, OrgHeight]; //Set the transformed pic to the orginal dimensions 
            bmp = ImageProcess.imageReszie(bmp, OrgWidth, OrgHeight);  //Calling resize method to resize Bitmap to orginal size

            for (int i = 0; i <OrgWidth; i++)  //Loop for width
            {
                for (int j = 0; j <OrgHeight; j++) //Loop for Height
                {
                    //Since transformed pic is reszied, orginial pic is transferred

                    transformedPic[i,j] = originalPic[i,j]; //Transfers picture from orginial pic array  to transformedpic array

                    //extracts the a,r,g,b color for the pixel at[i,j]
                    int a = transformedPic[i,j].A;
                    int r = transformedPic[i,j].R;
                    int g = transformedPic[i,j].G;
                    int b = transformedPic[i,j].B;

                    bmp.SetPixel(i,j, Color.FromArgb(a,r,g,b)); //set the singular pixel with colors to the bmp

                    transformedPic[i,j] = bmp.GetPixel(i,j); //Copy the pixels from bmp to transformedpic

                }
            }

            picBox.Image = bmp; //Display picture to picBox

        }

        //Invert Function
        private void tabInvert_Click(object sender, EventArgs e) 
        {
            for (int i = 0; i < bmp.Width; i++) //Loop for width
            {
                for (int j = 0; j < bmp.Height; j++) //Loop for height
                {
                    //Gets all the a,r,g,b colors for current pixel
                    int a = transformedPic[i, j].A; 
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;

                    bmp.SetPixel(i, j, Color.FromArgb(a, 255 - r, 255 - g, 255 - b)); //Sets the color to the bmp but inverted (255-colour)
                    transformedPic[i, j] = bmp.GetPixel(i, j); //Transformed copies pixels from bmp(updated inverted ones)

                }
              
            }
            picBox.Image = bmp; //Sets picBox to bmp;
        }

        //Darken function
        private void mnuDarken_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++) //Loops for width
            {
                for (int j = 0; j < bmp.Height; j++) //Loops for height
                {
                    //takes argb colours for each pixel and mutliplies it by 0.5
                    int a = transformedPic[i, j].A * 1/2; 
                    int r = transformedPic[i, j].R * 1 / 2; 
                    int g = transformedPic[i, j].G * 1 / 2;
                    int b = transformedPic[i, j].B * 1 / 2;

                    bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b)); //Sets the color of the bmp to these more darkened colours
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transforned pic copies pixels over from bmp

                }
                picBox.Image = bmp; //displays image
            }
        }

        private void tabWhiten_Click(object sender, EventArgs e)
        {
            //Loop for row and column
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {             
                    //To Whiten an image we take the old a,r,g or b and add it to (255-argb/2)
                    int a = transformedPic[i, j].A + (255- transformedPic[i, j].A) /2;  
                    int r = transformedPic[i, j].R + (255 - transformedPic[i, j].R) / 2;
                    int g = transformedPic[i, j].G + (255 - transformedPic[i, j].G) / 2;
                    int b = transformedPic[i, j].B + (255 - transformedPic[i, j].B) / 2;


                    bmp.SetPixel(i, j, Color.FromArgb( a,r, g, b)); //Sets the color of the bmp to the more whitened one
                    transformedPic[i, j] = bmp.GetPixel(i, j); //Transformed pic copies pixels from bmp
                }
            }
            picBox.Image = bmp; //Displays image

        }

        private void brightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //loop for the row and column
            for(int i=0;i<bmp.Width;i++) 
            {
                for(int j=0;j<bmp.Height;j++)
                {
                    //brightness - times each value by 2
                      int a = transformedPic[i, j].A* 2; 
                      int r = transformedPic[i, j].R*2;
                      int g = transformedPic[i, j].G*2;
                      int b = transformedPic[i, j].B * 2;


                    //if a value exceeds 255 then set it to 255- which is max value
                      if(a>255)
                      {
                          a = 255;
                      }
                      if (r>255)
                      {
                          r = 255;
                      }

                      if(g>255)
                      {
                          g = 255;
                      }

                      if(b>255)
                      {
                          b = 255;
                      }

                    bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b)); //set the bmp to more brightened colors
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transformed pic is set to more brightened pixels
                }
            }
            picBox.Image = bmp; //display the image


        }

        //Gray color
        private void tabGray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //let's extract those precious pixel from each channel.. 
                    int a = transformedPic[i, j].A;
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;
                   
                    //lets find average
                    bmp.SetPixel(i, j, Color.FromArgb(a, (r + g + b) / 3, (r + g + b) / 3, (r + g + b) / 3)); //Gets avrg for argb for each current pixel and sets it to that
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transfers bmp pixel to transformed pic

                }
            }

            picBox.Image = bmp; //displays the image
        }

        //Fliping 
        private void tabFlipX_Click(object sender, EventArgs e)
        {
           
            Color[,] placeholdePic = new Color[bmp.Width,bmp.Height]; //Placeholder bitmap  set the the current bitmap's width and height

            //loop to copy the  pixels from transformed pic to placeholder
            for(int i=0;i<bmp.Width;i++)
            {
                for(int j=0;j<bmp.Height;j++)
                {
                    placeholdePic[i, j] = transformedPic[i, j]; //copies pixels from the transformed bitmap to placeholder
                }
            }


            //Loop to flip the image over the x-axis
            for(int i =0;i<bmp.Width;i++)  
            {
                for(int j=0;j<bmp.Height;j++)
                {
                  //gets argb values for current pixel
                    int a = transformedPic[i, j].A;
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;

                    int x = (bmp.Width - i) - 1; //this is used to find the oppoiste end of the bitmap, if width is 600 and i is 0 the new i is 599

                    bmp.SetPixel(x, j ,Color.FromArgb(a, r, g, b)); //sets pixel from other half of side, flips there
                    transformedPic[i, j] = placeholdePic[x, j]; //sets the transformedpic to the placeholder pixels so that it can flip again

                }
            }
            picBox.Image = bmp;          // image is redrawn

        }
        //Flip Y
        private void tabFlipY_Click(object sender, EventArgs e)
        {

            Color[,] placeholdePic = new Color[bmp.Width, bmp.Height]; //Placeholder bitmap  set the the current bitmap's width and height

            //loop to copy the  pixels from transformed pic to placeholder
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    placeholdePic[i, j] = transformedPic[i, j];  //copies pixels from the transformed bitmap to placeholder
                }
            }

            //Loop to flip Y image
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int a = transformedPic[i, j].A;
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;

                    int y = (bmp.Height - j) - 1; //this is used to find the oppoiste end of the bitmap, if height is 800 and j is 0 the new j is 799 - opposite ends


                    bmp.SetPixel(i, y, Color.FromArgb(a, r, g, b)); //sets pixel from other half of side, flips there
                    transformedPic[i, j] = placeholdePic[i, y]; //sets the transformedpic to the placeholder pixels so that it can flip again

                }
            }
            picBox.Image = bmp;  // image is redrawn

        }

        //Mirroring Horizontally
        private void tabMirrorHor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++) //Loop the size of the width
            {
                for (int j = 0; j < bmp.Height; j++) //Loop the size of height
                {
                    transformedPic[(bmp.Width - i) - 1, j] = transformedPic[i, j]; //Sets the left  half of the image to the right half
                                                                                   //(bmp.width-i)-1  |
                                                                                   //basically divides the image into two 
                                                                                   //and copies the original postion of the image to its mirrored opposite
                    int a = transformedPic[i, j].A;                                // eg.  pic[0,0] is set to the same value as pic[799,0]
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;

                    bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b)); //sets the new colors/pic
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transfers over

                }
            }
            picBox.Image = bmp; //displays image

        }
        //Mirroring Vert
        private void tabMirrorVert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Width; i++) //Loop the size of the width
            {
                for (int j = 0; j < bmp.Height; j++) //Loop the size of height
                {
                    transformedPic[i, (bmp.Height - j) - 1] = transformedPic[i, j]; //Sets the top  half of the image to the bottom half
                                                                                    //(bmp.Height - j) - 1
                                                                                    //basically divides the image into two 
                                                                                    //and copies the original postion of the image to its mirrored opposite
                    int a = transformedPic[i, j].A;
                    int r = transformedPic[i, j].R;
                    int g = transformedPic[i, j].G;
                    int b = transformedPic[i, j].B;

                    bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b)); //sets bmp to new colors and pic
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transfers over

                }
            }
            picBox.Image = bmp; //displays image

        }

        //Scaling 50%
        private void tabScale50_Click(object sender, EventArgs e)
        {

          
            bmp = ImageProcess.imageReszie(bmp, bmp.Width / 2, bmp.Height / 2); //calls image resize method to resize  bmp to half its width and height
            //the method catches errors if pic is to small

            if (ImageProcess.isResizeTrue == true) //if the image is reszied
            {
                transformedPic = new Color[bmp.Width, bmp.Height]; //Sets Bmp to twice its size, calls by calling resize method

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        transformedPic[i, j] = bmp.GetPixel(i, j); //copies updated ione over
                    }
                }

            }
            picBox.Image = bmp; //sets bmp to picbox

        }

        //Scale 200%
        private void tabScale200_Click(object sender, EventArgs e)
        {

            try //Try this block of code 
           {
                bmp = ImageProcess.imageReszie(bmp, bmp.Width * 2, bmp.Height * 2); //Sets Bmp to twice its size, calls by calling resize method

                if (ImageProcess.isResizeTrue == true) //Checks if the image is reszied by calling the class bool variable isResize 
                {
                   transformedPic = new Color[bmp.Width, bmp.Height]; //Sets transformed pic to new size 

                    //Loop basically transfers the pixels from bmp to transformed pic 
                    for (int i = 0; i <bmp.Width; i++) 
                    {
                        for (int j = 0; j <bmp.Height; j++)
                        {
                            transformedPic[i, j] = bmp.GetPixel(i, j);

                        }

                    }
                  picBox.Image = bmp; //Display image

               }

            }
            catch (Exception ) //If the code doesnt work, and it catches an error
            { } //Do nothing and leave it, Program wont crash

        }

        private void tabRotate_Click(object sender, EventArgs e)
        {
     
            bmp.RotateFlip(RotateFlipType.Rotate90FlipXY); //Rotate the image once

            transformedPic = new Color[bmp.Width, bmp.Height]; //set the transformed pic to the new diemensions

            //loop for row and column
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    transformedPic[i, j] = bmp.GetPixel(i, j); //transfers pixels over from the new updated one

                }

            }

            picBox.Image = bmp; //displays it
        }



        //Blur
        private void tabBlur_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height ; j++)
                {
                       try //try this block of code
                       {
                           int a = transformedPic[i, j].A;
                           int r = (transformedPic[i - 3, j].R + transformedPic[i, j + 3].R ) / 2; //gets 3 pixels from the left, 3 down and divided by 2 (Average) 
                           int g = (transformedPic[i - 3, j].G + transformedPic[i, j + 3].G ) / 2;
                           int b = (transformedPic[i - 3, j].B + transformedPic[i, j + 3].B ) / 2;

                           bmp.SetPixel(i, j, Color.FromArgb(a, r, g, b)); //sets bmp to these average pixel
                         
                       }
                       catch (Exception) { break; } //if it catches an error than break trhough this loop and continue

                    transformedPic[i, j] = bmp.GetPixel(i, j); //transfers pixels from bmp to tranformed
                }
            }      
            picBox.Image = bmp; //set image

    
            
        }

        //Save
        private void tabSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog(); //open save dialog
            fileDialog.Filter = "Images | *.jpg; *.png; *.bmp"; //the filter can benjpg, png or bmp

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                picBox.Image.Save(fileDialog.FileName); //save the file form the current picbox
            }
        }

        //about
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image Processing | ICS4U © All Rights Reserved"); //when user clicks about, display this message
        }


    }
}
