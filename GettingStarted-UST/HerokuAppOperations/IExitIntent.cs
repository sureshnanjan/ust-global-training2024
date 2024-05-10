using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IExitIntent : IHerokuAppOperations
    {
        ///<summary>
        ///Get the Title
        ///<summary>
        public string GetTitle();

        /// <summary>
        /// Get the Description
        /// </summary>
        public void moustOutOfView();

        /// <summary>
        /// Get the status of Modal Window
        /// </summary>
        /// <returns>Boolean Status</returns>
        public bool getModalWindowStatus();

        /// <summary>
        /// Get the Title of Modal WIndow
        /// </summary>
        /// <returns>String TItle</returns>
        public string getModalWIndowTitle();

        /// <summary>
        /// Close the Modal WIndow
        /// </summary>
        public void closeModalWindow();
    }
}
