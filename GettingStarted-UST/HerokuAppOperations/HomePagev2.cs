using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal sealed class HomePage
    {
        ILogo logo;
        ISearch search;
        IShop shoppingCart;
        IDisplay display;

        public HomePage(ILogo lg, IShop shopcart, ISearch serch)
        {
            
        }

        public void Search() {
            this.search.ToString();
        }

        public void LogoOperation() { 
            this.logo.ToString();
        }
        public int add1020() {
            return 10 + 20;
        }

        public int add100200() {
            return 100 + 200;
        }
        public int add(int param1, int param2) {
            return param1 + param2;
        }

        private void setup() {
            /*
            // Open for extension, closed for modification
            //HomePage v1 = new HomePage(new Logov1());
           // HomePage v2 = new HomePage(new LogoV2());

            int result1020 = v1.add1020();
            int result100200 = v2.add100200();
            int result1020v1 = v1.add(10, 20);



            v1.LogoOperation();
            v2.LogoOperation();
            */

        }

    }

    interface ILogo { }
    interface ISearch { }
    interface IShop { }

    interface IDisplay { }

    interface IDisplayLogoV3 {
        void doLogoOps(ILogo instance);
    }

    

    class Logov1 : ILogo { }
   class LogoV2: ILogo { 
    
    
    }

    



}
