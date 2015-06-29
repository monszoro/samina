using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;
namespace TravelAgency
{
   public static  class TravelAgenceMasterClass
    {
       public static User CurrentUser;
       public static Branch CurrentBranch;
       public static TravelAgencyEntities TravelAgencyContext=new TravelAgencyEntities();
       public const int MainAccountID = 1;
       public static void resetTravelAgencyEntities()
       {
           TravelAgencyContext = new TravelAgencyEntities();
       }
    }
}
