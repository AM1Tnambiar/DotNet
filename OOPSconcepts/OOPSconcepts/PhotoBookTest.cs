﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    class PhotoBookTest
    {
        public static void Main2()
        {
            PhotoBook myAlbum1 = new PhotoBook();
            Console.WriteLine(myAlbum1.GetNumberPages());

            PhotoBook myAlbum2 = new PhotoBook(24);
            Console.WriteLine(myAlbum2.GetNumberPages());

            SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
            Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        }
    }
    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook()
        {
            numPages = 64;
        }

    }
}
