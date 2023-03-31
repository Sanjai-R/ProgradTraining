using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoBookApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookApplication.Tests
    {
    [TestClass()]
    public class PhotoBookTests
        {
        [TestMethod()]
        public void DefaultPhotoBookTest()
            {
            PhotoBook defaultPhotoBook = new PhotoBook();
            int pagesCount = defaultPhotoBook.GetNumberOfPages();
            Assert.AreEqual( pagesCount,16); 
            
            }

        [TestMethod()]
        public void CustomPhotoBookTest()
            {

            int count = 30;
            PhotoBook customPhotoBook = new PhotoBook(count);
            int pagesCount = customPhotoBook.GetNumberOfPages();
            Assert.AreEqual(pagesCount, count);
           
            }

        [TestMethod()]
        public void LargePhotoBookTest()
            {
            AddPhotoBook large = new AddPhotoBook();
            int pagesCount = large.GetNumberOfPages();
            Assert.AreEqual(pagesCount, 64);

            }
        }
    }