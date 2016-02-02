using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedContactos.Util
{
   public static class Cadenas
    {
        // <ActivityIndicator IsVisible = "{Binding IsBusy,Mode=TwoWay}"
        //             IsRunning="{Binding IsBusy,Mode=TwoWay}"
        //             VerticalOptions="CenterAndExpand"
        //RelativeLayout.XConstraint="{ConstraintExpression 
        //             Type=RelativeToParent,
        //             Property=Height,Factor=0.20}"
        //RelativeLayout.YConstraint="{ConstraintExpression 
        //             Type=RelativeToParent,Property=Height,
        //             Factor=0.40}"
        //             />
       public static String Url = "http://appcontactosapi.azurewebsites.net/api";

       public static string FicheroSettings = "contact.dat";
       public static Dictionary<String, Object> Session=
            new Dictionary<String,Object>();

    }
}
