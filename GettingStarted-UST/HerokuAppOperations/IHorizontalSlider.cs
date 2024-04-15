using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// this interface contains methods to be implemented for Horizontal Slider page
    /// <returns></returns> 
    public interface IHorizontalSlider
    {

        /// <summary>
        /// this returns the title of the page
        /// <returns></returns> 
        public string getTitle();

        /// <summary>
        /// this method will retrieve the current position of the slidebar and returns current position as float
        /// <returns>float</returns> 
        public float getSlidePosition();


        /// <summary>
        /// this method performs forward and backward sliding on the bar
        /// <returns></returns> 
        public void SlidetheBar(int n);


        /// <summary>
        /// this method validates the text present on the screen
        /// <returns></returns> 
        public Boolean validateScreenText(string text);
    }
}
