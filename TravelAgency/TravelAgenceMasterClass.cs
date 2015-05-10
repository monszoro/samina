using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelAgency
{
   public static  class TravelAgenceMasterClass
    {
       public static User CurrentUser;
       public static Branch CurrentBranch;
       public static TravelAgencyEntities TravelAgencyContext=new TravelAgencyEntities();
    }
}
