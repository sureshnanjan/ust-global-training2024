using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDynamicLoading
    {
        ///<summary>
        ///Get the Url
        ////<summary>
        public void GetUrl();
        ///<summary>
        ///Get the Title
        ////<summary>
        public void GetTitle();

        /// <summary>
        /// Get the Description
        /// </summary>
        public void GetDescription();

        /// <summary>
        /// get the subtitle -Example 1 Element on the page that is hidden
        /// </summary>
        public void SubTitleExample1();

        /// <summary>
        /// get the subtitle - Element rendered after the fact
        /// </summary>
        public void subTitleExample2();


        /// <summary>
        /// clicking on Example1
        /// </summary>
        public void clickOneExample1();

        /// <summary>
        /// clicking on Example2
        /// </summary>
        public void clickOneExample2();

        /// <summary>
        /// click on the Button - Start
        /// </summary>

        public void ButtonStart();




    }

}