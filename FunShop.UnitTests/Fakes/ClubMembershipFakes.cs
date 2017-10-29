using FunShop.Model;
using FunShop.UnitTests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.UnitTests
{
    public class ClubMembershipFakes
    {
        public static IList<PurchaseOrderItem> GetBookClubMemberships()
        {
            var bookClubMemberships = new List<PurchaseOrderItem>();
            bookClubMemberships.Add(new BookClubMembership("Book clubmembership 1", FakeCustomer.GetCustomer()));
            bookClubMemberships.Add(new BookClubMembership("Book clubmembership 2", FakeCustomer.GetCustomer()));
            bookClubMemberships.Add(new BookClubMembership("Book clubmembership 3", FakeCustomer.GetCustomer()));
            bookClubMemberships.Add(new BookClubMembership("Book clubmembership 4", FakeCustomer.GetCustomer()));
            bookClubMemberships.Add(new BookClubMembership("Book clubmembership 5", FakeCustomer.GetCustomer()));
            return bookClubMemberships;
        }

        public static IList<PurchaseOrderItem> GetVideoClubMemberships()
        {
            var videoClubMemberships = new List<PurchaseOrderItem>();
            videoClubMemberships.Add(new VideoClubMembership("Video clubmembership1", FakeCustomer.GetCustomer()));
            videoClubMemberships.Add(new VideoClubMembership("Video clubmembership2", FakeCustomer.GetCustomer()));
            videoClubMemberships.Add(new VideoClubMembership("Video clubmembership3", FakeCustomer.GetCustomer()));
            videoClubMemberships.Add(new VideoClubMembership("Video clubmembership4", FakeCustomer.GetCustomer()));
            videoClubMemberships.Add(new VideoClubMembership("Video clubmembership5", FakeCustomer.GetCustomer()));
            return videoClubMemberships;
        }


        public static ClubMembership GetBookClubMembership()
        {
            return new BookClubMembership("Book clubmembership 1", FakeCustomer.GetCustomer());
        }

        public static ClubMembership GetVideoClubMembership()
        {
            return new VideoClubMembership("Video clubmembership1", FakeCustomer.GetCustomer());
        }


        public static IList<PurchaseOrderItem> GetUltimateClubMemberships()
        {
            var ultimateClubMemberships = new List<PurchaseOrderItem>();
            ultimateClubMemberships.Add(new UltimateClubMembership("Ultimate clubmembership 1", FakeCustomer.GetCustomer()));
            ultimateClubMemberships.Add(new UltimateClubMembership("Ultimate clubmembership 2", FakeCustomer.GetCustomer()));
            ultimateClubMemberships.Add(new UltimateClubMembership("Ultimate clubmembership 3", FakeCustomer.GetCustomer()));
            ultimateClubMemberships.Add(new UltimateClubMembership("Ultimate clubmembership 4", FakeCustomer.GetCustomer()));
            ultimateClubMemberships.Add(new UltimateClubMembership("Ultimate clubmembership 5", FakeCustomer.GetCustomer()));

            return ultimateClubMemberships;
        }


        public static ClubMembership GetUltimateClubMembership()
        {
            return new UltimateClubMembership("Ultimate clubmembership 1", FakeCustomer.GetCustomer());
        }
    }
}
