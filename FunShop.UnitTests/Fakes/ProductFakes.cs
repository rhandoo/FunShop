using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.UnitTests
{
    public class ProductFakes
    {
        public static IList<PurchaseOrderItem> GetBooks()
        {
            var books = new List<PurchaseOrderItem>();
            books.Add(new Book("Book1", "Book1Author", 123.90m));
            books.Add(new Book("Book2", "Book2Author", 154.90m));
            books.Add(new Book("Book3", "Book3Author", 178.90m));
            books.Add(new Book("Book4", "Book4Author", 11.90m));
            books.Add(new Book("Book5", "Book5Author", 167.90m));
            return books;
        }

        public static IList<PurchaseOrderItem> GetVideos()
        {
            var videos = new List<PurchaseOrderItem>();
            videos.Add(new Video("Video1", 123.90m, 12, "VideoDirector1"));
            videos.Add(new Video("Video2", 13.90m, 12, "VideoDirector2"));
            videos.Add(new Video("Video3", 13.90m, 12, "VideoDirector3"));
            videos.Add(new Video("Video4", 123.90m, 12, "VideoDirector4"));
            videos.Add(new Video("Video5", 13.90m, 12, "VideoDirector5"));
            return videos;
        }


        public static Product GetBook()
        {
            return (new Book("Book1", "Book1Author", 123.90m));
        }

        public static Product GetVideo()
        {
            return (new Video("Video1", 123.90m, 12, "VideoDirector1"));
        }
    }
}
